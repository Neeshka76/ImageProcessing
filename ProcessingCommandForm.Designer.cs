
namespace ImageProcessing
{
    partial class ProcessingCommandForm
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
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textValueRed = new System.Windows.Forms.TextBox();
            this.textValueGreen = new System.Windows.Forms.TextBox();
            this.textValueBlue = new System.Windows.Forms.TextBox();
            this.textValueBrightness = new System.Windows.Forms.TextBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.textValueContrast = new System.Windows.Forms.TextBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.checkBoxBrightness = new System.Windows.Forms.CheckBox();
            this.checkBoxContrast = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.Location = new System.Drawing.Point(39, 50);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(46, 19);
            this.checkBoxRed.TabIndex = 0;
            this.checkBoxRed.Text = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            this.checkBoxRed.CheckedChanged += new System.EventHandler(this.checkBoxRed_CheckedChanged);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Location = new System.Drawing.Point(39, 101);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(57, 19);
            this.checkBoxGreen.TabIndex = 1;
            this.checkBoxGreen.Text = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            this.checkBoxGreen.CheckedChanged += new System.EventHandler(this.checkBoxGreen_CheckedChanged);
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Location = new System.Drawing.Point(39, 152);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(49, 19);
            this.checkBoxBlue.TabIndex = 2;
            this.checkBoxBlue.Text = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            this.checkBoxBlue.CheckedChanged += new System.EventHandler(this.checkBoxBlue_CheckedChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Enabled = false;
            this.trackBarRed.Location = new System.Drawing.Point(151, 50);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 3;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBarRed_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Enabled = false;
            this.trackBarGreen.Location = new System.Drawing.Point(151, 101);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 4;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBarGreen_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Enabled = false;
            this.trackBarBlue.Location = new System.Drawing.Point(151, 152);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBarBlue_ValueChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(61, 314);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(93, 37);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(232, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 37);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // textValueRed
            // 
            this.textValueRed.Enabled = false;
            this.textValueRed.Location = new System.Drawing.Point(252, 50);
            this.textValueRed.Name = "textValueRed";
            this.textValueRed.Size = new System.Drawing.Size(29, 23);
            this.textValueRed.TabIndex = 8;
            this.textValueRed.Text = "0";
            this.textValueRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValueRed_KeyDown);
            // 
            // textValueGreen
            // 
            this.textValueGreen.Enabled = false;
            this.textValueGreen.Location = new System.Drawing.Point(252, 101);
            this.textValueGreen.Name = "textValueGreen";
            this.textValueGreen.Size = new System.Drawing.Size(29, 23);
            this.textValueGreen.TabIndex = 9;
            this.textValueGreen.Text = "0";
            this.textValueGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValueGreen_KeyDown);
            // 
            // textValueBlue
            // 
            this.textValueBlue.Enabled = false;
            this.textValueBlue.Location = new System.Drawing.Point(252, 152);
            this.textValueBlue.Name = "textValueBlue";
            this.textValueBlue.Size = new System.Drawing.Size(29, 23);
            this.textValueBlue.TabIndex = 10;
            this.textValueBlue.Text = "0";
            this.textValueBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValueBlue_KeyDown);
            // 
            // textValueBrightness
            // 
            this.textValueBrightness.Enabled = false;
            this.textValueBrightness.Location = new System.Drawing.Point(252, 203);
            this.textValueBrightness.Name = "textValueBrightness";
            this.textValueBrightness.Size = new System.Drawing.Size(29, 23);
            this.textValueBrightness.TabIndex = 12;
            this.textValueBrightness.Text = "0";
            this.textValueBrightness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValueBrightness_KeyDown);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Enabled = false;
            this.trackBarBrightness.Location = new System.Drawing.Point(151, 203);
            this.trackBarBrightness.Maximum = 255;
            this.trackBarBrightness.Minimum = -255;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(104, 45);
            this.trackBarBrightness.TabIndex = 11;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // textValueContrast
            // 
            this.textValueContrast.Enabled = false;
            this.textValueContrast.Location = new System.Drawing.Point(252, 254);
            this.textValueContrast.Name = "textValueContrast";
            this.textValueContrast.Size = new System.Drawing.Size(29, 23);
            this.textValueContrast.TabIndex = 14;
            this.textValueContrast.Text = "0";
            this.textValueContrast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValueContrast_KeyDown);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Enabled = false;
            this.trackBarContrast.Location = new System.Drawing.Point(151, 254);
            this.trackBarContrast.Maximum = 255;
            this.trackBarContrast.Minimum = -255;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(104, 45);
            this.trackBarContrast.TabIndex = 13;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // checkBoxBrightness
            // 
            this.checkBoxBrightness.AutoSize = true;
            this.checkBoxBrightness.Location = new System.Drawing.Point(39, 203);
            this.checkBoxBrightness.Name = "checkBoxBrightness";
            this.checkBoxBrightness.Size = new System.Drawing.Size(81, 19);
            this.checkBoxBrightness.TabIndex = 15;
            this.checkBoxBrightness.Text = "Brightness";
            this.checkBoxBrightness.UseVisualStyleBackColor = true;
            this.checkBoxBrightness.CheckedChanged += new System.EventHandler(this.checkBoxBrightness_CheckedChanged);
            // 
            // checkBoxContrast
            // 
            this.checkBoxContrast.AutoSize = true;
            this.checkBoxContrast.Location = new System.Drawing.Point(39, 254);
            this.checkBoxContrast.Name = "checkBoxContrast";
            this.checkBoxContrast.Size = new System.Drawing.Size(71, 19);
            this.checkBoxContrast.TabIndex = 16;
            this.checkBoxContrast.Text = "Contrast";
            this.checkBoxContrast.UseVisualStyleBackColor = true;
            this.checkBoxContrast.CheckedChanged += new System.EventHandler(this.checkBoxContrast_CheckedChanged);
            // 
            // ProcessingCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxContrast);
            this.Controls.Add(this.checkBoxBrightness);
            this.Controls.Add(this.textValueContrast);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.textValueBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.textValueBlue);
            this.Controls.Add(this.textValueGreen);
            this.Controls.Add(this.textValueRed);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.checkBoxBlue);
            this.Controls.Add(this.checkBoxGreen);
            this.Controls.Add(this.checkBoxRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessingCommand";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FiltersColors";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textValueRed;
        private System.Windows.Forms.TextBox textValueGreen;
        private System.Windows.Forms.TextBox textValueBlue;
        private System.Windows.Forms.TextBox textValueBrightness;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TextBox textValueContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.CheckBox checkBoxBrightness;
        private System.Windows.Forms.CheckBox checkBoxContrast;
    }
}