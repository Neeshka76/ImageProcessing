using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ImageProcessingForm : Form
    {
        public ImageProcessingForm()
        {
            InitializeComponent();
        }

        public Bitmap picOriLoaded = new Bitmap(1, 1);
        public Bitmap picOriProcessed = new Bitmap(1, 1);
        public Size displaySize = new Size(500, 500);
        ToolTip toolTip1 = new ToolTip();
        Bitmap imageToGetCoordinate;
        ProcessingCommandForm processingCommandForm = new ProcessingCommandForm();
        FullSizeImageForm fullSizeImageForm = new FullSizeImageForm();
        private void ImageProcessingForm_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Active = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayToolTip(pictureBox1, e.X, e.Y);
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayToolTip(pictureBox2, e.X, e.Y);
        }

        private void DisplayToolTip(PictureBox pictureBox, int XCoord, int YCoord)
        {
            if (toolTip1.Active == false)
                toolTip1.Active = true;

            if (imageToGetCoordinate == null || imageToGetCoordinate != (Bitmap)pictureBox.Image)
            {
                imageToGetCoordinate = (Bitmap)pictureBox.Image;
            }
            else
            {
                int rValue, gValue, bValue;
                if (XCoord >= 0 && XCoord < imageToGetCoordinate.Width && YCoord >= 0 && YCoord < imageToGetCoordinate.Height)
                {
                    rValue = imageToGetCoordinate.GetPixel(XCoord, YCoord).R;
                    gValue = imageToGetCoordinate.GetPixel(XCoord, YCoord).G;
                    bValue = imageToGetCoordinate.GetPixel(XCoord, YCoord).B;
                    toolTip1?.Show("X : " + XCoord + "; Y : " + YCoord + ";" + Environment.NewLine +
                        "R : " + rValue.ToString() + "; G : " + gValue.ToString() + "; B : " + bValue.ToString() + ";", pictureBox, XCoord + 5, YCoord - 35);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImageFullSize(picOriLoaded);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ImageFullSize(picOriProcessed);
        }
        private void SelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.bmp; *.png; *.jpg) | *.bmp; *.png; *.jpg";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                Bitmap imageLoaded = new Bitmap(openFile.FileName);
                picOriLoaded = imageLoaded;
                Bitmap imageResized = Processing.ResizeImageForPreview(imageLoaded, displaySize);
                if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
                {
                    pictureBox1.Size = displaySize;
                }
                else
                {
                    pictureBox1.Size = imageResized.Size;
                }
                pictureBox1.Image = imageResized;
            }
        }
        private void SavePic_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "BMP (*.bmp) |*.bmp|JPEG (*.jpg;*.jpeg)|*jpg;*.jpeg|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*tiff|PNG (*.png)|*.png";
            //saveFile.Filter = "Image File (*.bmp; *.png; *.jpg) | *.bmp; *.png; *.jpg";
            saveFile.FilterIndex = 5;
            ImageFormat imageFormat = ImageFormat.Png;
            if (DialogResult.OK == saveFile.ShowDialog())
            {
                switch (saveFile.FilterIndex)
                {
                    //BMP
                    case 1 :
                        imageFormat = ImageFormat.Bmp;
                        break;
                    //JPEG
                    case 2:
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    //GIF
                    case 3 :
                        imageFormat = ImageFormat.Gif;
                        break;
                    //TIFF
                    case 4:
                        imageFormat = ImageFormat.Tiff;
                        break;
                    //PNG
                    case 5 :
                        imageFormat = ImageFormat.Png;
                        break;
                }
                picOriProcessed.Save(saveFile.FileName, imageFormat);
            }
        }
        private void ImageFullSize(Bitmap picture)
        { 
            fullSizeImageForm.ImageFullSize.Image = picture;
            fullSizeImageForm.ShowDialog();
        }

        public void DrawLines(int widthPic, int heightPic, bool lines)
        {
            pictureBox1.Size = new Size(widthPic, heightPic);
            Bitmap bitmap = new Bitmap(widthPic, heightPic);
            Random rand = new Random();
            bitmap = Processing.DrawLines(bitmap, rand.Next(1, 50), lines);
            pictureBox1.Image = bitmap;
            picOriLoaded = bitmap;
        }
        public void Draw(int choice, int widthPic, int heightPic)
        {
            pictureBox1.Size = new Size(widthPic, heightPic);
            Bitmap bitmap = new Bitmap(widthPic, heightPic);
            Random rand = new Random();
            switch (choice)
            {
                // Fill it in a Random Color
                case 1:
                    bitmap = Processing.DrawRandFull(bitmap);
                    break;
                // Random Color for each pixels
                case 2:
                    bitmap = Processing.DrawRandPixel(bitmap);
                    break;
                // Draw random lines
                case 3:
                    bitmap = Processing.DrawLines(bitmap, rand.Next(2, 51), false);
                    break;
            }
            pictureBox1.Image = bitmap;
            picOriLoaded = bitmap;
        }
        public void NegativeImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.NegativeImage(picOriProcessed);
            }
            else
            {
                picOriProcessed = Processing.NegativeImage(picOriLoaded);
            }
            
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }
        public void GrayImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.GrayImage(picOriProcessed);
            }
            else
            {
                picOriProcessed = Processing.GrayImage(picOriLoaded);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }
        private void FlipImage(bool horizontal)
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                if(horizontal == true)
                {
                    picOriProcessed = Processing.FlipImageHorizontally(picOriProcessed);
                }
                else
                {
                    picOriProcessed = Processing.FlipImageVertically(picOriProcessed);
                }
            }
            else
            {
                if (horizontal == true)
                {
                    picOriProcessed = Processing.FlipImageHorizontally(picOriLoaded);
                }
                else
                {
                    picOriProcessed = Processing.FlipImageVertically(picOriLoaded);
                }
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        public void BrightnessImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.Brightness(picOriProcessed, ProcessingCommandForm.brightness);
            }
            else
            {
                picOriProcessed = Processing.Brightness(picOriLoaded, ProcessingCommandForm.brightness);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        public void ContrastImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.Contrast(picOriProcessed, ProcessingCommandForm.contrast);
            }
            else
            {
                picOriProcessed = Processing.Contrast(picOriLoaded, ProcessingCommandForm.contrast);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        public void FilterColorImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.FilterColors(picOriProcessed, ProcessingCommandForm.colorRed, ProcessingCommandForm.colorGreen, ProcessingCommandForm.colorBlue);
            }
            else
            {
                picOriProcessed = Processing.FilterColors(picOriLoaded, ProcessingCommandForm.colorRed, ProcessingCommandForm.colorGreen, ProcessingCommandForm.colorBlue);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        public void MedianFilterImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.MedianFilter(picOriProcessed, 1);
            }
            else
            {
                picOriProcessed = Processing.MedianFilter(picOriLoaded, 1);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }
        
        public void GaussianFilterImage()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.GaussianFilter(picOriProcessed, 1);
            }
            else
            {
                picOriProcessed = Processing.GaussianFilter(picOriLoaded, 1);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        public void OutLineImageColor()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.OutlineColor(picOriProcessed, 1, 8);
            }
            else
            {
                picOriProcessed = Processing.OutlineColor(picOriLoaded, 1, 8);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }
        public void OutLineImageGray()
        {
            Bitmap imageResized = new Bitmap(picOriLoaded);
            if (pictureBox2.Image != null && chkBoxCumulateProcessing.Checked == true)
            {
                picOriProcessed = Processing.OutlineGray(picOriProcessed, 1, 8);
            }
            else
            {
                picOriProcessed = Processing.OutlineGray(picOriLoaded, 1, 8);
            }
            imageResized = Processing.ResizeImageForPreview(picOriProcessed, displaySize);
            if (displaySize.Width < imageResized.Width || displaySize.Height < imageResized.Height)
            {
                pictureBox2.Size = displaySize;
            }
            else
            {
                pictureBox2.Size = imageResized.Size;
            }
            pictureBox2.Image = imageResized;
        }

        private void x300x300ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw(1, 300, 300);
        }
        private void x500x300ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw(1, displaySize.Width, 300);
        }
        private void x300x500ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Draw(1, 300, displaySize.Height);
        }
        private void x500x500ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Draw(1, displaySize.Width, displaySize.Height);
        }
        private void randomSizeWithRandomColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Draw(2, rand.Next(300, 501), rand.Next(300, 501));
        }
        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawLines(displaySize.Width, displaySize.Height, false);
        }
        private void columnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawLines(displaySize.Width, displaySize.Height, true);
        }
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                NegativeImage();
            }

        }
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                GrayImage();
            }
        }
        private void horizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlipImage(true);
        }

        private void verticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlipImage(false);
        }

        private void filterColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processingCommandForm.ShowDialog();
            if (ProcessingCommandForm.confirm)
            {
                FilterColorImage();
                ProcessingCommandForm.confirm = false;
            }
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processingCommandForm.ShowDialog();
            if (ProcessingCommandForm.confirm)
            {
                BrightnessImage();
                ProcessingCommandForm.confirm = false;
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processingCommandForm.ShowDialog();
            if (ProcessingCommandForm.confirm)
            {
                ContrastImage();
                ProcessingCommandForm.confirm = false;
            }
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilterImage();
        }

        private void gaussianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianFilterImage();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutLineImageColor();
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutLineImageGray();
        }
    }
}
