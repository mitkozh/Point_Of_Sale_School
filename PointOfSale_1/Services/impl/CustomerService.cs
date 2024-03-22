using PointOfSale_1.Context;
using PointOfSale_1.Models;
using PointOfSale_1.Services;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PointOfSale_1.Services.impl
{
    public class CustomerService : ICustomerService
    {
        private DbPosContext _dbPosContext;

        public CustomerService(DbPosContext dbPosContext)
        {
            _dbPosContext = dbPosContext;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _dbPosContext.Customers.Find(customerId);
        }

        public Customer AuthenticateUser(string email, string password, string role)
        {
            if (role == "Customer")
            {
                string hashedPassword = HashPassword(password);
                return _dbPosContext.Customers.FirstOrDefault(c => (c.Email == email) && c.Password == hashedPassword);
            }

            return null;
        }

        public void LogoutCustomer()
        {
            LoggedUserOrCustomer.CustomerId = 0;
            LoggedUserOrCustomer.CustomerPassword = null;
            LoggedUserOrCustomer.CustomerName = null;
            LoggedUserOrCustomer.CustomerContact = null;
            LoggedUserOrCustomer.CustomerEmail = null;
            LoggedUserOrCustomer.CustomerAddress = null;
            LoggedUserOrCustomer.CustomerCity = null;

            LoggedUserOrCustomer.IsUser = false;
            LoggedUserOrCustomer.IsCustomer = false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
