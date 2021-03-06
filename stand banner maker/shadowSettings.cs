using Blink_UI_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stand_banner_maker
{
    public partial class shadowSettings : BlinkForm
    {
        public shadowSettings(MainForm form)
        {
            InitializeComponent();

            this.mainForm = form;

            panel1.Enabled = checkBox1.Checked;

            //checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = checkBox1.Checked;
        }

        private MainForm mainForm;

        private void intensity_Scroll(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void distance_Scroll(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void shadowSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;

            mainForm.pictureBox1.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Color b = pictureBox2.BackColor;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Set Shadow Color", new Font("Microsoft Sans Serif", 9f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 3, 3);
        }

        private void radius_Scroll(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void shadowSettings_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                mainForm.ModularWindowsVisible = false;
            }
        }

        private void shadowSettings_Activated(object sender, EventArgs e)
        {

        }

        private void shadowSettings_Deactivate(object sender, EventArgs e)
        {
            mainForm.ModularWindowsVisible = false;
        }

        private void intensity_OnValueChanged(object sender, EventArgs args)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void distance_OnValueChanged(object sender, EventArgs args)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void radius_OnValueChanged(object sender, EventArgs args)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void blinkCheckbox1_MouseUp(object sender, MouseEventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }
    }
}
