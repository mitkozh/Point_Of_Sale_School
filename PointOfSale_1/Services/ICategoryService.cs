using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

        Category GetByName(string name);

        Category AddCategory(Category category);
    }
}
