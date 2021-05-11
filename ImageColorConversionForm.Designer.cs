
namespace ImageColorConversion
{
    partial class ImageColorConversionForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRYCrCbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRLUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(749, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 416);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1501, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGRGrayToolStripMenuItem,
            this.bGRYCrCbToolStripMenuItem,
            this.bGRHSVToolStripMenuItem,
            this.bGRLUVToolStripMenuItem,
            this.bGRLabToolStripMenuItem,
            this.bGRHLSToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.colorToolStripMenuItem.Text = "Color Transformation";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // bGRGrayToolStripMenuItem
            // 
            this.bGRGrayToolStripMenuItem.Name = "bGRGrayToolStripMenuItem";
            this.bGRGrayToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.bGRGrayToolStripMenuItem.Text = "BGR - Gray";
            this.bGRGrayToolStripMenuItem.Click += new System.EventHandler(this.bGRGrayToolStripMenuItem_Click);
            // 
            // bGRYCrCbToolStripMenuItem
            // 
            this.bGRYCrCbToolStripMenuItem.Name = "bGRYCrCbToolStripMenuItem";
            this.bGRYCrCbToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRYCrCbToolStripMenuItem.Text = "BGR - YCrCb";
            this.bGRYCrCbToolStripMenuItem.Click += new System.EventHandler(this.bGRYCrCbToolStripMenuItem_Click);
            // 
            // bGRHSVToolStripMenuItem
            // 
            this.bGRHSVToolStripMenuItem.Name = "bGRHSVToolStripMenuItem";
            this.bGRHSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRHSVToolStripMenuItem.Text = "BGR - HSV";
            this.bGRHSVToolStripMenuItem.Click += new System.EventHandler(this.bGRHSVToolStripMenuItem_Click);
            // 
            // bGRLUVToolStripMenuItem
            // 
            this.bGRLUVToolStripMenuItem.Name = "bGRLUVToolStripMenuItem";
            this.bGRLUVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRLUVToolStripMenuItem.Text = "BGR - LUV";
            this.bGRLUVToolStripMenuItem.Click += new System.EventHandler(this.bGRLUVToolStripMenuItem_Click);
            // 
            // bGRLabToolStripMenuItem
            // 
            this.bGRLabToolStripMenuItem.Name = "bGRLabToolStripMenuItem";
            this.bGRLabToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRLabToolStripMenuItem.Text = "BGR - Lab";
            this.bGRLabToolStripMenuItem.Click += new System.EventHandler(this.bGRLabToolStripMenuItem_Click);
            // 
            // bGRHLSToolStripMenuItem
            // 
            this.bGRHLSToolStripMenuItem.Name = "bGRHLSToolStripMenuItem";
            this.bGRHLSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRHLSToolStripMenuItem.Text = "BGR - HLS";
            this.bGRHLSToolStripMenuItem.Click += new System.EventHandler(this.bGRHLSToolStripMenuItem_Click);
            // 
            // ImageColorConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageColorConversionForm";
            this.Text = "ImageColorConversionForm";
            this.Load += new System.EventHandler(this.ImageColorConversionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRYCrCbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRLUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHLSToolStripMenuItem;
    }
}

