namespace stand_banner_maker
{
    partial class imageSettings
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
            this.blinkLabel1 = new Blink_UI_lib.BlinkLabel();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.blinkLabel2 = new Blink_UI_lib.BlinkLabel();
            this.blinkButton1 = new Blink_UI_lib.BlinkButton();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // blinkTitleBar1
            // 
            this.blinkTitleBar1.Size = new System.Drawing.Size(364, 29);
            // 
            // blinkLabel1
            // 
            this.blinkLabel1.AutoSize = true;
            this.blinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 11F);
            this.blinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkLabel1.Location = new System.Drawing.Point(12, 43);
            this.blinkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blinkLabel1.Name = "blinkLabel1";
            this.blinkLabel1.Size = new System.Drawing.Size(45, 21);
            this.blinkLabel1.TabIndex = 1;
            this.blinkLabel1.Text = "Width";
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width.ForeColor = System.Drawing.Color.White;
            this.width.Location = new System.Drawing.Point(76, 42);
            this.width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(276, 25);
            this.width.TabIndex = 2;
            this.width.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height.ForeColor = System.Drawing.Color.White;
            this.height.Location = new System.Drawing.Point(76, 73);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(276, 25);
            this.height.TabIndex = 4;
            this.height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // blinkLabel2
            // 
            this.blinkLabel2.AutoSize = true;
            this.blinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.blinkLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 11F);
            this.blinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkLabel2.Location = new System.Drawing.Point(12, 74);
            this.blinkLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blinkLabel2.Name = "blinkLabel2";
            this.blinkLabel2.Size = new System.Drawing.Size(49, 21);
            this.blinkLabel2.TabIndex = 3;
            this.blinkLabel2.Text = "Height";
            // 
            // blinkButton1
            // 
            this.blinkButton1.Animated = true;
            this.blinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.blinkButton1.BorderRadius = 4;
            this.blinkButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.blinkButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.blinkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blinkButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.blinkButton1.Location = new System.Drawing.Point(252, 131);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(100, 35);
            this.blinkButton1.TabIndex = 5;
            this.blinkButton1.Text = "Update size";
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // imageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 178);
            this.Controls.Add(this.blinkButton1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.blinkLabel2);
            this.Controls.Add(this.width);
            this.Controls.Add(this.blinkLabel1);
            this.Name = "imageSettings";
            this.ShowInTaskbar = false;
            this.Text = "imageSettings";
            this.Controls.SetChildIndex(this.blinkTitleBar1, 0);
            this.Controls.SetChildIndex(this.blinkLabel1, 0);
            this.Controls.SetChildIndex(this.width, 0);
            this.Controls.SetChildIndex(this.blinkLabel2, 0);
            this.Controls.SetChildIndex(this.height, 0);
            this.Controls.SetChildIndex(this.blinkButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Blink_UI_lib.BlinkLabel blinkLabel1;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown height;
        private Blink_UI_lib.BlinkLabel blinkLabel2;
        private Blink_UI_lib.BlinkButton blinkButton1;
    }
}