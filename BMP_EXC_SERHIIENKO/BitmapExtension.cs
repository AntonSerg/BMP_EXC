using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMP_EXC_SERHIIENKO
{
    public static class BitmapExtension
    {
        public static Bitmap ToGrayscale(this Bitmap bmpOrg)
        {
            //create a blank bitmap the same size as original
            Bitmap bmpGrayScale = new Bitmap(bmpOrg.Width, bmpOrg.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(bmpGrayScale);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(bmpOrg, new Rectangle(0, 0, bmpOrg.Width, bmpOrg.Height),
               0, 0, bmpOrg.Width, bmpOrg.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return bmpGrayScale;
        }
        public static void LockImage(this Bitmap bmp, out BitmapData bmData, out int bytesPerPixel, out int heightInPixels, out int widthInPixels)
        {
            bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
            bytesPerPixel = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
            heightInPixels = bmp.Height;
            widthInPixels = bmp.Width * bytesPerPixel;
        }
        public static byte GetPixelXY(this BitmapData bmData, int x, int y)
        {
            unsafe
            {
                byte* ptr = (byte*)((byte*)bmData.Scan0 + (y * bmData.Stride) + x);
                return *ptr;
            }
        }
        public static void SetPixelXY(this BitmapData bmData,int x, int y, byte value)
        {
            unsafe
            {
                byte* ptr = (byte*)((byte*)bmData.Scan0 + (y * bmData.Stride) + x);
                *ptr = value;
            }
        }
        public static long[] GetHistogram(this Bitmap imageBitMap)
        {
            long[] histogram = new long[256];
            BitmapData bmData = null;
            int bytesPerPixel, heightInPixels, widthInPixels;

            try
            {
                LockImage(imageBitMap, out bmData, out bytesPerPixel, out heightInPixels, out widthInPixels);
                unsafe
                {
                    for (int y = 0; y < heightInPixels; y++)
                    {
                        for (int x = 0; x < widthInPixels; x += bytesPerPixel)
                        {
                            histogram[bmData.GetPixelXY(x,y)]++;
                        }
                    }
                }
                imageBitMap.UnlockBits(bmData);
            }
            catch
            {
                try
                {
                    imageBitMap.UnlockBits(bmData);
                }
                catch
                {
                }
            }
            return histogram;
        }
    }
}
