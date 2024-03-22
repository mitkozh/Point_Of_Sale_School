using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSuppliers();
        Supplier GetByName(string name);
    }
}
