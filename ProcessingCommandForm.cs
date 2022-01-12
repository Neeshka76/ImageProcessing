using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ProcessingCommandForm : Form
    {
        public static int colorRed;
        public static int colorGreen;
        public static int colorBlue;
        public static int brightness;
        public static int contrast;
        public static bool confirm = false;
        public ProcessingCommandForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            colorRed = checkBoxRed.Checked ? trackBarRed.Value : -1;
            colorGreen = checkBoxGreen.Checked ? trackBarGreen.Value : -1;
            colorBlue = checkBoxBlue.Checked ? trackBarBlue.Value : -1;
            brightness = checkBoxBrightness.Checked ? trackBarBrightness.Value : 0;
            contrast = checkBoxContrast.Checked ? trackBarContrast.Value : 0;
            confirm = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            colorRed = -1;
            colorGreen = -1;
            colorBlue = -1;
            brightness = 0;
            contrast = 0;
            confirm = false;
            this.Close();
        }

        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRed.Enabled = checkBoxRed.Checked;
            textValueRed.Enabled = checkBoxRed.Checked;
        }

        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            trackBarGreen.Enabled = checkBoxGreen.Checked;
            textValueGreen.Enabled = checkBoxGreen.Checked;
        }

        private void checkBoxBlue_CheckedChanged(object sender, EventArgs e)
        {
            trackBarBlue.Enabled = checkBoxBlue.Checked;
            textValueBlue.Enabled = checkBoxBlue.Checked;
        }

        private void checkBoxBrightness_CheckedChanged(object sender, EventArgs e)
        {
            trackBarBrightness.Enabled = checkBoxBrightness.Checked;
            textValueBrightness.Enabled = checkBoxBrightness.Checked;
        }

        private void checkBoxContrast_CheckedChanged(object sender, EventArgs e)
        {
            trackBarContrast.Enabled = checkBoxContrast.Checked;
            textValueContrast.Enabled = checkBoxContrast.Checked;
        }

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            textValueRed.Text = trackBarRed.Value.ToString();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            textValueGreen.Text = trackBarGreen.Value.ToString();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            textValueBlue.Text = trackBarBlue.Value.ToString();
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            textValueBrightness.Text = trackBarBrightness.Value.ToString();
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            textValueContrast.Text = trackBarContrast.Value.ToString();
        }



        private void textValueRed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textValueBrightness.Text, out int result))
                {
                    trackBarRed.Value = result;
                }
            }
        }

        private void textValueGreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textValueBrightness.Text, out int result))
                {
                    trackBarGreen.Value = result;
                }
            }
        }

        private void textValueBlue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textValueBrightness.Text, out int result))
                {
                    trackBarBlue.Value = result;
                }
            }
        }
        private void textValueBrightness_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textValueBrightness.Text, out int result))
                {
                    trackBarBrightness.Value = result;
                }
            }
        }
        private void textValueContrast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textValueBrightness.Text, out int result))
                {
                    trackBarContrast.Value = result;
                }
            }
        }
    }
}
