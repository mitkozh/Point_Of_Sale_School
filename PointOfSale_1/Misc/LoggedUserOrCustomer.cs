using System;

namespace PointOfSale_1.Models
{
    public static class LoggedUserOrCustomer
    {
        // User Fields
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserFatherName { get; set; }
        public static string UserAddress { get; set; }
        public static string UserContactNo { get; set; }
        public static DateTime UserDateOfBirth { get; set; }
        public static string UserPassword { get; set; }
        public static string UserEmail { get; set; }
        public static string UserType { get; set; }

        // Customer Fields
        public static int CustomerId { get; set; }
        public static string CustomerPassword { get; set; }
        public static string CustomerName { get; set; }
        public static string CustomerContact { get; set; }
        public static string CustomerEmail { get; set; }
        public static string CustomerAddress { get; set; }
        public static string CustomerCity { get; set; }

        // Flags
        public static bool IsUser { get; set; }
        public static bool IsCustomer { get; set; }
        public static bool IsLoggedIn()
        {
            return IsUser || IsCustomer;
        }
    }
}
