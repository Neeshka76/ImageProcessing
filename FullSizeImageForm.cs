using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class FullSizeImageForm : Form
    {
        Bitmap imageToGetCoordinate;
        public FullSizeImageForm()
        {
            InitializeComponent();
        }
        public PictureBox ImageFullSize
        {
            set { this.pictureBoxFullImage = value; }
            get { return this.pictureBoxFullImage; }
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

        private void pictureBoxFullImage_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayToolTip(pictureBoxFullImage, e.X, e.Y);
        }
    }
}
