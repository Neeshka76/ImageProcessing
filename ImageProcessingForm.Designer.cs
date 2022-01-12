
namespace ImageProcessing
{
    partial class ImageProcessingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillAnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x300x300ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x500x300ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x300x500ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x500x500ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSizeWithRandomColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectPic = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkBoxCumulateProcessing = new System.Windows.Forms.CheckBox();
            this.SavePic = new System.Windows.Forms.Button();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(80, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillAnImageToolStripMenuItem,
            this.processingImageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // fillAnImageToolStripMenuItem
            // 
            this.fillAnImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x300x300ToolStripMenuItem,
            this.x500x300ToolStripMenuItem,
            this.x300x500ToolStripMenuItem1,
            this.x500x500ToolStripMenuItem2,
            this.randomSizeWithRandomColorToolStripMenuItem,
            this.randomLinesToolStripMenuItem});
            this.fillAnImageToolStripMenuItem.Name = "fillAnImageToolStripMenuItem";
            this.fillAnImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fillAnImageToolStripMenuItem.Text = "Fill an image";
            // 
            // x300x300ToolStripMenuItem
            // 
            this.x300x300ToolStripMenuItem.Name = "x300x300ToolStripMenuItem";
            this.x300x300ToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.x300x300ToolStripMenuItem.Text = "300X300";
            this.x300x300ToolStripMenuItem.Click += new System.EventHandler(this.x300x300ToolStripMenuItem_Click);
            // 
            // x500x300ToolStripMenuItem
            // 
            this.x500x300ToolStripMenuItem.Name = "x500x300ToolStripMenuItem";
            this.x500x300ToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.x500x300ToolStripMenuItem.Text = "500X300";
            this.x500x300ToolStripMenuItem.Click += new System.EventHandler(this.x500x300ToolStripMenuItem_Click);
            // 
            // x300x500ToolStripMenuItem1
            // 
            this.x300x500ToolStripMenuItem1.Name = "x300x500ToolStripMenuItem1";
            this.x300x500ToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.x300x500ToolStripMenuItem1.Text = "300X500";
            this.x300x500ToolStripMenuItem1.Click += new System.EventHandler(this.x300x500ToolStripMenuItem1_Click);
            // 
            // x500x500ToolStripMenuItem2
            // 
            this.x500x500ToolStripMenuItem2.Name = "x500x500ToolStripMenuItem2";
            this.x500x500ToolStripMenuItem2.Size = new System.Drawing.Size(238, 22);
            this.x500x500ToolStripMenuItem2.Text = "500X500";
            this.x500x500ToolStripMenuItem2.Click += new System.EventHandler(this.x500x500ToolStripMenuItem2_Click);
            // 
            // randomSizeWithRandomColorToolStripMenuItem
            // 
            this.randomSizeWithRandomColorToolStripMenuItem.Name = "randomSizeWithRandomColorToolStripMenuItem";
            this.randomSizeWithRandomColorToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.randomSizeWithRandomColorToolStripMenuItem.Text = "RandomSizeWithRandomColor";
            this.randomSizeWithRandomColorToolStripMenuItem.Click += new System.EventHandler(this.randomSizeWithRandomColorToolStripMenuItem_Click);
            // 
            // randomLinesToolStripMenuItem
            // 
            this.randomLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linesToolStripMenuItem,
            this.columnsToolStripMenuItem});
            this.randomLinesToolStripMenuItem.Name = "randomLinesToolStripMenuItem";
            this.randomLinesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.randomLinesToolStripMenuItem.Text = "RandomLines";
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            this.columnsToolStripMenuItem.Click += new System.EventHandler(this.columnsToolStripMenuItem_Click);
            // 
            // processingImageToolStripMenuItem
            // 
            this.processingImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativeToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.flipImageToolStripMenuItem,
            this.filterColorsToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.outlineToolStripMenuItem});
            this.processingImageToolStripMenuItem.Name = "processingImageToolStripMenuItem";
            this.processingImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.processingImageToolStripMenuItem.Text = "ProcessingImage";
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // flipImageToolStripMenuItem
            // 
            this.flipImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontallyToolStripMenuItem,
            this.verticallyToolStripMenuItem});
            this.flipImageToolStripMenuItem.Name = "flipImageToolStripMenuItem";
            this.flipImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flipImageToolStripMenuItem.Text = "FlipImage";
            // 
            // horizontallyToolStripMenuItem
            // 
            this.horizontallyToolStripMenuItem.Name = "horizontallyToolStripMenuItem";
            this.horizontallyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.horizontallyToolStripMenuItem.Text = "Horizontally";
            this.horizontallyToolStripMenuItem.Click += new System.EventHandler(this.horizontallyToolStripMenuItem_Click);
            // 
            // verticallyToolStripMenuItem
            // 
            this.verticallyToolStripMenuItem.Name = "verticallyToolStripMenuItem";
            this.verticallyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.verticallyToolStripMenuItem.Text = "Vertically";
            this.verticallyToolStripMenuItem.Click += new System.EventHandler(this.verticallyToolStripMenuItem_Click);
            // 
            // filterColorsToolStripMenuItem
            // 
            this.filterColorsToolStripMenuItem.Name = "filterColorsToolStripMenuItem";
            this.filterColorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterColorsToolStripMenuItem.Text = "FilterColors";
            this.filterColorsToolStripMenuItem.Click += new System.EventHandler(this.filterColorsToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianFilterToolStripMenuItem,
            this.gaussianFilterToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // gaussianFilterToolStripMenuItem
            // 
            this.gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
            this.gaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gaussianFilterToolStripMenuItem.Text = "Gaussian Filter";
            this.gaussianFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussianFilterToolStripMenuItem_Click);
            // 
            // outlineToolStripMenuItem
            // 
            this.outlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.outlineToolStripMenuItem.Name = "outlineToolStripMenuItem";
            this.outlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outlineToolStripMenuItem.Text = "Outline";
            // 
            // SelectPic
            // 
            this.SelectPic.Location = new System.Drawing.Point(80, 42);
            this.SelectPic.Name = "SelectPic";
            this.SelectPic.Size = new System.Drawing.Size(93, 37);
            this.SelectPic.TabIndex = 3;
            this.SelectPic.Text = "Select Picture";
            this.SelectPic.UseVisualStyleBackColor = true;
            this.SelectPic.Click += new System.EventHandler(this.SelectPic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(756, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // chkBoxCumulateProcessing
            // 
            this.chkBoxCumulateProcessing.AutoSize = true;
            this.chkBoxCumulateProcessing.Location = new System.Drawing.Point(756, 52);
            this.chkBoxCumulateProcessing.Name = "chkBoxCumulateProcessing";
            this.chkBoxCumulateProcessing.Size = new System.Drawing.Size(138, 19);
            this.chkBoxCumulateProcessing.TabIndex = 6;
            this.chkBoxCumulateProcessing.Text = "Cumulate Processing";
            this.chkBoxCumulateProcessing.UseVisualStyleBackColor = true;
            // 
            // SavePic
            // 
            this.SavePic.Location = new System.Drawing.Point(964, 42);
            this.SavePic.Name = "SavePic";
            this.SavePic.Size = new System.Drawing.Size(93, 37);
            this.SavePic.TabIndex = 7;
            this.SavePic.Text = "Save Picture";
            this.SavePic.UseVisualStyleBackColor = true;
            this.SavePic.Click += new System.EventHandler(this.SavePic_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 1061);
            this.Controls.Add(this.SavePic);
            this.Controls.Add(this.chkBoxCumulateProcessing);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SelectPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessingForm";
            this.Text = "ImageProcessing";
            this.MouseEnter += new System.EventHandler(this.ImageProcessingForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillAnImageToolStripMenuItem;
        private System.Windows.Forms.Button SelectPic;
        private System.Windows.Forms.ToolStripMenuItem x300x300ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x500x300ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x300x500ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x500x500ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem randomSizeWithRandomColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticallyToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkBoxCumulateProcessing;
        private System.Windows.Forms.Button SavePic;
        private System.Windows.Forms.ToolStripMenuItem filterColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
    }
}

