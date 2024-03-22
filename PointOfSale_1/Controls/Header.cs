using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1.Controls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            lblTime.Text = DateTime.Now.ToString();
        }

        private void Header_Load(object sender, EventArgs e)
        {

        }

        public void UpdateUserLabel(string newText)
        {
            lblUser.Text = newText;
        }
    }
}
