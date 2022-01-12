using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageProcessing
{
    class Processing
    {
        public Processing()
        {

        }
        public static Bitmap DrawRandPixel(Bitmap bitmap)
        {
            int r, g, b, a;
            Random rand = new Random();
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    a = rand.Next(256);
                    r = rand.Next(256);
                    g = rand.Next(256);
                    b = rand.Next(256);
                    bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bitmap;
        }

        public static Bitmap ResizeImageForPreview(Bitmap bitmapToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = bitmapToResize.Width;
            //Get the image current height  
            int sourceHeight = bitmapToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap bitmapResized = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(bitmapResized);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(bitmapToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return bitmapResized;
        }

        public static Bitmap DrawRandFull(Bitmap bitmap)
        {
            Random rand = new Random();
            int a, r, g, b;
            a = rand.Next(256);
            r = rand.Next(256);
            g = rand.Next(256);
            b = rand.Next(256);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bitmap;
        }

        public static Bitmap DrawLines(Bitmap bitmap, int nbLines, bool column)
        {
            int heightLine = bitmap.Height / nbLines;
            int widthLine = bitmap.Width / nbLines;
            int incrNbLines = 1;
            int a = 0;
            int r = 0;
            int g = 0;
            int b = 0;
            Random rand = new Random();
            //column code
            if (column == true)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (incrNbLines > widthLine || incrNbLines == 1)
                    {
                        a = rand.Next(256);
                        r = rand.Next(256);
                        g = rand.Next(256);
                        b = rand.Next(256);
                        incrNbLines = 1;
                    }
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                    incrNbLines++;
                }
            }
            else
            {
                a = rand.Next(256);
                r = rand.Next(256);
                g = rand.Next(256);
                b = rand.Next(256);
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (incrNbLines > heightLine || incrNbLines == 1)
                    {
                        a = rand.Next(256);
                        r = rand.Next(256);
                        g = rand.Next(256);
                        b = rand.Next(256);
                        incrNbLines = 1;
                    }
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        bitmap.SetPixel(y, x, Color.FromArgb(a, r, g, b));
                    }
                    incrNbLines++;
                }
            }
            return bitmap;
        }

        public static Bitmap NegativeImage(Bitmap bitmap)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmapProcessed.GetPixel(x, y).R;
                    g = bitmapProcessed.GetPixel(x, y).G;
                    b = bitmapProcessed.GetPixel(x, y).B;
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(255 - r, 255 - g, 255 - b));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap GrayImage(Bitmap bitmap)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            int luminance = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmapProcessed.GetPixel(x, y).R;
                    g = bitmapProcessed.GetPixel(x, y).G;
                    b = bitmapProcessed.GetPixel(x, y).B;
                    luminance = (int)(0.3 * r + 0.6 * g + 0.1 * b);
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(luminance, luminance, luminance));
                }
            }
            return bitmapProcessed;
        }
        public static Bitmap FlipImageHorizontally(Bitmap bitmap)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmap.GetPixel(x, y).R;
                    g = bitmap.GetPixel(x, y).G;
                    b = bitmap.GetPixel(x, y).B;
                    bitmapProcessed.SetPixel(x, (bitmapProcessed.Height - 1) - y, Color.FromArgb(r, g, b));
                }
            }
            return bitmapProcessed;
        }
        public static Bitmap FlipImageVertically(Bitmap bitmap)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmap.GetPixel(x, y).R;
                    g = bitmap.GetPixel(x, y).G;
                    b = bitmap.GetPixel(x, y).B;
                    bitmapProcessed.SetPixel((bitmapProcessed.Width - 1) - x, y, Color.FromArgb(r, g, b));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap FilterColors(Bitmap bitmap, int red, int green, int blue)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmapProcessed.GetPixel(x, y).R;
                    g = bitmapProcessed.GetPixel(x, y).G;
                    b = bitmapProcessed.GetPixel(x, y).B;
                    colorRed = red >= 0 ? red : r;
                    colorGreen = green >= 0 ? green : g;
                    colorBlue = blue >= 0 ? blue : b;
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(colorRed, colorGreen, colorBlue));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap Brightness(Bitmap bitmap, int brightness)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmapProcessed.GetPixel(x, y).R;
                    g = bitmapProcessed.GetPixel(x, y).G;
                    b = bitmapProcessed.GetPixel(x, y).B;
                    colorRed = (int)Truncate(r + brightness);
                    colorGreen = (int)Truncate(g + brightness);
                    colorBlue = (int)Truncate(b + brightness); ;
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(colorRed, colorGreen, colorBlue));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap Contrast(Bitmap bitmap, int contrast)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int r = 0;
            int g = 0;
            int b = 0;
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            float factor = (259 * ((float)contrast + 255)) / (255 * (259 - contrast));
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    r = bitmapProcessed.GetPixel(x, y).R;
                    g = bitmapProcessed.GetPixel(x, y).G;
                    b = bitmapProcessed.GetPixel(x, y).B;
                    colorRed = (int)Truncate(factor * (r - 128) + 128);
                    colorGreen = (int)Truncate(factor * (g - 128) + 128);
                    colorBlue = (int)Truncate(factor * (b - 128) + 128);
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(colorRed, colorGreen, colorBlue));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap MedianFilter(Bitmap bitmap, int size)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int tabSize = (size * 2 + 1) * (size * 2 + 1);
            int[] r = new int[tabSize];
            int[] g = new int[tabSize];
            int[] b = new int[tabSize];
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            int cpt = 0;
            int medianR = 0;
            int medianG = 0;
            int medianB = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    if(x >= size && x <=bitmap.Width - 1 - size && y >= size && y <= bitmap.Height - 1 - size)
                    {
                        for(int x1 = -size; x1 <= size; x1++)
                        {
                            for (int y1 = -size; y1 <= size; y1++)
                            {
                                r[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).R;
                                g[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).G;
                                b[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).B;
                                cpt++;
                            }
                        }
                        for(int i = 0; i < r.GetLength(0); i++)
                        {
                            medianR += r[i];
                            medianG += g[i];
                            medianB += b[i];
                        }
                        medianR /= r.GetLength(0);
                        medianG /= g.GetLength(0);
                        medianB /= b.GetLength(0);

                        colorRed = medianR;
                        colorGreen = medianG;
                        colorBlue = medianB;
                    }
                    else
                    {
                        colorRed = bitmapProcessed.GetPixel(x, y).R;
                        colorGreen = bitmapProcessed.GetPixel(x, y).G;
                        colorBlue = bitmapProcessed.GetPixel(x, y).B;
                    }
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(colorRed, colorGreen, colorBlue));
                    cpt = 0;
                    medianR = 0;
                    medianG = 0;
                    medianB = 0;
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap GaussianFilter(Bitmap bitmap, int size)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            int tabSize = (size * 2 + 1) * (size * 2 + 1);
            int[] r = new int[tabSize];
            int[] g = new int[tabSize];
            int[] b = new int[tabSize];
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            int cpt = 0;
            int medianR = 0;
            int medianG = 0;
            int medianB = 0;
            double exponential = 0;
            for (int x = 0; x < bitmapProcessed.Width; x++)
            {
                for (int y = 0; y < bitmapProcessed.Height; y++)
                {
                    if(x >= size && x <=bitmap.Width - 1 - size && y >= size && y <= bitmap.Height - 1 - size)
                    {
                        for(int x1 = -size; x1 <= size; x1++)
                        {
                            for (int y1 = -size; y1 <= size; y1++)
                            {
                                exponential = Math.Exp((double)(-(x1 * x1 + y1 * y1) / 4));
                                r[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).R * (int)exponential;
                                g[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).G * (int)exponential;
                                b[cpt] =  bitmapProcessed.GetPixel(x + x1, y + y1).B * (int)exponential;
                                cpt++;
                            }
                        }
                        for(int i = 0; i < r.GetLength(0); i++)
                        {
                            medianR += r[i];
                            medianG += g[i];
                            medianB += b[i];
                        }
                        medianR /= r.GetLength(0);
                        medianG /= g.GetLength(0);
                        medianB /= b.GetLength(0);

                        colorRed = medianR;
                        colorGreen = medianG;
                        colorBlue = medianB;
                    }
                    else
                    {
                        colorRed = bitmapProcessed.GetPixel(x, y).R;
                        colorGreen = bitmapProcessed.GetPixel(x, y).G;
                        colorBlue = bitmapProcessed.GetPixel(x, y).B;
                    }
                    bitmapProcessed.SetPixel(x, y, Color.FromArgb(colorRed, colorGreen, colorBlue));
                    cpt = 0;
                    medianR = 0;
                    medianG = 0;
                    medianB = 0;
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap OutlineColor(Bitmap bitmap, int size, int sizeOutline)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            Bitmap bitmapTemp = new Bitmap(bitmapProcessed);
            int tabSize = (size * 2 + 1) * (size * 2 + 1);
            int[] r = new int[tabSize];
            int[] g = new int[tabSize];
            int[] b = new int[tabSize];
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            int colorRedFilter = 0;
            int colorGreenFilter = 0;
            int colorBlueFilter = 0;
            int cpt = 0;
            int medianR = 0;
            int medianG = 0;
            int medianB = 0;
            int colorOutlineRed = 0;
            int colorOutlineGreen = 0;
            int colorOutlineBlue = 0;
            for (int x = 0; x < bitmapTemp.Width; x++)
            {
                for (int y = 0; y < bitmapTemp.Height; y++)
                {
                    if (x >= size && x <= bitmap.Width - 1 - size && y >= size && y <= bitmap.Height - 1 - size)
                    {
                        for (int x1 = -size; x1 <= size; x1++)
                        {
                            for (int y1 = -size; y1 <= size; y1++)
                            {
                                r[cpt] = bitmapTemp.GetPixel(x + x1, y + y1).R;
                                g[cpt] = bitmapTemp.GetPixel(x + x1, y + y1).G;
                                b[cpt] = bitmapTemp.GetPixel(x + x1, y + y1).B;
                                cpt++;
                            }
                        }
                        for (int i = 0; i < r.GetLength(0); i++)
                        {
                            medianR += r[i];
                            medianG += g[i];
                            medianB += b[i];
                        }
                        medianR /= r.GetLength(0);
                        medianG /= g.GetLength(0);
                        medianB /= b.GetLength(0);

                        colorRedFilter = medianR;
                        colorGreenFilter = medianG;
                        colorBlueFilter = medianB;
                    }
                    else
                    {
                        colorRedFilter = bitmapTemp.GetPixel(x, y).R;
                        colorGreenFilter = bitmapTemp.GetPixel(x, y).G;
                        colorBlueFilter = bitmapTemp.GetPixel(x, y).B;
                    }
                    bitmapTemp.SetPixel(x, y, Color.FromArgb(colorRedFilter, colorGreenFilter, colorBlueFilter));
                    cpt = 0;
                    medianR = 0;
                    medianG = 0;
                    medianB = 0;
                }
            }
            for (int j = 0; j < bitmapTemp.Width; j++)
            {
                for (int k = 0; k < bitmapTemp.Height; k++)
                {
                    colorRedFilter = bitmap.GetPixel(j, k).R;
                    colorGreenFilter = bitmap.GetPixel(j, k).G;
                    colorBlueFilter = bitmap.GetPixel(j, k).B;
                    colorOutlineRed = bitmapTemp.GetPixel(j, k).R;
                    colorOutlineGreen = bitmapTemp.GetPixel(j, k).G;
                    colorOutlineBlue = bitmapTemp.GetPixel(j, k).B;
                    if ((colorRedFilter - colorOutlineRed) < sizeOutline)
                    {
                        colorRed = 0;
                    }
                    else
                    {
                        colorRed = 255;
                    }
                    if ((colorGreenFilter - colorOutlineGreen) < sizeOutline)
                    {
                        colorGreen = 0;
                    }
                    else
                    {
                        colorGreen = 255;
                    }
                    if ((colorBlueFilter - colorOutlineBlue) < sizeOutline)
                    {
                        colorBlue = 0;
                    }
                    else
                    {
                        colorBlue = 255;
                    }
                    bitmapProcessed.SetPixel(j, k, Color.FromArgb(colorRed, colorGreen, colorBlue));
                }
            }
            return bitmapProcessed;
        }

        public static Bitmap OutlineGray(Bitmap bitmap, int size, int sizeOutline)
        {
            Bitmap bitmapProcessed = new Bitmap(bitmap);
            Bitmap bitmapTemp = new Bitmap(bitmapProcessed);
            int tabSize = (size * 2 + 1) * (size * 2 + 1);
            int[] rgb = new int[tabSize];
            int colorRed = 0;
            int colorGreen = 0;
            int colorBlue = 0;
            int colorRedFilter = 0;
            int colorGreenFilter = 0;
            int colorBlueFilter = 0;
            int cpt = 0;
            int median = 0;
            int colorOutline = 0;

            for (int x = 0; x < bitmapTemp.Width; x++)
            {
                for (int y = 0; y < bitmapTemp.Height; y++)
                {
                    if (x >= size && x <= bitmap.Width - 1 - size && y >= size && y <= bitmap.Height - 1 - size)
                    {
                        for (int x1 = -size; x1 <= size; x1++)
                        {
                            for (int y1 = -size; y1 <= size; y1++)
                            {
                                rgb[cpt] = bitmapTemp.GetPixel(x + x1, y + y1).R;
                                cpt++;
                            }
                        }
                        for (int i = 0; i < rgb.GetLength(0); i++)
                        {
                            median += rgb[i];
                        }
                        median /= rgb.GetLength(0);

                        colorRedFilter = median;
                        colorGreenFilter = median;
                        colorBlueFilter = median;
                    }
                    else
                    {
                        colorRedFilter = bitmapTemp.GetPixel(x, y).R;
                        colorGreenFilter = bitmapTemp.GetPixel(x, y).G;
                        colorBlueFilter = bitmapTemp.GetPixel(x, y).B;
                    }
                    bitmapTemp.SetPixel(x, y, Color.FromArgb(colorRedFilter, colorGreenFilter, colorBlueFilter));
                    cpt = 0;
                    median = 0;
                }
            }
            for (int j = 0; j < bitmapTemp.Width; j++)
            {
                for (int k = 0; k < bitmapTemp.Height; k++)
                {
                    colorRedFilter = bitmap.GetPixel(j, k).R;
                    colorOutline = bitmapTemp.GetPixel(j, k).R;
                    if ((colorRedFilter - colorOutline) < sizeOutline)
                    {
                        colorRed = 0;
                    }
                    else
                    {
                        colorRed = 255;
                    }
                    colorGreen = colorRed;
                    colorBlue = colorRed;
                    bitmapProcessed.SetPixel(j, k, Color.FromArgb(colorRed, colorGreen, colorBlue));
                }
            }
            return bitmapProcessed;
        }

        private static float Truncate(float value)
        {
            if (value < 0)
                value = 0;
            if (value > 255)
                value = 255;
            return value;
        }
    }
}
