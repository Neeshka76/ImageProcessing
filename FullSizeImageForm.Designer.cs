
namespace ImageProcessing
{
    partial class FullSizeImageForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxFullImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFullImage
            // 
            this.pictureBoxFullImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFullImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFullImage.Name = "pictureBoxFullImage";
            this.pictureBoxFullImage.Size = new System.Drawing.Size(1424, 1385);
            this.pictureBoxFullImage.TabIndex = 0;
            this.pictureBoxFullImage.TabStop = false;
            this.pictureBoxFullImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFullImage_MouseMove);
            // 
            // FullSizeImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1385);
            this.Controls.Add(this.pictureBoxFullImage);
            this.Name = "FullSizeImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullSizeImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFullImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}