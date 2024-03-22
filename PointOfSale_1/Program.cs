using Microsoft.Extensions.DependencyInjection;
using PointOfSale_1.Context;
using PointOfSale_1.Services;
using PointOfSale_1.Services.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1
{
    internal static class Program
    {
        //tozi save button prosto 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var serviceProvider = new ServiceCollection()
                .AddDbContext<DbPosContext>()
                .AddTransient<ICustomerService, CustomerService>()
                .AddTransient<ICategoryService, CategoryService>()
                .AddTransient<IProductService, ProductService>()
                .AddTransient<ISupplierService, SupplierService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IImageService, ImageService>()
                .AddTransient<IBookingService, BookingService>()
                .BuildServiceProvider();

            using (IServiceScope scope = serviceProvider.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbPosContext = services.GetService<DbPosContext>();
                var departmentService = services.GetRequiredService<ICustomerService>();
                var categoryService = services.GetRequiredService<ICategoryService>();
                var productService = services.GetRequiredService<IProductService>();
                var supplierService = services.GetRequiredService<ISupplierService>();
                var userService = services.GetRequiredService<IUserService>();
                var customerService = services.GetRequiredService<ICustomerService>();
                var imageService = services.GetRequiredService<IImageService>();
                var bookingService = services.GetRequiredService<IBookingService>();
                Application.Run(new Login(userService, customerService, productService, supplierService, categoryService, dbPosContext, imageService, bookingService ));
            }
        }
    }
}
