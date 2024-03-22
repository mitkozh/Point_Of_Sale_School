using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        List<Product> GetAll(string name = "", string supplierName = "", DateTime? from = null, DateTime? to = null, string priceFrom = "", string priceTo = "");
        Product GetProductById(int id);
        Product GetProductByName(string text);
        void SaveChanges();
    }
}
