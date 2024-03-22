using System.Windows.Forms;

namespace PointOfSale_1
{
    partial class Stocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.AddItem = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemBarcodeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BarcodeInput = new MaterialSkin.Controls.MaterialTextBox();
            this.ItemNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.QuantityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.QuantityInput = new MaterialSkin.Controls.MaterialTextBox();
            this.PurchasePriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PurchasePriceInput = new MaterialSkin.Controls.MaterialTextBox();
            this.SalesPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SalesPriceInput = new MaterialSkin.Controls.MaterialTextBox();
            this.DiscountRateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DiscountRateInput = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CategoryInput = new MaterialSkin.Controls.MaterialComboBox();
            this.SupplierLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SupplierInput = new MaterialSkin.Controls.MaterialComboBox();
            this.ExpireDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ExpireDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ManufacturingDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ManufacturingDateInput = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.WeightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WeightInput = new MaterialSkin.Controls.MaterialTextBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SubmitButtonAddItem = new MaterialSkin.Controls.MaterialButton();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ItemList = new System.Windows.Forms.TabPage();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.PriceBetweenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PriceTo = new System.Windows.Forms.TextBox();
            this.PriceFrom = new System.Windows.Forms.TextBox();
            this.ExpirationDateLabelBetween = new MaterialSkin.Controls.MaterialLabel();
            this.ExpirationTo = new System.Windows.Forms.DateTimePicker();
            this.ExpirationFrom = new System.Windows.Forms.DateTimePicker();
            this.SupplierSearchBox = new MaterialSkin.Controls.MaterialComboBox();
            this.NameSearchBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.productsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.AddCategory = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCattegoryName = new MaterialSkin.Controls.MaterialTextBox();
            this.categoryDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCattegoryDescr = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.categorySaveButton = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddNew = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemAlerts = new System.Windows.Forms.TabPage();
            this.AddBooking = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookingItemLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemBookingInput = new MaterialSkin.Controls.MaterialTextBox();
            this.descriptionBookngLabel = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionBookingInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.quantityBookingInput = new MaterialSkin.Controls.MaterialTextBox();
            this.dateBookingLable = new MaterialSkin.Controls.MaterialLabel();
            this.dateBookingInput = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.submitButtonBooking = new MaterialSkin.Controls.MaterialButton();
            this.quantityBookingLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.Bookings = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logout = new MaterialSkin.Controls.MaterialLabel();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.header1 = new PointOfSale_1.Controls.Header();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ItemList.SuspendLayout();
            this.AddCategory.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.AddBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.Bookings.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.Controls.Add(this.panel1);
            this.AddItem.Location = new System.Drawing.Point(4, 28);
            this.AddItem.Name = "AddItem";
            this.AddItem.Padding = new System.Windows.Forms.Padding(3);
            this.AddItem.Size = new System.Drawing.Size(1235, 864);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(40, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 800);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 800);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ItemBarcodeLabel);
            this.flowLayoutPanel1.Controls.Add(this.BarcodeInput);
            this.flowLayoutPanel1.Controls.Add(this.ItemNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.NameInput);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionLabel);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionInput);
            this.flowLayoutPanel1.Controls.Add(this.QuantityLabel);
            this.flowLayoutPanel1.Controls.Add(this.QuantityInput);
            this.flowLayoutPanel1.Controls.Add(this.PurchasePriceLabel);
            this.flowLayoutPanel1.Controls.Add(this.PurchasePriceInput);
            this.flowLayoutPanel1.Controls.Add(this.SalesPriceLabel);
            this.flowLayoutPanel1.Controls.Add(this.SalesPriceInput);
            this.flowLayoutPanel1.Controls.Add(this.DiscountRateLabel);
            this.flowLayoutPanel1.Controls.Add(this.DiscountRateInput);
            this.flowLayoutPanel1.Controls.Add(this.deleteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 800);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ItemBarcodeLabel
            // 
            this.ItemBarcodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemBarcodeLabel.Depth = 0;
            this.ItemBarcodeLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ItemBarcodeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ItemBarcodeLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemBarcodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemBarcodeLabel.Name = "ItemBarcodeLabel";
            this.ItemBarcodeLabel.Size = new System.Drawing.Size(395, 23);
            this.ItemBarcodeLabel.TabIndex = 18;
            this.ItemBarcodeLabel.Text = "Item Barcode: *";
            // 
            // BarcodeInput
            // 
            this.BarcodeInput.AnimateReadOnly = false;
            this.BarcodeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BarcodeInput.Depth = 0;
            this.BarcodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BarcodeInput.LeadingIcon = null;
            this.BarcodeInput.Location = new System.Drawing.Point(3, 33);
            this.BarcodeInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BarcodeInput.MaxLength = 50;
            this.BarcodeInput.MouseState = MaterialSkin.MouseState.OUT;
            this.BarcodeInput.Multiline = false;
            this.BarcodeInput.Name = "BarcodeInput";
            this.BarcodeInput.Size = new System.Drawing.Size(391, 50);
            this.BarcodeInput.TabIndex = 17;
            this.BarcodeInput.Text = "";
            this.BarcodeInput.TrailingIcon = null;
            this.BarcodeInput.Validating += new System.ComponentModel.CancelEventHandler(this.ItemBarcodeInput_Validating);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameLabel.Depth = 0;
            this.ItemNameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ItemNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 93);
            this.ItemNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(395, 23);
            this.ItemNameLabel.TabIndex = 16;
            this.ItemNameLabel.Text = "Item Name: *";
            // 
            // NameInput
            // 
            this.NameInput.AnimateReadOnly = false;
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameInput.Depth = 0;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameInput.LeadingIcon = null;
            this.NameInput.Location = new System.Drawing.Point(3, 126);
            this.NameInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.NameInput.MaxLength = 50;
            this.NameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.NameInput.Multiline = false;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(391, 50);
            this.NameInput.TabIndex = 19;
            this.NameInput.Text = "";
            this.NameInput.TrailingIcon = null;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 186);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(395, 23);
            this.DescriptionLabel.TabIndex = 21;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.AnimateReadOnly = false;
            this.DescriptionInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DescriptionInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionInput.Depth = 0;
            this.DescriptionInput.HideSelection = true;
            this.DescriptionInput.Location = new System.Drawing.Point(3, 222);
            this.DescriptionInput.MaxLength = 32767;
            this.DescriptionInput.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.PasswordChar = '\0';
            this.DescriptionInput.ReadOnly = false;
            this.DescriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionInput.SelectedText = "";
            this.DescriptionInput.SelectionLength = 0;
            this.DescriptionInput.SelectionStart = 0;
            this.DescriptionInput.ShortcutsEnabled = true;
            this.DescriptionInput.Size = new System.Drawing.Size(395, 139);
            this.DescriptionInput.TabIndex = 20;
            this.DescriptionInput.TabStop = false;
            this.DescriptionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionInput.UseSystemPasswordChar = false;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityLabel.Depth = 0;
            this.QuantityLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.QuantityLabel.Location = new System.Drawing.Point(3, 364);
            this.QuantityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(395, 23);
            this.QuantityLabel.TabIndex = 22;
            this.QuantityLabel.Text = "Quantity (Qty): *";
            // 
            // QuantityInput
            // 
            this.QuantityInput.AnimateReadOnly = false;
            this.QuantityInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityInput.Depth = 0;
            this.QuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityInput.LeadingIcon = null;
            this.QuantityInput.Location = new System.Drawing.Point(3, 397);
            this.QuantityInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.QuantityInput.MaxLength = 50;
            this.QuantityInput.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityInput.Multiline = false;
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(391, 50);
            this.QuantityInput.TabIndex = 31;
            this.QuantityInput.Text = "";
            this.QuantityInput.TrailingIcon = null;
            this.QuantityInput.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityInput_Validating);
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchasePriceLabel.Depth = 0;
            this.PurchasePriceLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PurchasePriceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.PurchasePriceLabel.Location = new System.Drawing.Point(3, 457);
            this.PurchasePriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(395, 23);
            this.PurchasePriceLabel.TabIndex = 24;
            this.PurchasePriceLabel.Text = "Purchase Price: *";
            // 
            // PurchasePriceInput
            // 
            this.PurchasePriceInput.AnimateReadOnly = false;
            this.PurchasePriceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchasePriceInput.Depth = 0;
            this.PurchasePriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PurchasePriceInput.LeadingIcon = null;
            this.PurchasePriceInput.Location = new System.Drawing.Point(3, 490);
            this.PurchasePriceInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.PurchasePriceInput.MaxLength = 50;
            this.PurchasePriceInput.MouseState = MaterialSkin.MouseState.OUT;
            this.PurchasePriceInput.Multiline = false;
            this.PurchasePriceInput.Name = "PurchasePriceInput";
            this.PurchasePriceInput.Size = new System.Drawing.Size(391, 50);
            this.PurchasePriceInput.TabIndex = 32;
            this.PurchasePriceInput.Text = "";
            this.PurchasePriceInput.TrailingIcon = null;
            this.PurchasePriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.PurchasePriceInput_Validating);
            // 
            // SalesPriceLabel
            // 
            this.SalesPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesPriceLabel.Depth = 0;
            this.SalesPriceLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SalesPriceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.SalesPriceLabel.Location = new System.Drawing.Point(3, 550);
            this.SalesPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalesPriceLabel.Name = "SalesPriceLabel";
            this.SalesPriceLabel.Size = new System.Drawing.Size(395, 23);
            this.SalesPriceLabel.TabIndex = 26;
            this.SalesPriceLabel.Text = "Sales Price: *";
            // 
            // SalesPriceInput
            // 
            this.SalesPriceInput.AnimateReadOnly = false;
            this.SalesPriceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesPriceInput.Depth = 0;
            this.SalesPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalesPriceInput.LeadingIcon = null;
            this.SalesPriceInput.Location = new System.Drawing.Point(3, 583);
            this.SalesPriceInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.SalesPriceInput.MaxLength = 50;
            this.SalesPriceInput.MouseState = MaterialSkin.MouseState.OUT;
            this.SalesPriceInput.Multiline = false;
            this.SalesPriceInput.Name = "SalesPriceInput";
            this.SalesPriceInput.Size = new System.Drawing.Size(391, 50);
            this.SalesPriceInput.TabIndex = 33;
            this.SalesPriceInput.Text = "";
            this.SalesPriceInput.TrailingIcon = null;
            this.SalesPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.SalesPriceInput_Validating);
            // 
            // DiscountRateLabel
            // 
            this.DiscountRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountRateLabel.Depth = 0;
            this.DiscountRateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DiscountRateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DiscountRateLabel.Location = new System.Drawing.Point(3, 643);
            this.DiscountRateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscountRateLabel.Name = "DiscountRateLabel";
            this.DiscountRateLabel.Size = new System.Drawing.Size(395, 23);
            this.DiscountRateLabel.TabIndex = 28;
            this.DiscountRateLabel.Text = "Discount Rate:";
            // 
            // DiscountRateInput
            // 
            this.DiscountRateInput.AnimateReadOnly = false;
            this.DiscountRateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountRateInput.Depth = 0;
            this.DiscountRateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DiscountRateInput.Hint = "0-100%";
            this.DiscountRateInput.LeadingIcon = null;
            this.DiscountRateInput.Location = new System.Drawing.Point(3, 676);
            this.DiscountRateInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.DiscountRateInput.MaxLength = 50;
            this.DiscountRateInput.MouseState = MaterialSkin.MouseState.OUT;
            this.DiscountRateInput.Multiline = false;
            this.DiscountRateInput.Name = "DiscountRateInput";
            this.DiscountRateInput.Size = new System.Drawing.Size(391, 50);
            this.DiscountRateInput.TabIndex = 34;
            this.DiscountRateInput.Text = "";
            this.DiscountRateInput.TrailingIcon = null;
            this.DiscountRateInput.Validating += new System.ComponentModel.CancelEventHandler(this.DiscountRateInput_Validating);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.Enabled = false;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(125, 740);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(125, 4, 4, 4);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(158, 50);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = true;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CategoryLabel);
            this.flowLayoutPanel2.Controls.Add(this.CategoryInput);
            this.flowLayoutPanel2.Controls.Add(this.SupplierLabel);
            this.flowLayoutPanel2.Controls.Add(this.SupplierInput);
            this.flowLayoutPanel2.Controls.Add(this.ExpireDateLabel);
            this.flowLayoutPanel2.Controls.Add(this.ExpireDate);
            this.flowLayoutPanel2.Controls.Add(this.ManufacturingDateLabel);
            this.flowLayoutPanel2.Controls.Add(this.ManufacturingDateInput);
            this.flowLayoutPanel2.Controls.Add(this.WeightLabel);
            this.flowLayoutPanel2.Controls.Add(this.WeightInput);
            this.flowLayoutPanel2.Controls.Add(this.ImagePanel);
            this.flowLayoutPanel2.Controls.Add(this.SubmitButtonAddItem);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(549, 800);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.Depth = 0;
            this.CategoryLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CategoryLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 0);
            this.CategoryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(395, 23);
            this.CategoryLabel.TabIndex = 27;
            this.CategoryLabel.Text = "Category: *";
            // 
            // CategoryInput
            // 
            this.CategoryInput.AutoResize = false;
            this.CategoryInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoryInput.Depth = 0;
            this.CategoryInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CategoryInput.DropDownHeight = 174;
            this.CategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryInput.DropDownWidth = 121;
            this.CategoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CategoryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoryInput.FormattingEnabled = true;
            this.CategoryInput.IntegralHeight = false;
            this.CategoryInput.ItemHeight = 43;
            this.CategoryInput.Location = new System.Drawing.Point(3, 26);
            this.CategoryInput.MaxDropDownItems = 4;
            this.CategoryInput.MouseState = MaterialSkin.MouseState.OUT;
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(409, 49);
            this.CategoryInput.StartIndex = 0;
            this.CategoryInput.TabIndex = 16;
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierLabel.Depth = 0;
            this.SupplierLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.SupplierLabel.Location = new System.Drawing.Point(3, 78);
            this.SupplierLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(395, 23);
            this.SupplierLabel.TabIndex = 29;
            this.SupplierLabel.Text = "Supplier: *";
            // 
            // SupplierInput
            // 
            this.SupplierInput.AutoResize = false;
            this.SupplierInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SupplierInput.Depth = 0;
            this.SupplierInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SupplierInput.DropDownHeight = 174;
            this.SupplierInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierInput.DropDownWidth = 121;
            this.SupplierInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SupplierInput.FormattingEnabled = true;
            this.SupplierInput.IntegralHeight = false;
            this.SupplierInput.ItemHeight = 43;
            this.SupplierInput.Location = new System.Drawing.Point(3, 104);
            this.SupplierInput.MaxDropDownItems = 4;
            this.SupplierInput.MouseState = MaterialSkin.MouseState.OUT;
            this.SupplierInput.Name = "SupplierInput";
            this.SupplierInput.Size = new System.Drawing.Size(409, 49);
            this.SupplierInput.StartIndex = 0;
            this.SupplierInput.TabIndex = 28;
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpireDateLabel.Depth = 0;
            this.ExpireDateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ExpireDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ExpireDateLabel.Location = new System.Drawing.Point(3, 156);
            this.ExpireDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(395, 23);
            this.ExpireDateLabel.TabIndex = 30;
            this.ExpireDateLabel.Text = "Expire Date: *";
            // 
            // ExpireDate
            // 
            this.ExpireDate.AllowPromptAsInput = true;
            this.ExpireDate.AnimateReadOnly = false;
            this.ExpireDate.AsciiOnly = false;
            this.ExpireDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExpireDate.BeepOnError = false;
            this.ExpireDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ExpireDate.Depth = 0;
            this.ExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ExpireDate.HidePromptOnLeave = false;
            this.ExpireDate.HideSelection = true;
            this.ExpireDate.Hint = "DD/MM/YYYY";
            this.ExpireDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ExpireDate.LeadingIcon = null;
            this.ExpireDate.Location = new System.Drawing.Point(3, 182);
            this.ExpireDate.Mask = "00/00/0000";
            this.ExpireDate.MaxLength = 32767;
            this.ExpireDate.MouseState = MaterialSkin.MouseState.OUT;
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.PasswordChar = '\0';
            this.ExpireDate.PrefixSuffixText = null;
            this.ExpireDate.PromptChar = '_';
            this.ExpireDate.ReadOnly = false;
            this.ExpireDate.RejectInputOnFirstFailure = false;
            this.ExpireDate.ResetOnPrompt = true;
            this.ExpireDate.ResetOnSpace = true;
            this.ExpireDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpireDate.SelectedText = "";
            this.ExpireDate.SelectionLength = 0;
            this.ExpireDate.SelectionStart = 0;
            this.ExpireDate.ShortcutsEnabled = true;
            this.ExpireDate.Size = new System.Drawing.Size(409, 48);
            this.ExpireDate.SkipLiterals = true;
            this.ExpireDate.TabIndex = 31;
            this.ExpireDate.TabStop = false;
            this.ExpireDate.Text = "  /  /";
            this.ExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExpireDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ExpireDate.TrailingIcon = null;
            this.ExpireDate.UseSystemPasswordChar = false;
            this.ExpireDate.ValidatingType = null;
            this.ExpireDate.Validating += new System.ComponentModel.CancelEventHandler(this.ExpireDate_Validating);
            // 
            // ManufacturingDateLabel
            // 
            this.ManufacturingDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturingDateLabel.Depth = 0;
            this.ManufacturingDateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ManufacturingDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ManufacturingDateLabel.Location = new System.Drawing.Point(3, 233);
            this.ManufacturingDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManufacturingDateLabel.Name = "ManufacturingDateLabel";
            this.ManufacturingDateLabel.Size = new System.Drawing.Size(395, 23);
            this.ManufacturingDateLabel.TabIndex = 32;
            this.ManufacturingDateLabel.Text = "Manufacturing Date: *";
            // 
            // ManufacturingDateInput
            // 
            this.ManufacturingDateInput.AllowPromptAsInput = true;
            this.ManufacturingDateInput.AnimateReadOnly = false;
            this.ManufacturingDateInput.AsciiOnly = false;
            this.ManufacturingDateInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManufacturingDateInput.BeepOnError = false;
            this.ManufacturingDateInput.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ManufacturingDateInput.Depth = 0;
            this.ManufacturingDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ManufacturingDateInput.HidePromptOnLeave = false;
            this.ManufacturingDateInput.HideSelection = true;
            this.ManufacturingDateInput.Hint = "DD/MM/YYYY";
            this.ManufacturingDateInput.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ManufacturingDateInput.LeadingIcon = null;
            this.ManufacturingDateInput.Location = new System.Drawing.Point(3, 259);
            this.ManufacturingDateInput.Mask = "00/00/0000";
            this.ManufacturingDateInput.MaxLength = 32767;
            this.ManufacturingDateInput.MouseState = MaterialSkin.MouseState.OUT;
            this.ManufacturingDateInput.Name = "ManufacturingDateInput";
            this.ManufacturingDateInput.PasswordChar = '\0';
            this.ManufacturingDateInput.PrefixSuffixText = null;
            this.ManufacturingDateInput.PromptChar = '_';
            this.ManufacturingDateInput.ReadOnly = false;
            this.ManufacturingDateInput.RejectInputOnFirstFailure = false;
            this.ManufacturingDateInput.ResetOnPrompt = true;
            this.ManufacturingDateInput.ResetOnSpace = true;
            this.ManufacturingDateInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManufacturingDateInput.SelectedText = "";
            this.ManufacturingDateInput.SelectionLength = 0;
            this.ManufacturingDateInput.SelectionStart = 0;
            this.ManufacturingDateInput.ShortcutsEnabled = true;
            this.ManufacturingDateInput.Size = new System.Drawing.Size(406, 48);
            this.ManufacturingDateInput.SkipLiterals = true;
            this.ManufacturingDateInput.TabIndex = 33;
            this.ManufacturingDateInput.TabStop = false;
            this.ManufacturingDateInput.Text = "  /  /";
            this.ManufacturingDateInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ManufacturingDateInput.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ManufacturingDateInput.TrailingIcon = null;
            this.ManufacturingDateInput.UseSystemPasswordChar = false;
            this.ManufacturingDateInput.ValidatingType = null;
            this.ManufacturingDateInput.Validating += new System.ComponentModel.CancelEventHandler(this.ManufacturingDateInput_Validating);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.Depth = 0;
            this.WeightLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WeightLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.WeightLabel.Location = new System.Drawing.Point(3, 310);
            this.WeightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(395, 23);
            this.WeightLabel.TabIndex = 30;
            this.WeightLabel.Text = "Weight:";
            // 
            // WeightInput
            // 
            this.WeightInput.AnimateReadOnly = false;
            this.WeightInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightInput.Depth = 0;
            this.WeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WeightInput.LeadingIcon = null;
            this.WeightInput.Location = new System.Drawing.Point(3, 343);
            this.WeightInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.WeightInput.MaxLength = 50;
            this.WeightInput.MouseState = MaterialSkin.MouseState.OUT;
            this.WeightInput.Multiline = false;
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(391, 50);
            this.WeightInput.TabIndex = 36;
            this.WeightInput.Text = "";
            this.WeightInput.TrailingIcon = null;
            this.WeightInput.Validating += new System.ComponentModel.CancelEventHandler(this.WeightInput_Validating);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.pictureBox);
            this.ImagePanel.Controls.Add(this.panel2);
            this.ImagePanel.Location = new System.Drawing.Point(90, 413);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(90, 10, 3, 3);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(286, 272);
            this.ImagePanel.TabIndex = 35;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(21, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 203);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Location = new System.Drawing.Point(3, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 57);
            this.panel2.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(3, 3);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(93, 35);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(178, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(96, 35);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(90, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 35);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SubmitButtonAddItem
            // 
            this.SubmitButtonAddItem.AutoSize = false;
            this.SubmitButtonAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButtonAddItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SubmitButtonAddItem.Depth = 0;
            this.SubmitButtonAddItem.HighEmphasis = true;
            this.SubmitButtonAddItem.Icon = null;
            this.SubmitButtonAddItem.Location = new System.Drawing.Point(125, 692);
            this.SubmitButtonAddItem.Margin = new System.Windows.Forms.Padding(125, 4, 4, 4);
            this.SubmitButtonAddItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButtonAddItem.Name = "SubmitButtonAddItem";
            this.SubmitButtonAddItem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SubmitButtonAddItem.Size = new System.Drawing.Size(158, 50);
            this.SubmitButtonAddItem.TabIndex = 15;
            this.SubmitButtonAddItem.Text = "Submit";
            this.SubmitButtonAddItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SubmitButtonAddItem.UseAccentColor = false;
            this.SubmitButtonAddItem.UseVisualStyleBackColor = true;
            this.SubmitButtonAddItem.Click += new System.EventHandler(this.SubmitButtonClickAddItem);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.ItemList);
            this.tabControl.Controls.Add(this.AddItem);
            this.tabControl.Controls.Add(this.AddCategory);
            this.tabControl.Controls.Add(this.ItemAlerts);
            this.tabControl.Controls.Add(this.AddBooking);
            this.tabControl.Controls.Add(this.Bookings);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(123, 123);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1396, 896);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ItemList
            // 
            this.ItemList.Controls.Add(this.SearchButton);
            this.ItemList.Controls.Add(this.PriceBetweenLabel);
            this.ItemList.Controls.Add(this.PriceTo);
            this.ItemList.Controls.Add(this.PriceFrom);
            this.ItemList.Controls.Add(this.ExpirationDateLabelBetween);
            this.ItemList.Controls.Add(this.ExpirationTo);
            this.ItemList.Controls.Add(this.ExpirationFrom);
            this.ItemList.Controls.Add(this.SupplierSearchBox);
            this.ItemList.Controls.Add(this.NameSearchBox);
            this.ItemList.Controls.Add(this.productsFlow);
            this.ItemList.Location = new System.Drawing.Point(4, 28);
            this.ItemList.Name = "ItemList";
            this.ItemList.Padding = new System.Windows.Forms.Padding(3);
            this.ItemList.Size = new System.Drawing.Size(1388, 864);
            this.ItemList.TabIndex = 0;
            this.ItemList.Text = "Item List";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = false;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(1127, 31);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(125, 4, 4, 4);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(93, 50);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // PriceBetweenLabel
            // 
            this.PriceBetweenLabel.AutoSize = true;
            this.PriceBetweenLabel.Depth = 0;
            this.PriceBetweenLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceBetweenLabel.Location = new System.Drawing.Point(907, 9);
            this.PriceBetweenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceBetweenLabel.Name = "PriceBetweenLabel";
            this.PriceBetweenLabel.Size = new System.Drawing.Size(103, 19);
            this.PriceBetweenLabel.TabIndex = 10;
            this.PriceBetweenLabel.Text = "Price between:";
            // 
            // PriceTo
            // 
            this.PriceTo.Location = new System.Drawing.Point(905, 66);
            this.PriceTo.Name = "PriceTo";
            this.PriceTo.Size = new System.Drawing.Size(105, 22);
            this.PriceTo.TabIndex = 9;
            // 
            // PriceFrom
            // 
            this.PriceFrom.Location = new System.Drawing.Point(905, 31);
            this.PriceFrom.Name = "PriceFrom";
            this.PriceFrom.Size = new System.Drawing.Size(105, 22);
            this.PriceFrom.TabIndex = 8;
            // 
            // ExpirationDateLabelBetween
            // 
            this.ExpirationDateLabelBetween.AutoSize = true;
            this.ExpirationDateLabelBetween.Depth = 0;
            this.ExpirationDateLabelBetween.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ExpirationDateLabelBetween.Location = new System.Drawing.Point(683, 10);
            this.ExpirationDateLabelBetween.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpirationDateLabelBetween.Name = "ExpirationDateLabelBetween";
            this.ExpirationDateLabelBetween.Size = new System.Drawing.Size(143, 19);
            this.ExpirationDateLabelBetween.TabIndex = 7;
            this.ExpirationDateLabelBetween.Text = "Experation between:";
            // 
            // ExpirationTo
            // 
            this.ExpirationTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationTo.Location = new System.Drawing.Point(686, 68);
            this.ExpirationTo.Name = "ExpirationTo";
            this.ExpirationTo.Size = new System.Drawing.Size(136, 22);
            this.ExpirationTo.TabIndex = 6;
            this.ExpirationTo.Value = new System.DateTime(2034, 12, 25, 23, 59, 59, 999);
            // 
            // ExpirationFrom
            // 
            this.ExpirationFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationFrom.Location = new System.Drawing.Point(686, 32);
            this.ExpirationFrom.Name = "ExpirationFrom";
            this.ExpirationFrom.Size = new System.Drawing.Size(136, 22);
            this.ExpirationFrom.TabIndex = 5;
            this.ExpirationFrom.Value = new System.DateTime(1900, 1, 1, 23, 59, 0, 0);
            // 
            // SupplierSearchBox
            // 
            this.SupplierSearchBox.AutoResize = false;
            this.SupplierSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SupplierSearchBox.Depth = 0;
            this.SupplierSearchBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SupplierSearchBox.DropDownHeight = 174;
            this.SupplierSearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierSearchBox.DropDownWidth = 121;
            this.SupplierSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SupplierSearchBox.FormattingEnabled = true;
            this.SupplierSearchBox.Hint = "Look up by supplier";
            this.SupplierSearchBox.IntegralHeight = false;
            this.SupplierSearchBox.ItemHeight = 43;
            this.SupplierSearchBox.Location = new System.Drawing.Point(326, 32);
            this.SupplierSearchBox.MaxDropDownItems = 4;
            this.SupplierSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SupplierSearchBox.Name = "SupplierSearchBox";
            this.SupplierSearchBox.Size = new System.Drawing.Size(248, 49);
            this.SupplierSearchBox.StartIndex = 0;
            this.SupplierSearchBox.TabIndex = 4;
            // 
            // NameSearchBox
            // 
            this.NameSearchBox.AnimateReadOnly = false;
            this.NameSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NameSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NameSearchBox.Depth = 0;
            this.NameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameSearchBox.HideSelection = true;
            this.NameSearchBox.Hint = "Search by name";
            this.NameSearchBox.LeadingIcon = null;
            this.NameSearchBox.Location = new System.Drawing.Point(15, 31);
            this.NameSearchBox.MaxLength = 32767;
            this.NameSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NameSearchBox.Name = "NameSearchBox";
            this.NameSearchBox.PasswordChar = '\0';
            this.NameSearchBox.PrefixSuffixText = null;
            this.NameSearchBox.ReadOnly = false;
            this.NameSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameSearchBox.SelectedText = "";
            this.NameSearchBox.SelectionLength = 0;
            this.NameSearchBox.SelectionStart = 0;
            this.NameSearchBox.ShortcutsEnabled = true;
            this.NameSearchBox.Size = new System.Drawing.Size(267, 48);
            this.NameSearchBox.TabIndex = 3;
            this.NameSearchBox.TabStop = false;
            this.NameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameSearchBox.TrailingIcon = null;
            this.NameSearchBox.UseSystemPasswordChar = false;
            // 
            // productsFlow
            // 
            this.productsFlow.Location = new System.Drawing.Point(29, 129);
            this.productsFlow.Name = "productsFlow";
            this.productsFlow.Size = new System.Drawing.Size(1307, 603);
            this.productsFlow.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AddCategory.Controls.Add(this.flowLayoutPanel3);
            this.AddCategory.Location = new System.Drawing.Point(4, 28);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Padding = new System.Windows.Forms.Padding(3);
            this.AddCategory.Size = new System.Drawing.Size(1235, 864);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add Category";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.categoryNameLabel);
            this.flowLayoutPanel3.Controls.Add(this.textBoxCattegoryName);
            this.flowLayoutPanel3.Controls.Add(this.categoryDescriptionLabel);
            this.flowLayoutPanel3.Controls.Add(this.textBoxCattegoryDescr);
            this.flowLayoutPanel3.Controls.Add(this.categorySaveButton);
            this.flowLayoutPanel3.Controls.Add(this.buttonAddNew);
            this.flowLayoutPanel3.Controls.Add(this.dgvCategories);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(70, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(488, 776);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.Depth = 0;
            this.categoryNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryNameLabel.Location = new System.Drawing.Point(3, 30);
            this.categoryNameLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.categoryNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(483, 30);
            this.categoryNameLabel.TabIndex = 6;
            this.categoryNameLabel.Text = "Category name:";
            // 
            // textBoxCattegoryName
            // 
            this.textBoxCattegoryName.AnimateReadOnly = false;
            this.textBoxCattegoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCattegoryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Name", true));
            this.textBoxCattegoryName.Depth = 0;
            this.textBoxCattegoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCattegoryName.Hint = "Enter category name";
            this.textBoxCattegoryName.LeadingIcon = null;
            this.textBoxCattegoryName.Location = new System.Drawing.Point(3, 63);
            this.textBoxCattegoryName.MaxLength = 50;
            this.textBoxCattegoryName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCattegoryName.Multiline = false;
            this.textBoxCattegoryName.Name = "textBoxCattegoryName";
            this.textBoxCattegoryName.Size = new System.Drawing.Size(485, 50);
            this.textBoxCattegoryName.TabIndex = 7;
            this.textBoxCattegoryName.Text = "";
            this.textBoxCattegoryName.TrailingIcon = null;
            // 
            // categoryDescriptionLabel
            // 
            this.categoryDescriptionLabel.Depth = 0;
            this.categoryDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryDescriptionLabel.Location = new System.Drawing.Point(3, 126);
            this.categoryDescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.categoryDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            this.categoryDescriptionLabel.Size = new System.Drawing.Size(483, 39);
            this.categoryDescriptionLabel.TabIndex = 0;
            this.categoryDescriptionLabel.Text = "Category description:";
            // 
            // textBoxCattegoryDescr
            // 
            this.textBoxCattegoryDescr.AnimateReadOnly = false;
            this.textBoxCattegoryDescr.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCattegoryDescr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxCattegoryDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxCattegoryDescr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCattegoryDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Description", true));
            this.textBoxCattegoryDescr.Depth = 0;
            this.textBoxCattegoryDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCattegoryDescr.HideSelection = true;
            this.textBoxCattegoryDescr.Hint = "Enter category description:";
            this.textBoxCattegoryDescr.Location = new System.Drawing.Point(3, 168);
            this.textBoxCattegoryDescr.MaxLength = 32767;
            this.textBoxCattegoryDescr.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCattegoryDescr.Name = "textBoxCattegoryDescr";
            this.textBoxCattegoryDescr.PasswordChar = '\0';
            this.textBoxCattegoryDescr.ReadOnly = false;
            this.textBoxCattegoryDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCattegoryDescr.SelectedText = "";
            this.textBoxCattegoryDescr.SelectionLength = 0;
            this.textBoxCattegoryDescr.SelectionStart = 0;
            this.textBoxCattegoryDescr.ShortcutsEnabled = true;
            this.textBoxCattegoryDescr.Size = new System.Drawing.Size(485, 150);
            this.textBoxCattegoryDescr.TabIndex = 8;
            this.textBoxCattegoryDescr.TabStop = false;
            this.textBoxCattegoryDescr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCattegoryDescr.UseSystemPasswordChar = false;
            // 
            // categorySaveButton
            // 
            this.categorySaveButton.AutoSize = false;
            this.categorySaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.categorySaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.categorySaveButton.Depth = 0;
            this.categorySaveButton.HighEmphasis = true;
            this.categorySaveButton.Icon = null;
            this.categorySaveButton.Location = new System.Drawing.Point(4, 331);
            this.categorySaveButton.Margin = new System.Windows.Forms.Padding(4, 10, 4, 6);
            this.categorySaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.categorySaveButton.Name = "categorySaveButton";
            this.categorySaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.categorySaveButton.Size = new System.Drawing.Size(169, 47);
            this.categorySaveButton.TabIndex = 2;
            this.categorySaveButton.Text = "Save";
            this.categorySaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.categorySaveButton.UseAccentColor = false;
            this.categorySaveButton.UseVisualStyleBackColor = true;
            this.categorySaveButton.Click += new System.EventHandler(this.categorySaveButton_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Depth = 0;
            this.buttonAddNew.Icon = global::PointOfSale_1.Properties.Resources.plus_button;
            this.buttonAddNew.Location = new System.Drawing.Point(387, 324);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(210, 3, 3, 3);
            this.buttonAddNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(97, 70);
            this.buttonAddNew.TabIndex = 10;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDelete,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvCategories.DataSource = this.categoryBindingSource;
            this.dgvCategories.Location = new System.Drawing.Point(3, 400);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(483, 150);
            this.dgvCategories.TabIndex = 9;
            this.dgvCategories.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategories_CellMouseClick);
            this.dgvCategories.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCategories_CellValidating);
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Width = 60;
            // 
            // ItemAlerts
            // 
            this.ItemAlerts.Location = new System.Drawing.Point(4, 28);
            this.ItemAlerts.Name = "ItemAlerts";
            this.ItemAlerts.Padding = new System.Windows.Forms.Padding(3);
            this.ItemAlerts.Size = new System.Drawing.Size(1235, 864);
            this.ItemAlerts.TabIndex = 3;
            this.ItemAlerts.Text = "Items Alert";
            this.ItemAlerts.UseVisualStyleBackColor = true;
            // 
            // AddBooking
            // 
            this.AddBooking.Controls.Add(this.splitContainer2);
            this.AddBooking.Location = new System.Drawing.Point(4, 28);
            this.AddBooking.Name = "AddBooking";
            this.AddBooking.Padding = new System.Windows.Forms.Padding(3);
            this.AddBooking.Size = new System.Drawing.Size(1235, 864);
            this.AddBooking.TabIndex = 5;
            this.AddBooking.Text = "Add Booking";
            this.AddBooking.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.quantityBookingLabel);
            this.splitContainer2.Size = new System.Drawing.Size(1229, 858);
            this.splitContainer2.SplitterDistance = 639;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.bookingItemLabel);
            this.flowLayoutPanel4.Controls.Add(this.itemBookingInput);
            this.flowLayoutPanel4.Controls.Add(this.descriptionBookngLabel);
            this.flowLayoutPanel4.Controls.Add(this.descriptionBookingInput);
            this.flowLayoutPanel4.Controls.Add(this.materialLabel1);
            this.flowLayoutPanel4.Controls.Add(this.quantityBookingInput);
            this.flowLayoutPanel4.Controls.Add(this.dateBookingLable);
            this.flowLayoutPanel4.Controls.Add(this.dateBookingInput);
            this.flowLayoutPanel4.Controls.Add(this.submitButtonBooking);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(639, 858);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // bookingItemLabel
            // 
            this.bookingItemLabel.Depth = 0;
            this.bookingItemLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bookingItemLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.bookingItemLabel.Location = new System.Drawing.Point(3, 0);
            this.bookingItemLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookingItemLabel.Name = "bookingItemLabel";
            this.bookingItemLabel.Size = new System.Drawing.Size(350, 23);
            this.bookingItemLabel.TabIndex = 1;
            this.bookingItemLabel.Text = "Booking Item";
            // 
            // itemBookingInput
            // 
            this.itemBookingInput.AnimateReadOnly = false;
            this.itemBookingInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemBookingInput.Depth = 0;
            this.itemBookingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemBookingInput.LeadingIcon = null;
            this.itemBookingInput.Location = new System.Drawing.Point(3, 33);
            this.itemBookingInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.itemBookingInput.MaxLength = 50;
            this.itemBookingInput.MouseState = MaterialSkin.MouseState.OUT;
            this.itemBookingInput.Multiline = false;
            this.itemBookingInput.Name = "itemBookingInput";
            this.itemBookingInput.Size = new System.Drawing.Size(350, 50);
            this.itemBookingInput.TabIndex = 2;
            this.itemBookingInput.Text = "";
            this.itemBookingInput.TrailingIcon = null;
            // 
            // descriptionBookngLabel
            // 
            this.descriptionBookngLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBookngLabel.Depth = 0;
            this.descriptionBookngLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionBookngLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.descriptionBookngLabel.Location = new System.Drawing.Point(3, 93);
            this.descriptionBookngLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.descriptionBookngLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionBookngLabel.Name = "descriptionBookngLabel";
            this.descriptionBookngLabel.Size = new System.Drawing.Size(350, 23);
            this.descriptionBookngLabel.TabIndex = 22;
            this.descriptionBookngLabel.Text = "Description:";
            // 
            // descriptionBookingInput
            // 
            this.descriptionBookingInput.AnimateReadOnly = false;
            this.descriptionBookingInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.descriptionBookingInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descriptionBookingInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionBookingInput.Depth = 0;
            this.descriptionBookingInput.HideSelection = true;
            this.descriptionBookingInput.Location = new System.Drawing.Point(3, 129);
            this.descriptionBookingInput.MaxLength = 32767;
            this.descriptionBookingInput.MouseState = MaterialSkin.MouseState.OUT;
            this.descriptionBookingInput.Name = "descriptionBookingInput";
            this.descriptionBookingInput.PasswordChar = '\0';
            this.descriptionBookingInput.ReadOnly = false;
            this.descriptionBookingInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionBookingInput.SelectedText = "";
            this.descriptionBookingInput.SelectionLength = 0;
            this.descriptionBookingInput.SelectionStart = 0;
            this.descriptionBookingInput.ShortcutsEnabled = true;
            this.descriptionBookingInput.Size = new System.Drawing.Size(350, 139);
            this.descriptionBookingInput.TabIndex = 23;
            this.descriptionBookingInput.TabStop = false;
            this.descriptionBookingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriptionBookingInput.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(3, 271);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(350, 23);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Quantity (Qty): *";
            // 
            // quantityBookingInput
            // 
            this.quantityBookingInput.AnimateReadOnly = false;
            this.quantityBookingInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityBookingInput.Depth = 0;
            this.quantityBookingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quantityBookingInput.LeadingIcon = null;
            this.quantityBookingInput.Location = new System.Drawing.Point(3, 304);
            this.quantityBookingInput.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.quantityBookingInput.MaxLength = 50;
            this.quantityBookingInput.MouseState = MaterialSkin.MouseState.OUT;
            this.quantityBookingInput.Multiline = false;
            this.quantityBookingInput.Name = "quantityBookingInput";
            this.quantityBookingInput.Size = new System.Drawing.Size(350, 50);
            this.quantityBookingInput.TabIndex = 33;
            this.quantityBookingInput.Text = "";
            this.quantityBookingInput.TrailingIcon = null;
            this.quantityBookingInput.TextChanged += new System.EventHandler(this.quantityBookingInput_TextChanged);
            // 
            // dateBookingLable
            // 
            this.dateBookingLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBookingLable.Depth = 0;
            this.dateBookingLable.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dateBookingLable.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.dateBookingLable.Location = new System.Drawing.Point(3, 364);
            this.dateBookingLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateBookingLable.Name = "dateBookingLable";
            this.dateBookingLable.Size = new System.Drawing.Size(350, 23);
            this.dateBookingLable.TabIndex = 34;
            this.dateBookingLable.Text = "Booking Date: *";
            // 
            // dateBookingInput
            // 
            this.dateBookingInput.AllowPromptAsInput = true;
            this.dateBookingInput.AnimateReadOnly = false;
            this.dateBookingInput.AsciiOnly = false;
            this.dateBookingInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dateBookingInput.BeepOnError = false;
            this.dateBookingInput.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dateBookingInput.Depth = 0;
            this.dateBookingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateBookingInput.HidePromptOnLeave = false;
            this.dateBookingInput.HideSelection = true;
            this.dateBookingInput.Hint = "DD/MM/YYYY";
            this.dateBookingInput.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dateBookingInput.LeadingIcon = null;
            this.dateBookingInput.Location = new System.Drawing.Point(3, 390);
            this.dateBookingInput.Mask = "00/00/0000";
            this.dateBookingInput.MaxLength = 32767;
            this.dateBookingInput.MouseState = MaterialSkin.MouseState.OUT;
            this.dateBookingInput.Name = "dateBookingInput";
            this.dateBookingInput.PasswordChar = '\0';
            this.dateBookingInput.PrefixSuffixText = null;
            this.dateBookingInput.PromptChar = '_';
            this.dateBookingInput.ReadOnly = false;
            this.dateBookingInput.RejectInputOnFirstFailure = false;
            this.dateBookingInput.ResetOnPrompt = true;
            this.dateBookingInput.ResetOnSpace = true;
            this.dateBookingInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateBookingInput.SelectedText = "";
            this.dateBookingInput.SelectionLength = 0;
            this.dateBookingInput.SelectionStart = 0;
            this.dateBookingInput.ShortcutsEnabled = true;
            this.dateBookingInput.Size = new System.Drawing.Size(350, 48);
            this.dateBookingInput.SkipLiterals = true;
            this.dateBookingInput.TabIndex = 35;
            this.dateBookingInput.TabStop = false;
            this.dateBookingInput.Text = "  /  /";
            this.dateBookingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dateBookingInput.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dateBookingInput.TrailingIcon = null;
            this.dateBookingInput.UseSystemPasswordChar = false;
            this.dateBookingInput.ValidatingType = null;
            // 
            // submitButtonBooking
            // 
            this.submitButtonBooking.AutoSize = false;
            this.submitButtonBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButtonBooking.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButtonBooking.Depth = 0;
            this.submitButtonBooking.HighEmphasis = true;
            this.submitButtonBooking.Icon = null;
            this.submitButtonBooking.Location = new System.Drawing.Point(125, 445);
            this.submitButtonBooking.Margin = new System.Windows.Forms.Padding(125, 4, 4, 4);
            this.submitButtonBooking.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButtonBooking.Name = "submitButtonBooking";
            this.submitButtonBooking.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButtonBooking.Size = new System.Drawing.Size(158, 50);
            this.submitButtonBooking.TabIndex = 36;
            this.submitButtonBooking.Text = "Submit";
            this.submitButtonBooking.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButtonBooking.UseAccentColor = false;
            this.submitButtonBooking.UseVisualStyleBackColor = true;
            this.submitButtonBooking.Click += new System.EventHandler(this.submitButtonBooking_Click);
            // 
            // quantityBookingLabel
            // 
            this.quantityBookingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityBookingLabel.Location = new System.Drawing.Point(0, 0);
            this.quantityBookingLabel.Name = "quantityBookingLabel";
            this.quantityBookingLabel.Size = new System.Drawing.Size(586, 858);
            this.quantityBookingLabel.TabIndex = 0;
            this.quantityBookingLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.quantityBookingLabel_Paint);
            // 
            // Bookings
            // 
            this.Bookings.Controls.Add(this.flowLayoutPanel5);
            this.Bookings.Location = new System.Drawing.Point(4, 28);
            this.Bookings.Name = "Bookings";
            this.Bookings.Padding = new System.Windows.Forms.Padding(3);
            this.Bookings.Size = new System.Drawing.Size(1235, 864);
            this.Bookings.TabIndex = 4;
            this.Bookings.Text = "Bookings";
            this.Bookings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.bookingsDataGridView);
            this.flowLayoutPanel5.Controls.Add(this.bindingNavigator1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1229, 858);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // bookingsDataGridView
            // 
            this.bookingsDataGridView.AllowUserToAddRows = false;
            this.bookingsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingsDataGridView.AutoGenerateColumns = false;
            this.bookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn1,
            this.bookingDateDataGridViewTextBoxColumn1});
            this.bookingsDataGridView.DataSource = this.bookingBindingSource;
            this.bookingsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.RowHeadersWidth = 51;
            this.bookingsDataGridView.RowTemplate.Height = 24;
            this.bookingsDataGridView.Size = new System.Drawing.Size(1214, 515);
            this.bookingsDataGridView.TabIndex = 0;
            this.bookingsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.bookingsDataGridView_CellValidating);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AllowDrop = true;
            this.bindingNavigator1.BindingSource = this.bookingBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 521);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(331, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(123, 69);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1286, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Depth = 0;
            this.Logout.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Logout.Location = new System.Drawing.Point(46, 85);
            this.Logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(51, 19);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseAccent = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(PointOfSale_1.Models.Category);
            this.categoryBindingSource.CurrentChanged += new System.EventHandler(this.categoryBindingSource_CurrentChanged);
            this.categoryBindingSource.PositionChanged += new System.EventHandler(this.categoryBindingSource_PositionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 150F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn1
            // 
            this.bookingDateDataGridViewTextBoxColumn1.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn1.Name = "bookingDateDataGridViewTextBoxColumn1";
            this.bookingDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(PointOfSale_1.Models.Booking);
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(3, 24);
            this.header1.Margin = new System.Windows.Forms.Padding(4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1672, 80);
            this.header1.TabIndex = 7;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PointOfSale_1.Models.Product);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1080);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.header1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Stocks";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "StockList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ItemList.ResumeLayout(false);
            this.ItemList.PerformLayout();
            this.AddCategory.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.AddBooking.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.Bookings.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage AddItem;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage ItemList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage AddCategory;
        private System.Windows.Forms.TabPage ItemAlerts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton SubmitButtonAddItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel categoryDescriptionLabel;
        private MaterialSkin.Controls.MaterialButton categorySaveButton;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MaterialSkin.Controls.MaterialLabel categoryNameLabel;
        private MaterialSkin.Controls.MaterialTextBox textBoxCattegoryName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBoxCattegoryDescr;
        private System.Windows.Forms.DataGridView dgvCategories;
        private MaterialSkin.Controls.MaterialFloatingActionButton buttonAddNew;
        private System.Windows.Forms.DataGridViewImageColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel ItemNameLabel;
        private MaterialSkin.Controls.MaterialTextBox BarcodeInput;
        private MaterialSkin.Controls.MaterialLabel ItemBarcodeLabel;
        private MaterialSkin.Controls.MaterialTextBox NameInput;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionInput;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
        private MaterialSkin.Controls.MaterialLabel QuantityLabel;
        private MaterialSkin.Controls.MaterialLabel PurchasePriceLabel;
        private MaterialSkin.Controls.MaterialLabel SalesPriceLabel;
        private MaterialSkin.Controls.MaterialLabel DiscountRateLabel;
        private MaterialSkin.Controls.MaterialLabel CategoryLabel;
        private MaterialSkin.Controls.MaterialComboBox CategoryInput;
        private MaterialSkin.Controls.MaterialLabel SupplierLabel;
        private MaterialSkin.Controls.MaterialComboBox SupplierInput;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel ExpireDateLabel;
        private MaterialSkin.Controls.MaterialMaskedTextBox ExpireDate;
        private MaterialSkin.Controls.MaterialLabel ManufacturingDateLabel;
        private MaterialSkin.Controls.MaterialMaskedTextBox ManufacturingDateInput;
        private MaterialSkin.Controls.MaterialLabel WeightLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.FlowLayoutPanel productsFlow;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialLabel PriceBetweenLabel;
        private System.Windows.Forms.TextBox PriceTo;
        private System.Windows.Forms.TextBox PriceFrom;
        private MaterialSkin.Controls.MaterialLabel ExpirationDateLabelBetween;
        private System.Windows.Forms.DateTimePicker ExpirationTo;
        private System.Windows.Forms.DateTimePicker ExpirationFrom;
        private MaterialSkin.Controls.MaterialComboBox SupplierSearchBox;
        private MaterialSkin.Controls.MaterialTextBox2 NameSearchBox;
        private MaterialSkin.Controls.MaterialTextBox QuantityInput;
        private MaterialSkin.Controls.MaterialTextBox PurchasePriceInput;
        private MaterialSkin.Controls.MaterialTextBox SalesPriceInput;
        private MaterialSkin.Controls.MaterialTextBox DiscountRateInput;
        private MaterialSkin.Controls.MaterialTextBox WeightInput;
        private System.Windows.Forms.TabPage Bookings;
        private System.Windows.Forms.TabPage AddBooking;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel quantityBookingLabel;
        private MaterialSkin.Controls.MaterialLabel bookingItemLabel;
        private MaterialSkin.Controls.MaterialTextBox itemBookingInput;
        private MaterialSkin.Controls.MaterialLabel descriptionBookngLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 descriptionBookingInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox quantityBookingInput;
        private MaterialSkin.Controls.MaterialLabel dateBookingLable;
        private MaterialSkin.Controls.MaterialMaskedTextBox dateBookingInput;
        private MaterialSkin.Controls.MaterialButton submitButtonBooking;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.DataGridView bookingsDataGridView;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ToolStripButton toolStripButton1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn1;
        private MaterialSkin.Controls.MaterialLabel Logout;
        private Controls.Header header1;
        private MaterialSkin.Controls.MaterialButton deleteButton;
    }
}

