namespace BMP_EXC_SERHIIENKO
{
    partial class CompareForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbImageFirst = new System.Windows.Forms.ComboBox();
            this.histImage2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbImage2 = new System.Windows.Forms.ComboBox();
            this.histImage1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histImage3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.pbImage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.histImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbImageFirst
            // 
            this.cbImageFirst.FormattingEnabled = true;
            this.cbImageFirst.Location = new System.Drawing.Point(12, 12);
            this.cbImageFirst.Name = "cbImageFirst";
            this.cbImageFirst.Size = new System.Drawing.Size(208, 21);
            this.cbImageFirst.TabIndex = 0;
            this.cbImageFirst.SelectedIndexChanged += new System.EventHandler(this.cbImageFirst_SelectedIndexChanged);
            // 
            // histImage2
            // 
            chartArea1.Name = "ChartArea1";
            this.histImage2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histImage2.Legends.Add(legend1);
            this.histImage2.Location = new System.Drawing.Point(406, 260);
            this.histImage2.Name = "histImage2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histImage2.Series.Add(series1);
            this.histImage2.Size = new System.Drawing.Size(339, 194);
            this.histImage2.TabIndex = 1;
            this.histImage2.Text = "histImg1";
            // 
            // cbImage2
            // 
            this.cbImage2.FormattingEnabled = true;
            this.cbImage2.Location = new System.Drawing.Point(406, 12);
            this.cbImage2.Name = "cbImage2";
            this.cbImage2.Size = new System.Drawing.Size(208, 21);
            this.cbImage2.TabIndex = 2;
            this.cbImage2.SelectedIndexChanged += new System.EventHandler(this.cbImage2_SelectedIndexChanged);
            // 
            // histImage1
            // 
            chartArea2.Name = "ChartArea1";
            this.histImage1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.histImage1.Legends.Add(legend2);
            this.histImage1.Location = new System.Drawing.Point(12, 260);
            this.histImage1.Name = "histImage1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histImage1.Series.Add(series2);
            this.histImage1.Size = new System.Drawing.Size(339, 194);
            this.histImage1.TabIndex = 5;
            this.histImage1.Text = "histImg1";
            // 
            // histImage3
            // 
            chartArea3.Name = "ChartArea1";
            this.histImage3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.histImage3.Legends.Add(legend3);
            this.histImage3.Location = new System.Drawing.Point(803, 260);
            this.histImage3.Name = "histImage3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.histImage3.Series.Add(series3);
            this.histImage3.Size = new System.Drawing.Size(339, 194);
            this.histImage3.TabIndex = 6;
            this.histImage3.Text = "histImg1";
            // 
            // pbImage1
            // 
            this.pbImage1.Location = new System.Drawing.Point(12, 39);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(339, 215);
            this.pbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage1.TabIndex = 7;
            this.pbImage1.TabStop = false;
            // 
            // pbImage2
            // 
            this.pbImage2.Location = new System.Drawing.Point(406, 39);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(339, 215);
            this.pbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage2.TabIndex = 8;
            this.pbImage2.TabStop = false;
            // 
            // pbImage3
            // 
            this.pbImage3.Location = new System.Drawing.Point(803, 39);
            this.pbImage3.Name = "pbImage3";
            this.pbImage3.Size = new System.Drawing.Size(339, 215);
            this.pbImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage3.TabIndex = 9;
            this.pbImage3.TabStop = false;
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 466);
            this.Controls.Add(this.pbImage3);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage1);
            this.Controls.Add(this.histImage3);
            this.Controls.Add(this.histImage1);
            this.Controls.Add(this.histImage2);
            this.Controls.Add(this.cbImage2);
            this.Controls.Add(this.cbImageFirst);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.histImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbImageFirst;
        private System.Windows.Forms.DataVisualization.Charting.Chart histImage2;
        private System.Windows.Forms.ComboBox cbImage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart histImage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histImage3;
        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.PictureBox pbImage3;
    }
}