using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP_EXC_SERHIIENKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string OpenImage()
        {
            openFileDialog1.Filter = "";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;
            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                openFileDialog1.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog1.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }
            openFileDialog1.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog1.Filter, sep, "All Files", "*.*");
            openFileDialog1.DefaultExt = ".png";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return "fail";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = OpenImage();
            if (filePath == "fail")
            {
                return;
            }
            ImageForm imgForm = new ImageForm(filePath);
            if (imgForm.isImageCorrect == false)
            {
                MessageBox.Show("Probably that's file not suported / not image", "Error");
                return;
            }
            imgForm.MdiParent = this;
            imgForm.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                MessageBox.Show("First you need open image to save", "You don't choose the image");
                return;
            }
            saveFileDialog1.Filter = "";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ((ImageForm)this.ActiveMdiChild).MainImage.Save(saveFileDialog1.FileName, ((ImageForm)this.ActiveMdiChild).MainImage.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't save image!");
                }
            }
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                MessageBox.Show("First you need open image to export", "You don't choose the image");
                return;
            }
            saveFileDialog1.Filter = "CSV FILES | *.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ((ImageForm)this.ActiveMdiChild).MainImage.Save(saveFileDialog1.FileName, ((ImageForm)this.ActiveMdiChild).MainImage.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't open image!");
                    return;
                }
                Bitmap bmp = ((ImageForm)this.ActiveMdiChild).MainImage;
                BitmapData bmData = null;
                int bytesPerPixel, heightInPixels, widthInPixels;
                StreamWriter writer = new StreamWriter(Path.GetFullPath(saveFileDialog1.FileName), false);

                try
                {
                    bmp.LockImage(out bmData, out bytesPerPixel, out heightInPixels, out widthInPixels);
                    unsafe
                    {
                        for (int y = 0; y < heightInPixels; y++)
                        {
                            for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                            {
                                writer.Write(bmData.GetPixelXY(x, y));
                                if (x != widthInPixels - 1)
                                    writer.Write(';');
                            }
                            if (y != heightInPixels - 1)
                                writer.WriteLine();
                        }
                    }
                    bmp.UnlockBits(bmData);
                    writer.Dispose();
                }
                catch
                {
                    try
                    {
                        bmp.UnlockBits(bmData);
                        writer.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void csvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV FILES | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                

                StreamReader reader = new StreamReader(Path.GetFullPath(openFileDialog1.FileName));
                int height = File.ReadAllLines(Path.GetFullPath(openFileDialog1.FileName)).Length;
                string[] temp = reader.ReadLine().Split(';');
                int width = temp.Length - 1;
                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
                BitmapData bmData = null;
                int bytesPerPixel, heightInPixels, widthInPixels;
                ColorPalette pal = bmp.Palette;
                for (int i = 0; i < pal.Entries.Length; i++)
                    pal.Entries[i] = Color.FromArgb(i, i, i);
                bmp.Palette = pal;


                try
                {
                    bmp.LockImage(out bmData, out bytesPerPixel, out heightInPixels, out widthInPixels);
                    unsafe
                    {
                        for (int y = 0; y < heightInPixels; y++)
                        {
                            if (y != 0)
                                temp = reader.ReadLine().Split(';');
                            for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                            {
                                bmData.SetPixelXY(x, y, Convert.ToByte(temp[x]));
                            }
                        }
                    }
                    bmp.UnlockBits(bmData);
                    reader.Dispose();
                    ImageForm imgForm = new ImageForm(bmp);
                    imgForm.MdiParent = this;
                    imgForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    try
                    {
                        bmp.UnlockBits(bmData);
                        reader.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void compareImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CompareForm compareF = new CompareForm(this.MdiChildren);
            compareF.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
