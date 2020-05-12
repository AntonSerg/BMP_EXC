using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BMP_EXC_SERHIIENKO
{
    public partial class CompareForm : Form
    {
        Form[] imageForms;
        public CompareForm(Form[] chilrens)
        {
            InitializeComponent();
            imageForms = chilrens;
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            foreach (var item in imageForms)
            {
                cbImageFirst.Items.Add(item.Text);
                cbImage2.Items.Add(item.Text);
            }
        }

        private void cbImageFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < imageForms.Length; i++)
            {
                if(imageForms[i].Text == cbImageFirst.Text)
                {
                    pbImage1.Image = ((ImageForm)imageForms[i]).MainImage;
                    long[] histogram = BitmapExtension.GetHistogram(((ImageForm)imageForms[i]).MainImage);
                    histImage1.Series["Series1"].Points.DataBindXY(Enumerable.Range(0, 256).ToList(), histogram.ToList());
                    Axis ax = histImage1.ChartAreas[0].AxisX;
                    ax.Minimum = 0;
                    ax.Maximum = 255;
                }
            }
        }

        private void cbImage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < imageForms.Length; i++)
            {
                if (imageForms[i].Text == cbImage2.Text)
                {
                    pbImage2.Image = ((ImageForm)imageForms[i]).MainImage;
                    long[] histogram = BitmapExtension.GetHistogram(((ImageForm)imageForms[i]).MainImage);
                    histImage2.Series["Series1"].Points.DataBindXY(Enumerable.Range(0, 256).ToList(), histogram.ToList());
                    Axis ax = histImage1.ChartAreas[0].AxisX;
                    ax.Minimum = 0;
                    ax.Maximum = 255;
                }
            }
        }
    }
}
