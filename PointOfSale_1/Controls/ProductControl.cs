using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PointOfSale_1.Controls
{
    public partial class ProductControl : UserControl
    {
        [Browsable(true)]
        public event EventHandler UserControlClicked;

        public ProductControl()
        {
            InitializeComponent();
        }

        public void SetValues(string barcode, string name, int quantity, string price, Image image, int availabeQuantity)
        {
            barcodeLabel.Text = barcode;
            nameLabel.Text = name;
            quantityLabel.Text = $"Qty: {quantity}";
            priceLabel.Text = $"Price: {price}";
            imageBox.BackgroundImage = image;
            availableQty.Text = $"Qty avlb: {availabeQuantity}";

            this.Click += ControlClicked;
            quantityLabel.Click+= ControlClicked;
            barcodeLabel.Click += ControlClicked;
            nameLabel.Click += ControlClicked;
            priceLabel.Click += ControlClicked;
            imageBox.Click += ControlClicked;
            flowLayoutPanel1.Click += ControlClicked;
            splitContainer1.Click += ControlClicked;
            materialCard1.Click += ControlClicked;
        }

        private void ControlClicked(object sender, EventArgs e)
        {
            UserControlClicked?.Invoke(this, e);
        }
    }
}
