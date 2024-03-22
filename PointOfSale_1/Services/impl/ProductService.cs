using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using PointOfSale_1.Context;
using PointOfSale_1.Models;
using System.Data.Entity.Core.Objects;
using Microsoft.EntityFrameworkCore;

namespace PointOfSale_1.Services
{
    public class ProductService : IProductService
    {
        private readonly DbPosContext _dbContext;

        public ProductService(DbPosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product AddProduct(Product product)
        {
            try
            {
                if (product == null)
                    throw new ArgumentNullException(nameof(product));

                var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(product);
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                if (!Validator.TryValidateObject(product, validationContext, validationResults, true))
                {
                    string errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                _dbContext.Products.Add(product);
                SaveChanges();

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding currentProduct: {ex.Message}");
                MessageBox.Show("An error occurred while adding the currentProduct. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();

        }


        public List<Product> GetAll(string name = "", string supplierName = "", DateTime? from = null, DateTime? to = null, string priceFrom = "", string priceTo = "")
        {
            IQueryable<Product> qry = _dbContext.Products;

            if (!string.IsNullOrEmpty(name))
            {
                qry = qry.Where(p => EF.Functions.Like(p.ItemName, $"%{name}%"));
            }
            if (!string.IsNullOrEmpty(supplierName))
            {
                qry = qry.Where(p => p.Supplier.Name==supplierName);
            }
            if (from != null)
            {
                qry = qry.Where(p => p.ExpireDate >= from);
            }
            if (to != null)
            {
                qry = qry.Where(p => p.ExpireDate <= to);
            }
            if (!string.IsNullOrEmpty(priceFrom))
            {
                decimal pr;
                if (decimal.TryParse(priceFrom, out pr))
                {
                    qry = qry.Where(p => p.SalesPrice >= pr);
                }
            }
            if (!string.IsNullOrEmpty(priceTo))
            {
                decimal pr;
                if (decimal.TryParse(priceTo, out pr))
                {
                    qry = qry.Where(p => p.SalesPrice <= pr);
                }
            }

            return qry.ToList();
        }


        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public Product GetProductByName(string text)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ItemName == text);
        }
    }
}
