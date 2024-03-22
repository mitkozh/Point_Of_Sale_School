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
    public partial class LabeledMaskedInput : UserControl
    {
        private bool _isRequired;
        private string _labelText;

        public LabeledMaskedInput()
        {
            InitializeComponent();
            if (LabelText == "")
            {
                LabelText = "enterLabel";
            }
            if (TextBoxName == "")
            {
                TextBoxName = "TextBox";
            }
            Mask = "";
        }

        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value.TrimEnd(' ', '*');
                UpdateLabelText();
            }
        }

        public string TextBoxName
        {
            get { return textBox.Name; }
            set { textBox.Name = value; }
        }

        public string Mask
        {
            get { return textBox.Mask; }
            set { textBox.Mask = value; }
        }

        public bool IsRequired
        {
            get { return _isRequired; }
            set
            {
                _isRequired = value;
                UpdateLabelText();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Serialize the value
        [Bindable(true)]
        public override string Text
        {
            get { return textBox.Text; }
            set
            {
                textBox.Text = value;
            }
        }

        private void UpdateLabelText()
        {
            label.Text = _labelText;
            if (_isRequired)
            {
                label.Text += " *";
            }
        }
    }
}
