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
    public partial class textSettings : BlinkForm
    {
        public textSettings(MainForm form)
        {
            InitializeComponent();

            mainForm = form;
            blinkLabel2.Text = FontString(fontDialog1.Font);
        }

        MainForm mainForm;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void textSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fontDialog1.Color = colorDialog1.Color;
            
        }

        private string FontString(Font font)
        {
            return $"{font.Name}, {font.SizeInPoints}pt, {(font.Bold ? "Bold" : "Normal")}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
            mainForm.pictureBox1.Invalidate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Color b = pictureBox2.BackColor;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Set Text Color", new Font("Microsoft Sans Serif", 9f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 3, 3);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void label4_SizeChanged(object sender, EventArgs e)
        {
            //checkBox2.Left = label4.Right + 10;
        }

        private void textSettings_Move(object sender, EventArgs e)
        {
            
        }

        private void textSettings_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                mainForm.ModularWindowsVisible = false;
            }
        }

        private void textSettings_Deactivate(object sender, EventArgs e)
        {
            mainForm.ModularWindowsVisible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verticalOffset.Value = 0;
            mainForm.pictureBox1.Invalidate();
        }

        private void blinkButton1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            blinkLabel2.Text = FontString(fontDialog1.Font);

            mainForm.pictureBox1.Invalidate();
        }

        private void blinkSlider1_OnValueChanged(object sender, EventArgs args)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void blinkButton2_Click(object sender, EventArgs e)
        {
            verticalOffset.Value = 0;
        }
    }
}
