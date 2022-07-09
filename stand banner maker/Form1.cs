using Blink_UI_lib;
using stand_banner_maker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stand_banner_maker
{
    public partial class Form1 : BlinkForm
    {
        public Form1()
        {
            textSettings = new textSettings(this);
            shadowSettings = new shadowSettings(this);
            backgroundSettings = new backgroundSettings(this);
            imageSettings = new imageSettings(this);

            textSettings.Show();
            shadowSettings.Show();
            backgroundSettings.Show();
            imageSettings.Show();

            InitializeComponent();
        }

        public Color backgroundColor = Color.FromArgb(200, 200, 200);
        public Image background;
        public Bitmap resultImage;
        public Size ResultImageSize = new Size(736, 247);

        public shadowSettings shadowSettings;
        public textSettings textSettings;
        public backgroundSettings backgroundSettings;
        public imageSettings imageSettings;

        void SetLocationCentered(Point point)
        {
            Location = new Point(point.X - (Width / 2), point.Y - (Height / 2));
        }

        Size MeasureText(string text, Font font)
        {
            using (var image = new Bitmap(1, 1))
            using (var g = Graphics.FromImage(image))
                return g.MeasureString(text, font).ToSize();
        }

        Bitmap RenderText(string text, Font font, Color color, Size size, int blur = 0)
        {
            Size textSize = MeasureText(text, font);
            Bitmap bmp = new Bitmap(size.Width, size.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                int offset = textSettings.verticalOffset.Value;

                Point textLoc = new Point(
                    (size.Width / 2) - (textSize.Width / 2),
                    (size.Height / 2) - (textSize.Height / 2)
                );

                textLoc.Offset(0, offset);

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
                    resultImage.Size,
                    shadowSettings.radius.Value
                );

                graphics.DrawImage(shadow, distance, distance);
            }
        }

        public GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
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
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color color = backgroundSettings.blinkCheckbox1.Checked ? backgroundColor : Color.Transparent;
            int cornerRadius = backgroundSettings.cornerRadius.Value;
            Rectangle rect = new Rectangle(0, 0, resultImage.Width - 1, resultImage.Height - 1);
            var path = RoundedRect(rect, cornerRadius);

            graphics.FillPath(new SolidBrush(color), path);
            graphics.DrawPath(new Pen(color), path); // draw a border line around for better anti-aliasing

            if (background != null && backgroundSettings.backgroundImageEnabled.Checked)
            {
                Bitmap bmp = (Bitmap)background.Clone();

                if (backgroundSettings.gaussianBlur.Checked)
                {
                    var gb = new GaussianBlur(bmp);
                    bmp = gb.Process(8);
                }

                graphics.DrawImage(bmp, 0, 0, resultImage.Width + 2, resultImage.Height);
            }
        }

        void Foreground(Graphics graphics)
        {
            Font font = textSettings.fontDialog1.Font;
            string text = textSettings.textBox1.Text;

            var size = graphics.MeasureString(text, font);
            Point textLoc = new Point(
                (resultImage.Width / 2) - (int)(size.Width / 2),
                (resultImage.Height / 2) - (int)(size.Height / 2)
            );

            Bitmap txt = RenderText(
                text, font,
                textSettings.colorDialog1.Color,
                resultImage.Size
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
            e.Graphics.Clear(BackColor);
            resultImage = new Bitmap(ResultImageSize.Width, ResultImageSize.Height);

            using (Graphics graphics = Graphics.FromImage(resultImage))
            {
                Render(graphics);
                e.Graphics.DrawImage(resultImage, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            backgroundColor = colorDialog1.Color;

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
            
        }

        private void dbgmode_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void niceFontButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();

            textSettings.WindowState = WindowState;
            shadowSettings.WindowState = WindowState;
            backgroundSettings.WindowState = WindowState;
            imageSettings.WindowState = WindowState;



            if (WindowState != FormWindowState.Minimized)
            {
                textSettings.Left = Right;
                textSettings.Top = Top;

                shadowSettings.Top = textSettings.Bottom;
                shadowSettings.Left = Right;

                backgroundSettings.Left = Left - backgroundSettings.Width;
                backgroundSettings.Top = Top;

                imageSettings.Left = Left - imageSettings.Width;
                imageSettings.Top = backgroundSettings.Bottom;
            }
        }

        private void niceFontButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            textSettings.Left = Right;
            textSettings.Top = Top;

            shadowSettings.Top = textSettings.Bottom;
            shadowSettings.Left = Right;

            backgroundSettings.Left = Left - imageSettings.Width;
            backgroundSettings.Top = Top;

            imageSettings.Left = Left - imageSettings.Width;
            imageSettings.Top = backgroundSettings.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        public bool ModularWindowsVisible = true;

        private void Form1_Activated(object sender, EventArgs e)
        {
            return;

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

        private void blinkButton1_Click(object sender, EventArgs e)
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

        private void blinkButton2_Click(object sender, EventArgs e)
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

        private void blinkButton3_Click(object sender, EventArgs e)
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

        private void blinkButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG image|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        private void blinkCheckbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void blinkCheckbox1_Click(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void blinkButton5_Click(object sender, EventArgs e)
        {
            if (!imageSettings.Visible)
            {
                imageSettings.Show();
                imageSettings.BringToFront();
                imageSettings.Left = Left - imageSettings.Width;
                imageSettings.Top = backgroundSettings.Bottom;
            }
            else
            {
                imageSettings.Hide();
            }
        }
    }
}
