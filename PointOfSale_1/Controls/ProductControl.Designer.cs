namespace PointOfSale_1.Controls
{
    partial class ProductControl
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.quantityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.availableQty = new MaterialSkin.Controls.MaterialLabel();
            this.priceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.splitContainer1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(427, 176);
            this.materialCard1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(14, 14);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(399, 148);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(3, 24);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(126, 106);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.barcodeLabel);
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.quantityLabel);
            this.flowLayoutPanel1.Controls.Add(this.availableQty);
            this.flowLayoutPanel1.Controls.Add(this.priceLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 148);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.Depth = 0;
            this.barcodeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.barcodeLabel.Location = new System.Drawing.Point(10, 10);
            this.barcodeLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.barcodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(165, 19);
            this.barcodeLabel.TabIndex = 0;
            this.barcodeLabel.Text = "barcode";
            // 
            // nameLabel
            // 
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.nameLabel.Location = new System.Drawing.Point(10, 39);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(175, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "materialLabel2";
            this.nameLabel.UseAccent = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Depth = 0;
            this.quantityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quantityLabel.Location = new System.Drawing.Point(10, 68);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.quantityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(165, 19);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "materialLabel3";
            // 
            // availableQty
            // 
            this.availableQty.Depth = 0;
            this.availableQty.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availableQty.Location = new System.Drawing.Point(10, 97);
            this.availableQty.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.availableQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.availableQty.Name = "availableQty";
            this.availableQty.Size = new System.Drawing.Size(165, 19);
            this.availableQty.TabIndex = 4;
            this.availableQty.Text = "materialLabel4";
            // 
            // priceLabel
            // 
            this.priceLabel.Depth = 0;
            this.priceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceLabel.Location = new System.Drawing.Point(10, 126);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.priceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(175, 19);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "materialLabel4";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(475, 219);
            this.materialCard1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel barcodeLabel;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel quantityLabel;
        private MaterialSkin.Controls.MaterialLabel priceLabel;
        private MaterialSkin.Controls.MaterialLabel availableQty;
    }
}
