namespace stand_banner_maker
{
    partial class backgroundSettings
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.blinkGroupBox1 = new Blink_UI_lib.BlinkGroupBox();
            this.cornerRadius = new Blink_UI_lib.BlinkSlider();
            this.blinkLabel1 = new Blink_UI_lib.BlinkLabel();
            this.blinkCheckbox1 = new Blink_UI_lib.BlinkCheckbox();
            this.blinkGroupBox2 = new Blink_UI_lib.BlinkGroupBox();
            this.gaussianBlur = new Blink_UI_lib.BlinkCheckbox();
            this.backgroundImageEnabled = new Blink_UI_lib.BlinkCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.blinkGroupBox1.SuspendLayout();
            this.blinkGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // blinkTitleBar1
            // 
            this.blinkTitleBar1.Size = new System.Drawing.Size(364, 29);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(83, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 20);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(10, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            // 
            // blinkGroupBox1
            // 
            this.blinkGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox1.BorderRadius = 0;
            this.blinkGroupBox1.Controls.Add(this.cornerRadius);
            this.blinkGroupBox1.Controls.Add(this.blinkLabel1);
            this.blinkGroupBox1.Controls.Add(this.blinkCheckbox1);
            this.blinkGroupBox1.Controls.Add(this.pictureBox2);
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
            this.blinkGroupBox1.Location = new System.Drawing.Point(12, 42);
            this.blinkGroupBox1.Name = "blinkGroupBox1";
            this.blinkGroupBox1.Size = new System.Drawing.Size(340, 95);
            this.blinkGroupBox1.TabIndex = 12;
            this.blinkGroupBox1.Text = "Solid Background";
            // 
            // cornerRadius
            // 
            this.cornerRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.cornerRadius.DotColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cornerRadius.Location = new System.Drawing.Point(9, 71);
            this.cornerRadius.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cornerRadius.MaxValue = 66;
            this.cornerRadius.MinValue = 0;
            this.cornerRadius.Name = "cornerRadius";
            this.cornerRadius.Size = new System.Drawing.Size(323, 15);
            this.cornerRadius.TabIndex = 16;
            this.cornerRadius.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.cornerRadius.Value = 0;
            this.cornerRadius.OnValueChanged += new Blink_UI_lib.BlinkSlider.ValueChangedEventHandler(this.blinkSlider1_OnValueChanged);
            // 
            // blinkLabel1
            // 
            this.blinkLabel1.AutoSize = true;
            this.blinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkLabel1.Location = new System.Drawing.Point(9, 48);
            this.blinkLabel1.Name = "blinkLabel1";
            this.blinkLabel1.Size = new System.Drawing.Size(80, 17);
            this.blinkLabel1.TabIndex = 15;
            this.blinkLabel1.Text = "Corner Radius";
            // 
            // blinkCheckbox1
            // 
            this.blinkCheckbox1.Animated = false;
            this.blinkCheckbox1.AutoSize = true;
            this.blinkCheckbox1.BackColor = System.Drawing.Color.Transparent;
            this.blinkCheckbox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.blinkCheckbox1.Checked = true;
            this.blinkCheckbox1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.blinkCheckbox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkCheckbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkCheckbox1.Location = new System.Drawing.Point(6, 18);
            this.blinkCheckbox1.Name = "blinkCheckbox1";
            this.blinkCheckbox1.Size = new System.Drawing.Size(71, 20);
            this.blinkCheckbox1.TabIndex = 0;
            this.blinkCheckbox1.Text = "Enabled";
            this.blinkCheckbox1.Load += new System.EventHandler(this.blinkCheckbox1_Load);
            this.blinkCheckbox1.Click += new System.EventHandler(this.blinkCheckbox1_Click);
            this.blinkCheckbox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blinkCheckbox1_MouseUp);
            // 
            // blinkGroupBox2
            // 
            this.blinkGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox2.BorderRadius = 0;
            this.blinkGroupBox2.Controls.Add(this.gaussianBlur);
            this.blinkGroupBox2.Controls.Add(this.backgroundImageEnabled);
            this.blinkGroupBox2.Controls.Add(this.pictureBox1);
            this.blinkGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.blinkGroupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.blinkGroupBox2.InternalPanel.Location = new System.Drawing.Point(0, 0);
            this.blinkGroupBox2.InternalPanel.Name = "";
            this.blinkGroupBox2.InternalPanel.TabIndex = 0;
            this.blinkGroupBox2.LineBorderRadius = 3;
            this.blinkGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkGroupBox2.Location = new System.Drawing.Point(12, 149);
            this.blinkGroupBox2.Name = "blinkGroupBox2";
            this.blinkGroupBox2.Size = new System.Drawing.Size(340, 171);
            this.blinkGroupBox2.TabIndex = 13;
            this.blinkGroupBox2.Text = "Image Background";
            // 
            // gaussianBlur
            // 
            this.gaussianBlur.Animated = false;
            this.gaussianBlur.AutoSize = true;
            this.gaussianBlur.BackColor = System.Drawing.Color.Transparent;
            this.gaussianBlur.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.gaussianBlur.Checked = false;
            this.gaussianBlur.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.gaussianBlur.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gaussianBlur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gaussianBlur.Location = new System.Drawing.Point(94, 18);
            this.gaussianBlur.Name = "gaussianBlur";
            this.gaussianBlur.Size = new System.Drawing.Size(101, 20);
            this.gaussianBlur.TabIndex = 1;
            this.gaussianBlur.Text = "Gaussian Blur";
            this.gaussianBlur.Load += new System.EventHandler(this.gaussianBlur_Load);
            this.gaussianBlur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gaussianBlur_MouseDown);
            this.gaussianBlur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gaussianBlur_MouseUp);
            // 
            // backgroundImageEnabled
            // 
            this.backgroundImageEnabled.Animated = false;
            this.backgroundImageEnabled.AutoSize = true;
            this.backgroundImageEnabled.BackColor = System.Drawing.Color.Transparent;
            this.backgroundImageEnabled.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.backgroundImageEnabled.Checked = false;
            this.backgroundImageEnabled.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.backgroundImageEnabled.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.backgroundImageEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backgroundImageEnabled.Location = new System.Drawing.Point(6, 18);
            this.backgroundImageEnabled.Name = "backgroundImageEnabled";
            this.backgroundImageEnabled.Size = new System.Drawing.Size(71, 20);
            this.backgroundImageEnabled.TabIndex = 0;
            this.backgroundImageEnabled.Text = "Enabled";
            this.backgroundImageEnabled.Load += new System.EventHandler(this.backgroundImageEnabled_Load);
            this.backgroundImageEnabled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundImageEnabled_MouseDown);
            this.backgroundImageEnabled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backgroundImageEnabled_MouseUp);
            // 
            // backgroundSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(364, 332);
            this.Controls.Add(this.blinkGroupBox2);
            this.Controls.Add(this.blinkGroupBox1);
            this.Name = "backgroundSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "backgroundSettings";
            this.Deactivate += new System.EventHandler(this.backgroundSettings_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.backgroundSettings_FormClosing);
            this.Resize += new System.EventHandler(this.backgroundSettings_Resize);
            this.Controls.SetChildIndex(this.blinkGroupBox1, 0);
            this.Controls.SetChildIndex(this.blinkTitleBar1, 0);
            this.Controls.SetChildIndex(this.blinkGroupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.blinkGroupBox1.ResumeLayout(false);
            this.blinkGroupBox1.PerformLayout();
            this.blinkGroupBox2.ResumeLayout(false);
            this.blinkGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public Blink_UI_lib.BlinkGroupBox blinkGroupBox1;
        public Blink_UI_lib.BlinkCheckbox blinkCheckbox1;
        public Blink_UI_lib.BlinkLabel blinkLabel1;
        public Blink_UI_lib.BlinkGroupBox blinkGroupBox2;
        public Blink_UI_lib.BlinkCheckbox backgroundImageEnabled;
        public Blink_UI_lib.BlinkCheckbox gaussianBlur;
        public Blink_UI_lib.BlinkSlider cornerRadius;
    }
}