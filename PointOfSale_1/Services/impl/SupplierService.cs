using PointOfSale_1.Context;
using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services.impl
{
    public class SupplierService : ISupplierService
    {

        private DbPosContext _dbPosContext;

        public SupplierService(DbPosContext dbPosContext)
        {
            _dbPosContext = dbPosContext;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _dbPosContext.Suppliers.ToList();
        }

        public Supplier GetByName(string name)
        {
            return _dbPosContext.Suppliers.FirstOrDefault(s => s.Name == name);
        }
    }
}
