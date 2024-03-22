namespace PointOfSale_1
{
    partial class Login
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
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Enter username or email";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(143, 470);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(282, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Enter Password";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(143, 543);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(282, 50);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Select Role";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Worker",
            "Customer"});
            this.materialComboBox1.Location = new System.Drawing.Point(143, 368);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(282, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(163, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(213, 58);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "MitkoPOS";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = false;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(143, 695);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(125, 4, 4, 4);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(282, 52);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Login";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PointOfSale_1.Properties.Resources.polygon_pos_logo_F06DB99CFF_seeklogo_com;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(116, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 215);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 920);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}