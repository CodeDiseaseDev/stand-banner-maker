﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stand_banner_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            textSettings = new textSettings(this);
            shadowSettings = new shadowSettings(this);
            backgroundSettings = new backgroundSettings(this);

            textSettings.Show();
            shadowSettings.Show();
            backgroundSettings.Show();

            InitializeComponent();

            //SpiralAnimation();
        }


        

        public Color backgroundColor = Color.Magenta;
        public Image background;
        public Bitmap resultImage;

        public shadowSettings shadowSettings;
        public textSettings textSettings;
        public backgroundSettings backgroundSettings;

        void SetLocationCentered(Point point)
        {
            Location = new Point(point.X - (Width / 2), point.Y - (Height / 2));
        }

        async void SpiralAnimation()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            PointF ArchimedeanPoint(int degrees)
            {
                const double a = 1;
                const double b = 9;

                double t = degrees * Math.PI / 180;
                double r = a + b * t;

                return new PointF
                {
                    X = (float)(width / 2 + r * Math.Cos(t)),
                    Y = (float)(height / 2 + r * Math.Sin(t))
                };
            }

            for (int i = 360 * 3; i > 0; i -= 20)
            {
                PointF p = ArchimedeanPoint(i);

                SetLocationCentered(new Point((int)p.X, (int)p.Y));

                await Task.Delay(10);
            }
        }

        Size MeasureText(string text, Font font)
        {
            SizeF result;
            using (var image = new Bitmap(1, 1))
                using (var g = Graphics.FromImage(image))
                    result = g.MeasureString(text, font);

            return result.ToSize();
        }

        Bitmap RenderText(string text, Font font, Color color, Size size, int blur = 0)
        {
            Size textSize = MeasureText(text, font);
            Bitmap bmp = new Bitmap(size.Width, size.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = textSettings.checkBox2.Checked ? TextRenderingHint.ClearTypeGridFit : TextRenderingHint.AntiAlias;

                Point textLoc = new Point(
                    (size.Width / 2) - (textSize.Width / 2),
                    (size.Height / 2) - (textSize.Height / 2)
                );

                g.DrawString(text, font, new SolidBrush(color), textLoc);
            }


            if (blur > 0)
            {
                var gb = new GaussianBlur(bmp);
                bmp = gb.Process(blur);
            }

            return bmp;
        }

        void Shadow(Graphics graphics, string text, Font font)
        {
            if (shadowSettings.checkBox1.Checked)
            {
                int distance = shadowSettings.distance.Value;
                Color shadowColor = shadowSettings.colorDialog1.Color;
                int alpha = shadowSettings.intensity.Value;

                Color shadowColorAlpha = Color.FromArgb(alpha, shadowColor);

                Bitmap shadow = RenderText(
                    text, font,
                    shadowColorAlpha,
                    pictureBox1.ClientSize,
                    shadowSettings.radius.Value
                );

                graphics.DrawImage(shadow, distance, distance);
            }
        }

        void Debug(Graphics graphics, Point textLoc, Size size)
        {
            if (dbgmode.Checked)
            {
                int smallSize = 5;
                Pen pen = Pens.Red;
                Pen penSmall = new Pen(Color.Red, 3);

                graphics.DrawRectangle(penSmall, textLoc.X, textLoc.Y, smallSize, smallSize);
                graphics.DrawRectangle(penSmall, textLoc.X, textLoc.Y + size.Height - smallSize, smallSize, smallSize);
                graphics.DrawRectangle(penSmall, textLoc.X + size.Width - smallSize, textLoc.Y, smallSize, smallSize);
                graphics.DrawRectangle(penSmall, textLoc.X + size.Width - smallSize, textLoc.Y + (int)size.Height - smallSize, smallSize, smallSize);

                graphics.DrawRectangle(pen, textLoc.X, textLoc.Y, size.Width, size.Height);
            }
        }

        void Background(Graphics graphics)
        {
            graphics.Clear(backgroundColor);

            if (background != null && backgroundSettings.checkBox1.Checked)
            {
                Bitmap bmp = (Bitmap)background.Clone();

                if (backgroundSettings.checkBox2.Checked)
                {
                    var gb = new GaussianBlur(bmp);
                    bmp = gb.Process(5);
                }

                graphics.DrawImage(bmp, 0, 0, pictureBox1.Width + 2, pictureBox1.Height);
            }
        }

        void Foreground(Graphics graphics)
        {
            Font font = textSettings.fontDialog1.Font;
            string text = textSettings.textBox1.Text;

            var size = graphics.MeasureString(text, font);
            Point textLoc = new Point(
                (pictureBox1.ClientSize.Width / 2) - (int)(size.Width / 2),
                (pictureBox1.ClientSize.Height / 2) - (int)(size.Height / 2)
            );

            Bitmap txt = RenderText(
                text, font,
                textSettings.colorDialog1.Color,
                pictureBox1.ClientSize
            );

            Shadow(graphics, text, font);
            graphics.DrawImage(txt, 0, 0);

            Debug(graphics, textLoc, size.ToSize());
        }

        private void Render(Graphics graphics)
        {
            Background(graphics);

            Foreground(graphics);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            resultImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics graphics = Graphics.FromImage(resultImage))
            {
                Render(graphics);
                e.Graphics.DrawImage(resultImage, 0, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            backgroundColor = colorDialog1.Color;
            //pictureBox2.BackColor = backgroundColor;

            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG image|*.png|JPG image|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                background = new Bitmap(dialog.FileName);

                pictureBox1.Invalidate();
            }
        }

        private void niceFontButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG image|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        private void dbgmode_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void niceFontButton2_Click(object sender, EventArgs e)
        {
            if (!shadowSettings.Visible)
            {
                shadowSettings.Show();
                shadowSettings.BringToFront();
                shadowSettings.Top = textSettings.Bottom;
                shadowSettings.Left = Right;
            }
            else
            {
                shadowSettings.Hide();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();

            textSettings.WindowState = WindowState;
            shadowSettings.WindowState = WindowState;
            backgroundSettings.WindowState = WindowState;

            

            if (WindowState != FormWindowState.Minimized)
            {
                textSettings.Left = Right;
                textSettings.Top = Top;

                shadowSettings.Top = textSettings.Bottom;
                shadowSettings.Left = Right;

                backgroundSettings.Left = Left - backgroundSettings.Width;
                backgroundSettings.Top = Top;
            }
        }

        private void niceFontButton3_Click(object sender, EventArgs e)
        {
            if (!textSettings.Visible)
            {
                textSettings.Show();
                textSettings.BringToFront();
                textSettings.Left = Right;
                textSettings.Top = Top;
            }
            else
            {
                textSettings.Hide();
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            textSettings.Left = Right;
            textSettings.Top = Top;

            shadowSettings.Top = textSettings.Bottom;
            shadowSettings.Left = Right;

            backgroundSettings.Left = Left - backgroundSettings.Width;
            backgroundSettings.Top = Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundSettings.Visible)
            {
                backgroundSettings.Show();
                backgroundSettings.BringToFront();
                backgroundSettings.Left = Left - backgroundSettings.Width;
                backgroundSettings.Top = Top;
            }
            else
            {
                backgroundSettings.Hide();
            }
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        public bool ModularWindowsVisible = true;

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (ModularWindowsVisible)
                return;

            textSettings.BringToFront();
            shadowSettings.BringToFront();
            backgroundSettings.BringToFront();

            ModularWindowsVisible = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            
        }
    }
}
