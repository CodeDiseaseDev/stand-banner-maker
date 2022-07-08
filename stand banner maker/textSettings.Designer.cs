
namespace stand_banner_maker
{
    partial class textSettings
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.blinkLabel1 = new Blink_UI_lib.BlinkLabel();
            this.blinkButton1 = new Blink_UI_lib.BlinkButton();
            this.verticalOffset = new Blink_UI_lib.BlinkSlider();
            this.blinkGroupBox1 = new Blink_UI_lib.BlinkGroupBox();
            this.blinkButton2 = new Blink_UI_lib.BlinkButton();
            this.blinkLabel2 = new Blink_UI_lib.BlinkLabel();
            this.blinkLabel3 = new Blink_UI_lib.BlinkLabel();
            this.blinkLabel4 = new Blink_UI_lib.BlinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.blinkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blinkTitleBar1
            // 
            this.blinkTitleBar1.Size = new System.Drawing.Size(393, 29);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(49, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Stand";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Calibri", 50F);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(49, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 20);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // blinkLabel1
            // 
            this.blinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkLabel1.AutoSize = true;
            this.blinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkLabel1.ForeColor = System.Drawing.Color.White;
            this.blinkLabel1.Location = new System.Drawing.Point(310, 11);
            this.blinkLabel1.Name = "blinkLabel1";
            this.blinkLabel1.Size = new System.Drawing.Size(47, 17);
            this.blinkLabel1.TabIndex = 18;
            this.blinkLabel1.Text = "Y Offset";
            // 
            // blinkButton1
            // 
            this.blinkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blinkButton1.Animated = true;
            this.blinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton1.BorderRadius = 4;
            this.blinkButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton1.Font = new System.Drawing.Font("Yu Gothic UI", 7F);
            this.blinkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton1.Location = new System.Drawing.Point(11, 186);
            this.blinkButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(84, 23);
            this.blinkButton1.TabIndex = 20;
            this.blinkButton1.Text = "Change Font";
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // verticalOffset
            // 
            this.verticalOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.verticalOffset.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.verticalOffset.Location = new System.Drawing.Point(12, 23);
            this.verticalOffset.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.verticalOffset.MaxValue = 100;
            this.verticalOffset.MinValue = -100;
            this.verticalOffset.Name = "verticalOffset";
            this.verticalOffset.Size = new System.Drawing.Size(290, 15);
            this.verticalOffset.TabIndex = 21;
            this.verticalOffset.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.verticalOffset.Value = 0;
            this.verticalOffset.OnValueChanged += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider1_OnValueChanged);
            // 
            // blinkGroupBox1
            // 
            this.blinkGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox1.BorderRadius = 0;
            this.blinkGroupBox1.Controls.Add(this.blinkButton2);
            this.blinkGroupBox1.Controls.Add(this.verticalOffset);
            this.blinkGroupBox1.Controls.Add(this.blinkLabel1);
            this.blinkGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.blinkGroupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.blinkGroupBox1.InternalPanel.Location = new System.Drawing.Point(0, 0);
            this.blinkGroupBox1.InternalPanel.Name = "";
            this.blinkGroupBox1.InternalPanel.TabIndex = 0;
            this.blinkGroupBox1.LineBorderRadius = 3;
            this.blinkGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkGroupBox1.Location = new System.Drawing.Point(12, 117);
            this.blinkGroupBox1.Name = "blinkGroupBox1";
            this.blinkGroupBox1.Size = new System.Drawing.Size(369, 52);
            this.blinkGroupBox1.TabIndex = 22;
            this.blinkGroupBox1.Text = "Advanced";
            // 
            // blinkButton2
            // 
            this.blinkButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkButton2.Animated = true;
            this.blinkButton2.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton2.BorderRadius = 4;
            this.blinkButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton2.Font = new System.Drawing.Font("Yu Gothic UI", 7F);
            this.blinkButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton2.Location = new System.Drawing.Point(318, 28);
            this.blinkButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinkButton2.Name = "blinkButton2";
            this.blinkButton2.Size = new System.Drawing.Size(30, 15);
            this.blinkButton2.TabIndex = 24;
            this.blinkButton2.Text = "reset";
            this.blinkButton2.Click += new System.EventHandler(this.blinkButton2_Click);
            // 
            // blinkLabel2
            // 
            this.blinkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blinkLabel2.AutoSize = true;
            this.blinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkLabel2.Location = new System.Drawing.Point(100, 189);
            this.blinkLabel2.Name = "blinkLabel2";
            this.blinkLabel2.Size = new System.Drawing.Size(62, 17);
            this.blinkLabel2.TabIndex = 23;
            this.blinkLabel2.Text = "Font name";
            // 
            // blinkLabel3
            // 
            this.blinkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkLabel3.AutoSize = true;
            this.blinkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkLabel3.ForeColor = System.Drawing.Color.White;
            this.blinkLabel3.Location = new System.Drawing.Point(17, 52);
            this.blinkLabel3.Name = "blinkLabel3";
            this.blinkLabel3.Size = new System.Drawing.Size(26, 17);
            this.blinkLabel3.TabIndex = 24;
            this.blinkLabel3.Text = "Text";
            // 
            // blinkLabel4
            // 
            this.blinkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkLabel4.AutoSize = true;
            this.blinkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkLabel4.ForeColor = System.Drawing.Color.White;
            this.blinkLabel4.Location = new System.Drawing.Point(10, 78);
            this.blinkLabel4.Name = "blinkLabel4";
            this.blinkLabel4.Size = new System.Drawing.Size(33, 17);
            this.blinkLabel4.TabIndex = 25;
            this.blinkLabel4.Text = "Color";
            // 
            // textSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(393, 220);
            this.Controls.Add(this.blinkLabel4);
            this.Controls.Add(this.blinkLabel3);
            this.Controls.Add(this.blinkLabel2);
            this.Controls.Add(this.blinkGroupBox1);
            this.Controls.Add(this.blinkButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "textSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "textSettings";
            this.Deactivate += new System.EventHandler(this.textSettings_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textSettings_FormClosing);
            this.Move += new System.EventHandler(this.textSettings_Move);
            this.Resize += new System.EventHandler(this.textSettings_Resize);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.blinkTitleBar1, 0);
            this.Controls.SetChildIndex(this.blinkButton1, 0);
            this.Controls.SetChildIndex(this.blinkGroupBox1, 0);
            this.Controls.SetChildIndex(this.blinkLabel2, 0);
            this.Controls.SetChildIndex(this.blinkLabel3, 0);
            this.Controls.SetChildIndex(this.blinkLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.blinkGroupBox1.ResumeLayout(false);
            this.blinkGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public Blink_UI_lib.BlinkLabel blinkLabel1;
        private Blink_UI_lib.BlinkButton blinkButton1;
        public Blink_UI_lib.BlinkSlider verticalOffset;
        private Blink_UI_lib.BlinkGroupBox blinkGroupBox1;
        private Blink_UI_lib.BlinkLabel blinkLabel2;
        private Blink_UI_lib.BlinkButton blinkButton2;
        public Blink_UI_lib.BlinkLabel blinkLabel3;
        public Blink_UI_lib.BlinkLabel blinkLabel4;
    }
}