using PointOfSale_1.Context;
using PointOfSale_1.Models;
using PointOfSale_1.Services;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class UserService: IUserService
{
    private readonly DbPosContext _dbPosContext;

    public UserService(DbPosContext dbPosContext)
    {
        _dbPosContext = dbPosContext;
    }

    public User AuthenticateUser(string email, string password, string role)
    {
        if (role == "Worker")
        {
            string hashedPassword = HashPassword(password);

            User user = _dbPosContext.Users.FirstOrDefault(w => (w.Email == email));
            if (user != null &&  user.Password == hashedPassword) 
            {
                return user;
            }
        }

        return null;
    }

    public void LogoutUser()
    {
        LoggedUserOrCustomer.UserId = 0;
        LoggedUserOrCustomer.UserName = null;
        LoggedUserOrCustomer.UserFatherName = null;
        LoggedUserOrCustomer.UserAddress = null;
        LoggedUserOrCustomer.UserContactNo = null;
        LoggedUserOrCustomer.UserDateOfBirth = default(DateTime);
        LoggedUserOrCustomer.UserPassword = null;
        LoggedUserOrCustomer.UserEmail = null;
        LoggedUserOrCustomer.UserType = null;

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
