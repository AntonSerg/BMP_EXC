namespace BMP_EXC_SERHIIENKO
{
    partial class ImageForm
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
            this.pcMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMainImage
            // 
            this.pcMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMainImage.Location = new System.Drawing.Point(0, 0);
            this.pcMainImage.Name = "pcMainImage";
            this.pcMainImage.Size = new System.Drawing.Size(612, 457);
            this.pcMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMainImage.TabIndex = 1;
            this.pcMainImage.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 457);
            this.Controls.Add(this.pcMainImage);
            this.Name = "ImageForm";
            this.Text = "MainImage";
            ((System.ComponentModel.ISupportInitialize)(this.pcMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcMainImage;
    }
}