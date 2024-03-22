namespace PointOfSale_1.Controls
{
    partial class LabeledComboBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, -3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 28);
            this.label.TabIndex = 0;
            this.label.Text = "EnterLabelText";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox.Location = new System.Drawing.Point(13, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(193, 36);
            this.comboBox.TabIndex = 1;
            // 
            // LabeledComboBox
            // 
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label);
            this.Name = "LabeledComboBox";
            this.Size = new System.Drawing.Size(220, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox;

    }
}
