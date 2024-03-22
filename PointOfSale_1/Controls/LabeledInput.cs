using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PointOfSale_1.Controls
{
    public partial class LabeledInput : UserControl, INotifyPropertyChanged
    {
        private bool _isRequired;
        private bool _isMultiline;
        private string _labelText;

        public event PropertyChangedEventHandler PropertyChanged;

        public LabeledInput()
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
        }

        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value.TrimEnd(' ', '*');
                UpdateLabelText();
                OnPropertyChanged(nameof(LabelText));
            }
        }

        public string TextBoxName
        {
            get { return textBox.Name; }
            set
            {
                textBox.Name = value;
                OnPropertyChanged(nameof(TextBoxName));
            }
        }

        public bool IsRequired
        {
            get { return _isRequired; }
            set
            {
                _isRequired = value;
                UpdateLabelText();
                OnPropertyChanged(nameof(IsRequired));
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
                OnPropertyChanged(nameof(Text));
            }
        }

        public bool IsMultiline
        {
            get { return _isMultiline; }
            set
            {
                _isMultiline = value;
                textBox.Multiline = _isMultiline;
                if (_isMultiline)
                {
                    textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                }
                else
                {
                    textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                OnPropertyChanged(nameof(IsMultiline));
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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
