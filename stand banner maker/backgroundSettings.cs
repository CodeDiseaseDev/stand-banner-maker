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
    public partial class backgroundSettings : BlinkForm
    {
        public backgroundSettings(MainForm form)
        {
            InitializeComponent();

            mainForm = form;
        }

        private MainForm mainForm;

        Bitmap downSize(Bitmap bmp)
        {
            Bitmap bmp2 = new Bitmap(mainForm.pictureBox1.Width, mainForm.pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp2))
            {
                g.DrawImage(bmp, 0, 0, bmp2.Width, bmp2.Height);
            }

            return bmp2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files|*.png|All files|*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.background = downSize(new Bitmap(openFileDialog.FileName));
                pictureBox1.Image = mainForm.background;
                mainForm.pictureBox1.Invalidate();
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Color b = pictureBox2.BackColor;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Set Solid Background", new Font("Microsoft Sans Serif", 8f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 4,4);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Color b = pictureBox1.BackColor;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, b)), 0, 0, pictureBox1.Width, pictureBox1.Height);

            e.Graphics.DrawString("Click to set background image", new Font("Microsoft Sans Serif", 8f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 3, 3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;

            mainForm.backgroundColor = colorDialog1.Color;

            mainForm.pictureBox1.Invalidate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void backgroundSettings_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                mainForm.ModularWindowsVisible = false;
            }
        }

        private void backgroundSettings_Deactivate(object sender, EventArgs e)
        {
            mainForm.ModularWindowsVisible = false;
        }

        private void backgroundSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            e.Cancel = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_Load(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_MouseUp(object sender, MouseEventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void blinkSlider1_OnValueChanged(object sender, EventArgs args)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void backgroundImageEnabled_Load(object sender, EventArgs e)
        {
        }

        private void gaussianBlur_Load(object sender, EventArgs e)
        {
        }

        private void backgroundImageEnabled_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void gaussianBlur_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void gaussianBlur_MouseUp(object sender, MouseEventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void backgroundImageEnabled_MouseUp(object sender, MouseEventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }
    }
}
