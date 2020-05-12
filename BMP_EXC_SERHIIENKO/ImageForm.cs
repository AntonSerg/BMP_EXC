using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BMP_EXC_SERHIIENKO
{
    public partial class ImageForm : Form
    {
        static int imgCnt = 0;
        private string filePath;
        public string FilePath { get; }
        private Bitmap mainImage;
        public Bitmap MainImage { get { return mainImage; } }
        public bool isImageCorrect = true;
        public ImageForm(Bitmap bmp)
        {
            InitializeComponent();
            mainImage = new Bitmap(bmp.Width,bmp.Height,PixelFormat.Format8bppIndexed);
            mainImage = bmp;
            pcMainImage.Image = mainImage;
            this.Text = "New image " + imgCnt;
            this.filePath = string.Empty;
            imgCnt++;
        }
        ~ImageForm()
        {
            imgCnt--;
        }
        public ImageForm(string filePath)
        {
            InitializeComponent();
            try
            {
                mainImage = new Bitmap(filePath).ToGrayscale();
            }
            catch (Exception)
            {
                isImageCorrect = false;
                return;
            }
            pcMainImage.Image = mainImage;
            this.filePath = filePath;
            this.Text = Path.GetFileName(filePath) + imgCnt;
            imgCnt++;
        }
    }
}
