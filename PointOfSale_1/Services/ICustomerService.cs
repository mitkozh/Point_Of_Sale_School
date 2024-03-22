using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int customerId);

        Customer AuthenticateUser(string email, string password, string role);

        void LogoutCustomer();
    }
}
