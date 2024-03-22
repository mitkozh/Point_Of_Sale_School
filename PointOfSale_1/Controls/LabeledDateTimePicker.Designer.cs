namespace PointOfSale_1.Controls
{
    partial class LabeledDateTimePicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(11, -4);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 28);
            this.label.TabIndex = 0;
            this.label.Text = "EnterLabText";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(17, 34);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(315, 34);
            this.dateTimePicker.TabIndex = 0;
            
            // 
            // LabeledDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LabeledDateTimePicker";
            this.Size = new System.Drawing.Size(349, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



    }


}
