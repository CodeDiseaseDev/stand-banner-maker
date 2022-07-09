namespace stand_banner_maker
{
	// Token: 0x02000002 RID: 2
	public partial class MainForm : Blink_UI_lib.BlinkForm
    {
		// Token: 0x06000012 RID: 18 RVA: 0x000024E8 File Offset: 0x000006E8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002520 File Offset: 0x00000720
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blinkButton2 = new Blink_UI_lib.BlinkButton();
            this.blinkButton1 = new Blink_UI_lib.BlinkButton();
            this.blinkButton3 = new Blink_UI_lib.BlinkButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.blinkGroupBox1 = new Blink_UI_lib.BlinkGroupBox();
            this.blinkGroupBox2 = new Blink_UI_lib.BlinkGroupBox();
            this.blinkButton4 = new Blink_UI_lib.BlinkButton();
            this.dbgmode = new Blink_UI_lib.BlinkCheckbox();
            this.blinkGroupBox3 = new Blink_UI_lib.BlinkGroupBox();
            this.blinkButton5 = new Blink_UI_lib.BlinkButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.blinkGroupBox1.SuspendLayout();
            this.blinkGroupBox2.SuspendLayout();
            this.blinkGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // blinkTitleBar1
            // 
            this.blinkTitleBar1.Size = new System.Drawing.Size(474, 29);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // blinkButton2
            // 
            this.blinkButton2.Animated = false;
            this.blinkButton2.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton2.BorderRadius = 4;
            this.blinkButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton2.Font = new System.Drawing.Font("Yu Gothic UI", 7.5F);
            this.blinkButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton2.Location = new System.Drawing.Point(6, 40);
            this.blinkButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinkButton2.Name = "blinkButton2";
            this.blinkButton2.Size = new System.Drawing.Size(122, 21);
            this.blinkButton2.TabIndex = 11;
            this.blinkButton2.Text = "Shadow Properties";
            this.blinkButton2.Click += new System.EventHandler(this.blinkButton2_Click);
            // 
            // blinkButton1
            // 
            this.blinkButton1.Animated = false;
            this.blinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton1.BorderRadius = 4;
            this.blinkButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton1.Font = new System.Drawing.Font("Yu Gothic UI", 7.5F);
            this.blinkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton1.Location = new System.Drawing.Point(6, 15);
            this.blinkButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(122, 21);
            this.blinkButton1.TabIndex = 10;
            this.blinkButton1.Text = "Text Properties";
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // blinkButton3
            // 
            this.blinkButton3.Animated = false;
            this.blinkButton3.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton3.BorderRadius = 4;
            this.blinkButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton3.Font = new System.Drawing.Font("Yu Gothic UI", 7.5F);
            this.blinkButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton3.Location = new System.Drawing.Point(6, 15);
            this.blinkButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinkButton3.Name = "blinkButton3";
            this.blinkButton3.Size = new System.Drawing.Size(122, 21);
            this.blinkButton3.TabIndex = 12;
            this.blinkButton3.Text = "Background Properties";
            this.blinkButton3.Click += new System.EventHandler(this.blinkButton3_Click);
            // 
            // blinkGroupBox1
            // 
            this.blinkGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox1.BorderRadius = 0;
            this.blinkGroupBox1.Controls.Add(this.blinkButton3);
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
            this.blinkGroupBox1.Location = new System.Drawing.Point(12, 288);
            this.blinkGroupBox1.Name = "blinkGroupBox1";
            this.blinkGroupBox1.Size = new System.Drawing.Size(450, 45);
            this.blinkGroupBox1.TabIndex = 10;
            this.blinkGroupBox1.Text = "Background";
            // 
            // blinkGroupBox2
            // 
            this.blinkGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox2.BorderRadius = 0;
            this.blinkGroupBox2.Controls.Add(this.blinkButton1);
            this.blinkGroupBox2.Controls.Add(this.blinkButton2);
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
            this.blinkGroupBox2.Location = new System.Drawing.Point(12, 214);
            this.blinkGroupBox2.Name = "blinkGroupBox2";
            this.blinkGroupBox2.Size = new System.Drawing.Size(450, 68);
            this.blinkGroupBox2.TabIndex = 11;
            this.blinkGroupBox2.Text = "Foreground";
            // 
            // blinkButton4
            // 
            this.blinkButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkButton4.Animated = false;
            this.blinkButton4.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton4.BorderRadius = 4;
            this.blinkButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.blinkButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton4.Location = new System.Drawing.Point(12, 468);
            this.blinkButton4.Name = "blinkButton4";
            this.blinkButton4.Size = new System.Drawing.Size(450, 29);
            this.blinkButton4.TabIndex = 12;
            this.blinkButton4.Text = "Save as PNG file";
            this.blinkButton4.Click += new System.EventHandler(this.blinkButton4_Click);
            // 
            // dbgmode
            // 
            this.dbgmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgmode.Animated = false;
            this.dbgmode.AutoSize = true;
            this.dbgmode.BackColor = System.Drawing.Color.Transparent;
            this.dbgmode.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.dbgmode.Checked = false;
            this.dbgmode.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.dbgmode.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.dbgmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dbgmode.Location = new System.Drawing.Point(363, 442);
            this.dbgmode.Name = "dbgmode";
            this.dbgmode.Size = new System.Drawing.Size(99, 20);
            this.dbgmode.TabIndex = 13;
            this.dbgmode.Text = "Debug mode";
            this.dbgmode.Click += new System.EventHandler(this.blinkCheckbox1_Click);
            this.dbgmode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blinkCheckbox1_Click);
            // 
            // blinkGroupBox3
            // 
            this.blinkGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blinkGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.blinkGroupBox3.BorderRadius = 0;
            this.blinkGroupBox3.Controls.Add(this.blinkButton5);
            this.blinkGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.blinkGroupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.blinkGroupBox3.InternalPanel.Location = new System.Drawing.Point(0, 0);
            this.blinkGroupBox3.InternalPanel.Name = "";
            this.blinkGroupBox3.InternalPanel.TabIndex = 0;
            this.blinkGroupBox3.LineBorderRadius = 3;
            this.blinkGroupBox3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkGroupBox3.Location = new System.Drawing.Point(12, 339);
            this.blinkGroupBox3.Name = "blinkGroupBox3";
            this.blinkGroupBox3.Size = new System.Drawing.Size(450, 45);
            this.blinkGroupBox3.TabIndex = 14;
            this.blinkGroupBox3.Text = "Image";
            // 
            // blinkButton5
            // 
            this.blinkButton5.Animated = false;
            this.blinkButton5.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton5.BorderRadius = 4;
            this.blinkButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton5.Font = new System.Drawing.Font("Yu Gothic UI", 7.5F);
            this.blinkButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton5.Location = new System.Drawing.Point(6, 15);
            this.blinkButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinkButton5.Name = "blinkButton5";
            this.blinkButton5.Size = new System.Drawing.Size(122, 21);
            this.blinkButton5.TabIndex = 12;
            this.blinkButton5.Text = "Image Properties";
            this.blinkButton5.Click += new System.EventHandler(this.blinkButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(474, 509);
            this.Controls.Add(this.blinkGroupBox3);
            this.Controls.Add(this.dbgmode);
            this.Controls.Add(this.blinkButton4);
            this.Controls.Add(this.blinkGroupBox2);
            this.Controls.Add(this.blinkGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stand Header Maker";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.blinkTitleBar1, 0);
            this.Controls.SetChildIndex(this.blinkGroupBox1, 0);
            this.Controls.SetChildIndex(this.blinkGroupBox2, 0);
            this.Controls.SetChildIndex(this.blinkButton4, 0);
            this.Controls.SetChildIndex(this.dbgmode, 0);
            this.Controls.SetChildIndex(this.blinkGroupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.blinkGroupBox1.ResumeLayout(false);
            this.blinkGroupBox2.ResumeLayout(false);
            this.blinkGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ColorDialog colorDialog1;
        private Blink_UI_lib.BlinkButton blinkButton1;
        private Blink_UI_lib.BlinkButton blinkButton2;
        private Blink_UI_lib.BlinkButton blinkButton3;
        private Blink_UI_lib.BlinkGroupBox blinkGroupBox1;
        private Blink_UI_lib.BlinkGroupBox blinkGroupBox2;
        private Blink_UI_lib.BlinkButton blinkButton4;
        private Blink_UI_lib.BlinkCheckbox dbgmode;
        private Blink_UI_lib.BlinkGroupBox blinkGroupBox3;
        private Blink_UI_lib.BlinkButton blinkButton5;
    }
}
