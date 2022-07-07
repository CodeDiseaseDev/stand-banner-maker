namespace stand_banner_maker
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.niceFontButton3 = new System.Windows.Forms.Button();
            this.niceFontButton2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dbgmode = new System.Windows.Forms.CheckBox();
            this.niceFontButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Magenta;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.niceFontButton3);
            this.groupBox1.Controls.Add(this.niceFontButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foreground";
            // 
            // niceFontButton3
            // 
            this.niceFontButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niceFontButton3.Location = new System.Drawing.Point(6, 19);
            this.niceFontButton3.Name = "niceFontButton3";
            this.niceFontButton3.Size = new System.Drawing.Size(108, 21);
            this.niceFontButton3.TabIndex = 10;
            this.niceFontButton3.Text = "Text Properties";
            this.niceFontButton3.UseVisualStyleBackColor = true;
            this.niceFontButton3.Click += new System.EventHandler(this.niceFontButton3_Click);
            // 
            // niceFontButton2
            // 
            this.niceFontButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niceFontButton2.Location = new System.Drawing.Point(6, 46);
            this.niceFontButton2.Name = "niceFontButton2";
            this.niceFontButton2.Size = new System.Drawing.Size(108, 21);
            this.niceFontButton2.TabIndex = 9;
            this.niceFontButton2.Text = "Shadow Properties";
            this.niceFontButton2.UseVisualStyleBackColor = true;
            this.niceFontButton2.Click += new System.EventHandler(this.niceFontButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Background Properties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbgmode
            // 
            this.dbgmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgmode.AutoSize = true;
            this.dbgmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbgmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dbgmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dbgmode.Location = new System.Drawing.Point(322, 332);
            this.dbgmode.Name = "dbgmode";
            this.dbgmode.Size = new System.Drawing.Size(85, 17);
            this.dbgmode.TabIndex = 9;
            this.dbgmode.Text = "Debug Mode";
            this.dbgmode.UseVisualStyleBackColor = true;
            this.dbgmode.CheckedChanged += new System.EventHandler(this.dbgmode_CheckedChanged);
            // 
            // niceFontButton1
            // 
            this.niceFontButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.niceFontButton1.Location = new System.Drawing.Point(12, 355);
            this.niceFontButton1.Name = "niceFontButton1";
            this.niceFontButton1.Size = new System.Drawing.Size(395, 29);
            this.niceFontButton1.TabIndex = 4;
            this.niceFontButton1.Text = "Save as PNG file";
            this.niceFontButton1.UseVisualStyleBackColor = true;
            this.niceFontButton1.Click += new System.EventHandler(this.niceFontButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 396);
            this.Controls.Add(this.dbgmode);
            this.Controls.Add(this.niceFontButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button niceFontButton1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.CheckBox dbgmode;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button niceFontButton2;
        private System.Windows.Forms.Button niceFontButton3;
        private System.Windows.Forms.Button button1;
    }
}
