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
    public partial class imageSettings : BlinkForm
    {
        public imageSettings(MainForm form)
        {
            InitializeComponent();

            mainForm = form;

            width.Value = mainForm.ResultImageSize.Width;
            height.Value = mainForm.ResultImageSize.Height;
        }

        private MainForm mainForm;

        Size ResizeKeepAspect(Size src, int maxWidth, int maxHeight, bool enlarge = false)
        {
            maxWidth = enlarge ? maxWidth : Math.Min(maxWidth, src.Width);
            maxHeight = enlarge ? maxHeight : Math.Min(maxHeight, src.Height);

            decimal rnd = Math.Min(maxWidth / (decimal)src.Width, maxHeight / (decimal)src.Height);
            return new Size((int)Math.Round(src.Width * rnd), (int)Math.Round(src.Height * rnd));
        }

        private void blinkButton1_Click(object sender, EventArgs e)
        {
            Size s = mainForm.ResultImageSize = ResizeKeepAspect(mainForm.pictureBox1.Size, (int)width.Value, (int)height.Value, true);
            width.Value = s.Width;
            height.Value = s.Width;
            mainForm.pictureBox1.Invalidate();
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
