using MaterialSkin.Controls;
using PointOfSale_1.Context;
using PointOfSale_1.Models;
using PointOfSale_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1
{
    public partial class Login : MaterialForm
    {
        private MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly IUserService _userService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private readonly ICategoryService _categoryService;
        private readonly DbPosContext _dbPosContext;
        private readonly IImageService _imageService;
        private readonly IBookingService _bookingService;

        public Login(
            IUserService userService,
            ICustomerService customerService,
            IProductService productService,
            ISupplierService supplierService,
            ICategoryService categoryService,
            DbPosContext dbPosContext,
            IImageService imageService,
            IBookingService bookingService)
        {
            _userService = userService;
            _customerService = customerService;
            _productService = productService;
            _supplierService = supplierService;
            _categoryService = categoryService;
            _dbPosContext = dbPosContext;
            _imageService = imageService;
            _bookingService = bookingService;

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string email = materialTextBox1.Text;
            string password = materialTextBox2.Text;
            string role = materialComboBox1.SelectedItem.ToString();

            if (role == "Worker")
            {
                var user = _userService.AuthenticateUser(email, password, role);
                if (user != null)
                {
                    LoggedUserOrCustomer.UserId = user.Id;
                    LoggedUserOrCustomer.UserName = user.Name;
                    LoggedUserOrCustomer.UserFatherName = user.FatherName;
                    LoggedUserOrCustomer.UserAddress = user.Address;
                    LoggedUserOrCustomer.UserContactNo = user.ContactNo;
                    LoggedUserOrCustomer.UserDateOfBirth = user.DateOfBirth;
                    LoggedUserOrCustomer.UserPassword = user.Password;
                    LoggedUserOrCustomer.UserEmail = user.Email;
                    LoggedUserOrCustomer.UserType = "Seller";

                    LoggedUserOrCustomer.IsUser = true;
                    LoggedUserOrCustomer.IsCustomer = false;
                    this.Hide();
                    var stockForm = new Stocks(
                        _productService,
                        _supplierService,
                        _categoryService,
                        _dbPosContext,
                        _imageService,
                        _bookingService,
                        _customerService, _userService);
                    stockForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/email or password for worker.");
                }
            }
            else if (role == "Customer")
            {
                var customer = _customerService.AuthenticateUser(email, password, role);
                if (customer != null)
                {
                    LoggedUserOrCustomer.CustomerId = customer.Id;
                    LoggedUserOrCustomer.CustomerPassword = customer.Password;
                    LoggedUserOrCustomer.CustomerName = customer.Name;
                    LoggedUserOrCustomer.CustomerContact = customer.Contact;
                    LoggedUserOrCustomer.CustomerEmail = customer.Email;
                    LoggedUserOrCustomer.CustomerAddress = customer.Address;
                    LoggedUserOrCustomer.CustomerCity = customer.City;

                    LoggedUserOrCustomer.IsUser = false;
                    LoggedUserOrCustomer.IsCustomer = true;
                    var stockForm = new Stocks(
                        _productService,
                        _supplierService,
                        _categoryService,
                        _dbPosContext,
                        _imageService,
                        _bookingService,
                        _customerService, _userService);

                    stockForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/email or password for customer.");
                }
            }
        }
    }
}
