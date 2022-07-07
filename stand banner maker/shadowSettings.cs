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
    public partial class shadowSettings : Form
    {
        public shadowSettings(Form1 form)
        {
            InitializeComponent();

            this.mainForm = form;

            panel1.Enabled = checkBox1.Checked;

            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = checkBox1.Checked;
        }

        private Form1 mainForm;

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
            e.Graphics.DrawString("Click to set", new Font("Microsoft Sans Serif", 7f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 2, 1);
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
    }
}
