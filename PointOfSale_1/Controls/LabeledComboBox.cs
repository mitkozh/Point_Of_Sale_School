using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale_1.Controls
{
    public partial class LabeledComboBox : UserControl
    {
        private bool _isRequired;
        private string _labelText;

        public LabeledComboBox()
        {
            InitializeComponent();
            if (LabelText == "")
            {
                LabelText = "enterLabel";
            }
            if (ComboBoxName == "")
            {
                ComboBoxName = "TextBox";
            }
            IsRequired = false;
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

        public string ComboBoxName
        {
            get { return comboBox.Name; }
            set { comboBox.Name = value; }
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

        private void UpdateLabelText()
        {
            label.Text = _labelText;
            if (_isRequired)
            {
                label.Text += " *";
            }
        }

        public List<string> Items
        {
            get { return new List<string>(comboBox.Items.Cast<string>()); }
            set
            {
                comboBox.Items.Clear();
                comboBox.Items.AddRange(value.ToArray());
            }
        }

        public void AddItem(string item)
        {
            comboBox.Items.Add(item);
        }

        public string GetSelectedItem()
        {
            return comboBox.SelectedItem?.ToString();
        }

        internal void ClearSelection()
        {
            comboBox.SelectedItem = null;
        }
    }
}
