using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PointOfSale_1.Context;
using PointOfSale_1.Controls;
using PointOfSale_1.Models;
using PointOfSale_1.Services;
using PointOfSale_1.Services.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace PointOfSale_1
{
    public partial class Stocks : MaterialForm
    {
        private MaterialSkin.MaterialSkinManager materialSkinManager;
        private DbPosContext _dbPosContext;
        private IProductService _productService;
        private IBookingService _bookingService;
        private ISupplierService _supplierService;
        private ICategoryService _categoryService;
        private IImageService _imageService;
        private ICustomerService _customerService;
        private Models.Image uploadedImage = null;
        private Product currentProduct = null;
        private IUserService _userService;

        public Stocks(IProductService productService, ISupplierService supplierService, ICategoryService categoryService, DbPosContext dbPosContext, IImageService imageService, IBookingService bookingService, ICustomerService customerService, IUserService userService)
        {
            InitializeComponent();
            _productService = productService;
            _bookingService = bookingService;
            _supplierService = supplierService;
            _categoryService = categoryService;
            _imageService = imageService;
            _dbPosContext = dbPosContext;
            _customerService = customerService;
            _userService = userService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDb();
            if (!LoggedUserOrCustomer.IsLoggedIn())
            {
                Login login = new Login(_userService,
                    _customerService,
                    _productService,
                    _supplierService,
                    _categoryService,
                    _dbPosContext,
                    _imageService,
                    _bookingService);
                this.Hide();
                DialogResult dialogResult = login.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    this.Close();
                }

            }
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            setStatus();
            ReloadComboBoxes();
         
            this.bookingsDataGridView.Columns.Add("ProductNameColumn", "Product Name");
            this.bookingsDataGridView.Columns.Add("CustomerNameColumn", "Customer Name");
            this.bookingsDataGridView.Columns["ProductNameColumn"].DataPropertyName = "ProductName";
            this.bookingsDataGridView.Columns["CustomerNameColumn"].DataPropertyName = "CustomerName";
            this.bookingsDataGridView.Columns["ProductNameColumn"].ReadOnly = true;
            this.bookingsDataGridView.Columns["CustomerNameColumn"].ReadOnly = true;
            if (LoggedUserOrCustomer.IsUser) 
            {
                header1.UpdateUserLabel(LoggedUserOrCustomer.UserName);
            }
            else if (LoggedUserOrCustomer.IsCustomer)
            {
                header1.UpdateUserLabel(LoggedUserOrCustomer.CustomerName);
            }



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDb();
                if (tabControl.SelectedTab == ItemList)
                {
                    ReloadComboBoxes();
                    var products = _productService.GetAll();
                    PopulateProducts(products);

                }
                if (tabControl.SelectedTab == AddBooking || tabControl.SelectedTab == Bookings)
                {
                    
                    if (LoggedUserOrCustomer.IsUser)
                    {
                        bookingBindingSource.DataSource = _dbPosContext.Bookings.Local.ToBindingList();
                    }
                    if (LoggedUserOrCustomer.IsCustomer)
                    {
                        bookingBindingSource.DataSource = _dbPosContext.Bookings.Local.ToBindingList().Where(b => b.CustomerId == LoggedUserOrCustomer.CustomerId);
                    }


                    bookingsDataGridView.DataSource = bookingBindingSource;
                }
                if (LoggedUserOrCustomer.IsUser)
                {
                    if (tabControl.SelectedTab == AddItem)
                    {
                        ReloadComboBoxes();
                        this.currentProduct = null;
                    }
                    else if (tabControl.SelectedTab == AddCategory)
                    {
                        _dbPosContext.Categories.Load();
                        categoryBindingSource.DataSource = _dbPosContext.Categories.Local.ToBindingList();
                        dgvCategories.DataSource = categoryBindingSource;
                    }
                    if (tabControl.SelectedTab != AddItem)
                    {
                        ClearProductFields();
                        AddItem.Text = "Add Item";
                    }
                }
                else
                {
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadDb() 
        {
            _dbPosContext.Customers.Load();
            _dbPosContext.Products.Load();
            _dbPosContext.Bookings.Load();
        }

        private void ReloadComboBoxes()
        {
            SupplierInput.Items.Clear();
            CategoryInput.Items.Clear();
            SupplierSearchBox.Items.Clear();
            SupplierSearchBox.Items.Add("All");
            SupplierInput.Items.AddRange(_supplierService.GetAllSuppliers().Select(s => s.Name).ToArray());
            CategoryInput.Items.AddRange(_categoryService.GetAllCategories().Select(c => c.Name).ToArray());
            SupplierSearchBox.Items.AddRange(_supplierService.GetAllSuppliers().Select(s => s.Name).ToArray());

        }

        private List<Product> GetProducts()
        {
            return _productService.GetAll(NameSearchBox.Text, SupplierSearchBox.Text=="All"?"":SupplierSearchBox.Text, ExpirationFrom.Value, ExpirationTo.Value, PriceFrom.Text, PriceTo.Text);;
        }

        private void PopulateProducts(List<Product> products)
        {
            productsFlow.Controls.Clear();
            foreach (var product in products)
            {
                var control = new ProductControl();
                Image image = _imageService.GetImage(product.ImageId);
                int remainingQty = _bookingService.FindRemainingQuantityByProduct(product);
                string salesPrice = (product.DiscountRate > 0 && product.DiscountRate < 100)
                    ? $"{product.SalesPrice * (1 - product.DiscountRate / (decimal)100.0):0.00} ({product.DiscountRate:0.00}% SALE)"
                    : product.SalesPrice.ToString("0.00");
                control.SetValues(product.ItemBarcode, product.ItemName, product.Quantity, salesPrice, image, remainingQty);
                control.UserControlClicked += (sender, e) => NavigateToAddTab(product);
                productsFlow.Controls.Add(control);
            }
        }

        private void NavigateToAddTab(Product product)
        {
            if (LoggedUserOrCustomer.IsUser)
            {
                NavigateToAddItemTab(product);
            }
            else
            {
                NavigateToAddBookingTab(product);
            }
        }

        private void NavigateToAddItemTab(Product product)
        {
            // don't change the order - must be first
            tabControl.SelectedTab = AddItem;
            this.currentProduct = product;
            tabControl.TabPages[1].Text = "Edit Item";

            ReloadComboBoxes();
            BarcodeInput.Text = product.ItemBarcode;
            NameInput.Text = product.ItemName;
            DescriptionInput.Text = product.Description;
            QuantityInput.Text = product.Quantity.ToString();
            PurchasePriceInput.Text = product.PurchasePrice.ToString();
            SalesPriceInput.Text = product.SalesPrice.ToString();
            DiscountRateInput.Text = product.DiscountRate.ToString();
            CategoryInput.SelectedItem = product.Category.Name;
            SupplierInput.SelectedItem = product.Supplier.Name;
            ExpireDate.Text = product.ExpireDate.ToString("dd/MM/yyyy");
            ManufacturingDateInput.Text = product.ManufacturingDate.ToString("dd/MM/yyyy");
            WeightInput.Text = product.Weight.ToString();
            pictureBox.Image = _imageService.GetImage(product.ImageId);
        }

        private void QuantityInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d+$"))
                {
                    MessageBox.Show("Please enter a valid quantity (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Event handler for WeightInput
        private void WeightInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d+(\.\d+)?$"))
                {
                    MessageBox.Show("Please enter a valid weight (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Event handler for PurchasePriceInput
        private void PurchasePriceInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d+(\.\d+)?$"))
                {
                    MessageBox.Show("Please enter a valid purchase price (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Event handler for SalesPriceInput
        private void SalesPriceInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d+(\.\d+)?$"))
                {
                    MessageBox.Show("Please enter a valid sales price (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void DiscountRateInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^(?:100(?:\.0+)?|\d{1,2}(?:\.\d+)?)$"))
                {
                    MessageBox.Show("Please enter a valid discount rate between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    double discountRate = double.Parse(textBox.Text);
                    if (discountRate < 0 || discountRate > 100)
                    {
                        MessageBox.Show("Please enter a discount rate between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }


        private void ExpireDate_Validating(object sender, CancelEventArgs e)
        {
            BaseMaskedTextBox textBox = sender as BaseMaskedTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    MessageBox.Show("Please enter a valid expiration date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    DateTime expireDate;
                    if (DateTime.TryParseExact(textBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out expireDate))
                    {
                        DateTime currentDate = DateTime.Today;
                        if (expireDate <= currentDate)
                        {
                            MessageBox.Show("Expiration date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                        else
                        {
                            DateTime manufacturingDate;
                            if (DateTime.TryParseExact(ManufacturingDateInput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out manufacturingDate))
                            {
                                if (expireDate <= manufacturingDate)
                                {
                                    MessageBox.Show("Expiration date must be after manufacturing date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    e.Cancel = true;
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid expiration date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ManufacturingDateInput_Validating(object sender, CancelEventArgs e)
        {
            BaseMaskedTextBox textBox = sender as BaseMaskedTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    MessageBox.Show("Please enter a valid manufacturing date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    DateTime manufacturingDate;
                    if (DateTime.TryParseExact(textBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out manufacturingDate))
                    {
                        DateTime currentDate = DateTime.Today;
                        if (manufacturingDate > currentDate)
                        {
                            MessageBox.Show("Manufacturing date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                        else
                        {
                            DateTime expireDate;
                            if (DateTime.TryParseExact(ExpireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out expireDate))
                            {
                                if (manufacturingDate >= expireDate)
                                {
                                    MessageBox.Show("Manufacturing date must be before expiration date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    e.Cancel = true;
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid manufacturing date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ItemBarcodeInput_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!Regex.IsMatch(textBox.Text, @"^[A-Za-z0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid item barcode.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void SubmitButtonClickAddItem(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = null;
                if (this.currentProduct == null)
                {
                    newProduct = new Product
                    {   
                    };
                }
                else
                {
                    newProduct = _productService.GetProductById(this.currentProduct.Id);
                    deleteButton.Enabled = true;
                    deleteButton.Visible = true;
                }
                newProduct.ItemBarcode = BarcodeInput.Text;
                newProduct.ItemName = NameInput.Text;
                newProduct.Description = DescriptionInput.Text;
                newProduct.Image = uploadedImage;

                if (!string.IsNullOrEmpty(QuantityInput.Text))
                {
                    if (!Regex.IsMatch(QuantityInput.Text, @"^[A-Za-z0-9]+$"))
                    {
                        MessageBox.Show("Please enter a valid item barcode.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    newProduct.Quantity = int.Parse(QuantityInput.Text);
                }

                if (!string.IsNullOrEmpty(QuantityInput.Text))
                {
                    if (!Regex.IsMatch(QuantityInput.Text, @"^\d+$"))
                    {
                        MessageBox.Show("Please enter a valid quantity (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.Quantity = int.Parse(QuantityInput.Text);
                }

                if (!string.IsNullOrEmpty(WeightInput.Text))
                {
                    if (!Regex.IsMatch(WeightInput.Text, @"^\d+(\.\d+)?$"))
                    {
                        MessageBox.Show("Please enter a valid weight (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.Weight = decimal.Parse(WeightInput.Text);
                }

                // Validate PurchasePriceInput (numeric field)
                if (!string.IsNullOrEmpty(PurchasePriceInput.Text))
                {
                    if (!Regex.IsMatch(PurchasePriceInput.Text, @"^\d+(\.\d+)?$"))
                    {
                        MessageBox.Show("Please enter a valid purchase price (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.PurchasePrice = decimal.Parse(PurchasePriceInput.Text);
                }

                // Validate SalesPriceInput (numeric field)
                if (!string.IsNullOrEmpty(SalesPriceInput.Text))
                {
                    if (!Regex.IsMatch(SalesPriceInput.Text, @"^\d+(\.\d+)?$"))
                    {
                        MessageBox.Show("Please enter a valid sales price (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.SalesPrice = decimal.Parse(SalesPriceInput.Text);
                }

                // Validate DiscountRateInput (numeric field)
                if (!string.IsNullOrEmpty(DiscountRateInput.Text))
                {
                    if (!Regex.IsMatch(DiscountRateInput.Text, @"^\d+(\.\d+)?$"))
                    {
                        MessageBox.Show("Please enter a valid discount rate (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.DiscountRate = decimal.Parse(DiscountRateInput.Text);
                }
                // Validate ExpireDate (date field)
                if (!string.IsNullOrEmpty(ExpireDate.Text))
                {
                    if (!Regex.IsMatch(ExpireDate.Text, @"^\d{2}/\d{2}/\d{4}$"))
                    {
                        MessageBox.Show("Please enter a valid expiration date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.ExpireDate = DateTime.ParseExact(ExpireDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                // Validate ManufacturingDateInput (date field)
                if (!string.IsNullOrEmpty(ManufacturingDateInput.Text))
                {
                    if (!Regex.IsMatch(ManufacturingDateInput.Text, @"^\d{2}/\d{2}/\d{4}$"))
                    {
                        MessageBox.Show("Please enter a valid manufacturing date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newProduct.ManufacturingDate = DateTime.ParseExact(ManufacturingDateInput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (!string.IsNullOrEmpty(SalesPriceInput.Text))
                {
                    newProduct.SalesPrice = decimal.Parse(SalesPriceInput.Text);
                }
                if (!string.IsNullOrEmpty(DiscountRateInput.Text))
                {
                    newProduct.DiscountRate = decimal.Parse(DiscountRateInput.Text);
                }
                if (CategoryInput.SelectedItem != null)
                {
                    newProduct.Category = _categoryService.GetByName((string)CategoryInput.SelectedItem);
                }
                if (SupplierInput.SelectedItem != null)
                {
                    newProduct.Supplier = _supplierService.GetByName((string)SupplierInput.SelectedItem);
                }
                if (newProduct.Id == 0)
                {
                    Product product = _productService.AddProduct(newProduct);
                    if (product != null)
                    {
                        ClearProductFields();
                    }
                }
                else
                {
                    _productService.SaveChanges();
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ClearProductFields()
        {
            BarcodeInput.Text = "";
            NameInput.Text = "";
            DescriptionInput.Text = "";
            QuantityInput.Text = "";
            PurchasePriceInput.Text = "";
            SalesPriceInput.Text = "";
            DiscountRateInput.Text = "";
            CategoryInput.SelectedItem = "";
            SupplierInput.SelectedItem = "";
            ExpireDate.Text = "";
            ManufacturingDateInput.Text = "";
            WeightInput.Text = "";
            RemoveImageFromBox();
        }

        private void categorySaveButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == AddCategory)
            {
                try
                {
                    if (validateCurrent())
                    {
                        saveChanges();
                        reloadCategory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void dgvCategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && dgvCategories.Columns[e.ColumnIndex].Name == "ColDelete")
                {
                    deleteCurrentCategory();
                }
            }
            catch (Exception)
            {
            }
        }

        private void reloadCategory()
        {
            categoryBindingSource.DataSource = _dbPosContext.Categories.Local.ToBindingList();
        }

        private void saveChanges()
        {
            _dbPosContext.SaveChanges();
        }

        private void deleteCurrentCategory()
        {
            var cat = (Category)categoryBindingSource.Current;
            _dbPosContext.Categories.Local.Remove(cat);
            _dbPosContext.SaveChanges();
            categoryBindingSource.Position = 0;
            setStatus();
        }

        private bool validateCurrent()
        {
            var category = (Category)categoryBindingSource.Current;
            if (category != null)
            {
                var validationContext = new ValidationContext(category);
                var validationResults = new List<ValidationResult>();
                if (!Validator.TryValidateObject(category, validationContext, validationResults, true))
                {
                    string errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                return true;
            }
            return true;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var cat = new Category();
            _dbPosContext.Categories.Local.Add(cat);
            int idx = categoryBindingSource.IndexOf(cat);
            categoryBindingSource.Position = idx;
        }

        private void dgvCategories_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string colName = dgvCategories.Columns[e.ColumnIndex].Name;
            if (colName == "nameDataGridViewTextBoxColumn")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("Please enter Category name.");
                    e.Cancel = true;
                }
            }
        }

        private void bookingsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (bookingsDataGridView.Columns[e.ColumnIndex].HeaderText == "Description")
            {
                string value = e.FormattedValue.ToString().Trim();
                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Booking description is required.");
                    e.Cancel = true;
                }
            }
            else if (bookingsDataGridView.Columns[e.ColumnIndex].HeaderText == "Quantity")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int quantity) || quantity < 1)
                {
                    MessageBox.Show("Quantity must be a positive integer.");
                    e.Cancel = true;
                }
            }
            else if (bookingsDataGridView.Columns[e.ColumnIndex].HeaderText == "BookingDate")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {

                    DateTime bookingDate;
                    if (!DateTime.TryParse(e.FormattedValue.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out bookingDate))
                    {
                        MessageBox.Show("Please enter a valid booking date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }

                    if (bookingDate.Date <= DateTime.Today)
                    {
                        MessageBox.Show("Booking date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var cat = (Category)categoryBindingSource.Current;
            _dbPosContext.Categories.Local.Remove(cat);
            categoryBindingSource.Position = 0;
            saveChanges();
            setStatus();
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void categoryBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setStatus();
        }

        private void setStatus()
        {
            if (LoggedUserOrCustomer.IsUser)
            {
                if (tabControl.SelectedTab == ItemAlerts)
                {

                }
                else if (tabControl.SelectedTab == AddBooking)
                {
                    textBoxCattegoryDescr.Enabled = textBoxCattegoryName.Enabled = categoryBindingSource.Current != null;
                }
                
                if (!tabControl.TabPages.Contains(ItemList))
                    tabControl.TabPages.Add(ItemList);
                if (!tabControl.TabPages.Contains(AddItem))
                    tabControl.TabPages.Add(AddItem);
                if (!tabControl.TabPages.Contains(AddCategory))
                    tabControl.TabPages.Add(AddCategory);

                if (!tabControl.TabPages.Contains(ItemAlerts))
                    tabControl.TabPages.Add(ItemAlerts);
                if (tabControl.TabPages.Contains(AddBooking))
                    tabControl.TabPages.Remove(AddBooking);
                if (!tabControl.TabPages.Contains(Bookings))
                    tabControl.TabPages.Add(Bookings);
            }
            else
            {

                if (!tabControl.TabPages.Contains(ItemList))
                    tabControl.TabPages.Add(ItemList);
                if (tabControl.TabPages.Contains(AddItem))
                    tabControl.TabPages.Remove(AddItem);
                if (tabControl.TabPages.Contains(AddCategory))
                    tabControl.TabPages.Remove(AddCategory);
                if (tabControl.TabPages.Contains(ItemAlerts))
                    tabControl.TabPages.Remove(ItemAlerts);

                if (!tabControl.TabPages.Contains(AddBooking))
                    tabControl.TabPages.Add(AddBooking);
                if (!tabControl.TabPages.Contains(Bookings))
                    tabControl.TabPages.Add(Bookings);
            }


        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string contentType = Path.GetExtension(openFileDialog.FileName);

                Models.Image image = _imageService.SaveOrUpdateImage(openFileDialog.FileName, fileName, contentType);
                uploadedImage = image;
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                btnUpload.Enabled = false;
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveImage();

            btnUpload.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void RemoveImage()
        {
            if (pictureBox.Image != null)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                _imageService.RemoveImage(fileName);
                pictureBox.Image = null;
                uploadedImage = null;
            }
        }


        private void RemoveImageFromBox()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnUpload_Click(sender, e);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PopulateProducts(GetProducts());
        }

        #region Add Booking
        private void NavigateToAddBookingTab(Product product)
        {
            tabControl.SelectedTab = AddBooking;

            ReloadComboBoxes();

            itemBookingInput.Text = product.ItemName;
            itemBookingInput.Tag = product;

            if (product != null && product.Image != null)
            {
                btnUpload.Enabled = false;
                btnRemove.Enabled = true;
            }
            else
            {
                btnUpload.Enabled = true;
                btnRemove.Enabled = false;
            }
        }

        private void submitButtonBooking_Click(object sender, EventArgs e)
        {
            try
            {
                Product productFound = _productService.GetProductByName(itemBookingInput.Text);
                if (productFound == null)
                {
                    MessageBox.Show("Product not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                Customer customerCurrent = _customerService.GetCustomerById(LoggedUserOrCustomer.CustomerId);
                if (customerCurrent == null)
                {
                    MessageBox.Show("Customer not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Booking newBooking = new Booking
                {
                    CustomerId = LoggedUserOrCustomer.CustomerId,
                    Description = DescriptionInput.Text,
                };
                newBooking.Product = productFound;
                newBooking.ProductId = productFound.Id;
                newBooking.Customer = customerCurrent;

                if (!string.IsNullOrEmpty(quantityBookingInput.Text))
                {
                    if (!Regex.IsMatch(quantityBookingInput.Text, @"^\d+$"))
                    {
                        MessageBox.Show("Please enter a valid quantity (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int remainingQuantity = _bookingService.FindRemainingQuantityByProduct(productFound);
                    var quantityToBeAdded = int.Parse(quantityBookingInput.Text);
                    if (quantityToBeAdded <= remainingQuantity)
                    {
                        newBooking.Quantity = quantityToBeAdded;
                    }
                    else 
                    {
                        MessageBox.Show($"The available quantity for {productFound.ItemName} is {remainingQuantity}. You tried adding {quantityBookingInput}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                if (!string.IsNullOrEmpty(dateBookingInput.Text))
                {
                    DateTime bookingDate;
                    if (!DateTime.TryParseExact(dateBookingInput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out bookingDate))
                    {
                        MessageBox.Show("Please enter a valid booking date (DD/MM/YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (bookingDate.Date <= DateTime.Today)
                    {
                        MessageBox.Show("Booking date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (bookingDate.Date >= productFound.ExpireDate)
                    {
                        MessageBox.Show("Booking date must not be after the products are expired.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    newBooking.BookingDate = bookingDate;
                }


                newBooking.Description = descriptionBookingInput.Text;

                newBooking = _bookingService.AddBooking(newBooking);
                if (newBooking != null)
                {
                    ClearBookingFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ClearBookingFields()
        {
            descriptionBookingInput.Text = "";
            quantityBookingInput.Text = "";
            dateBookingInput.Text = "";
        }



        #endregion

        private void quantityBookingInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityBookingLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _bookingService.SaveChanges();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (LoggedUserOrCustomer.IsCustomer)
            {
                _customerService.LogoutCustomer();
            }
            else if (LoggedUserOrCustomer.IsUser) 
            {
                _userService.LogoutUser();
            }
            if (!LoggedUserOrCustomer.IsLoggedIn())
            {
                Login login = new Login(_userService,
                    _customerService,
                    _productService,
                    _supplierService,
                    _categoryService,
                    _dbPosContext,
                    _imageService,
                    _bookingService);
                this.Hide();
                DialogResult dialogResult = login.ShowDialog();
                if (dialogResult != DialogResult.OK) 
                {
                    this.Close();
                }

            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            this._dbPosContext.Products.Remove(currentProduct);
            this._dbPosContext.SaveChanges();
            ClearProductFields();
            this.deleteButton.Enabled = false;
        }
    }
}
