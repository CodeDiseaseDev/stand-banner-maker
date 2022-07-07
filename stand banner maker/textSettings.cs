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
    public partial class textSettings : Form
    {
        public textSettings(Form1 form)
        {
            InitializeComponent();

            mainForm = form;
            label4.Text = FontString(fontDialog1.Font);
        }

        Form1 mainForm;

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
            fontDialog1.ShowDialog();

            label4.Text = FontString(fontDialog1.Font);

            mainForm.pictureBox1.Invalidate();
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
            e.Graphics.DrawString("Click to set", new Font("Microsoft Sans Serif", 7f), new SolidBrush(Color.FromArgb(255 - b.R, 255 - b.G, 255 - b.B)), 2, 1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.pictureBox1.Invalidate();
        }

        private void label4_SizeChanged(object sender, EventArgs e)
        {
            checkBox2.Left = label4.Right + 10;
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
    }
}
