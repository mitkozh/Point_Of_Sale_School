using System.Drawing;

namespace PointOfSale_1.Controls
{
    partial class Header
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(102, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MitkoPOS 1.0";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(222, 14);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 19);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "admin";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.Location = new System.Drawing.Point(306, 14);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::PointOfSale_1.Properties.Resources.polygon_pos_logo_F06DB99CFF_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(34, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1067, 80);
            this.Load += new System.EventHandler(this.Header_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
