using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_1.Controls
{
    public partial class LabeledDateTimePicker : UserControl
    {

        private bool _isRequired;
        private string _labelText;

        public LabeledDateTimePicker()
        {
            InitializeComponent();
            if (LabelText == "")
            {
                LabelText = "enterLabel";
            }
            if (DateTimePickerName == "")
            {
                DateTimePickerName = "DateTimePicker";
            }
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

        public string DateTimePickerName
        {
            get { return dateTimePicker.Name; }
            set { dateTimePicker.Name = value; }
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

        public DateTime DateTimePickerValue
        {
            get
            {
                return dateTimePicker.Value;
            }
            set
            {
                dateTimePicker.Value = value;
            }
        }

        public void ResetValue()
        {
            dateTimePicker.Value = DateTime.Now;
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
