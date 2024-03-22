using PointOfSale_1.Context;
using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1.Services.impl
{
    public class CategoryService : ICategoryService
    {
        private DbPosContext _dbPosContext;

        public CategoryService(DbPosContext dbPosContext)
        {
            _dbPosContext = dbPosContext;
        }

        public List<Category> GetAllCategories()
        {
            return _dbPosContext.Categories.ToList();
        }

        public Category GetByName(string name)
        {
            return _dbPosContext.Categories.FirstOrDefault(c=> c.Name == name); 
        }

        public Category AddCategory(Category category)
        {
            try
            {
                if (category == null)
                    throw new ArgumentNullException(nameof(category));

                var validationContext = new ValidationContext(category);
                var validationResults = new List<ValidationResult>();
                if (!Validator.TryValidateObject(category, validationContext, validationResults, true))
                {
                    string errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                _dbPosContext.Categories.Add(category);
                _dbPosContext.SaveChanges();

                MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return category;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding category: {ex.Message}");
                MessageBox.Show("An error occurred while adding the category. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
