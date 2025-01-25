namespace Server.Forms
{
	// Token: 0x02000071 RID: 113
	public partial class FormRemoteDesktop : global::System.Windows.Forms.Form
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0001F10E File Offset: 0x0001D30E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001F130 File Offset: 0x0001D330
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRemoteDesktop));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnKeyboard = new global::System.Windows.Forms.Button();
			this.btnMouse = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnSlide = new global::System.Windows.Forms.Button();
			this.timerSave = new global::System.Windows.Forms.Timer(this.components);
			this.labelWait = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(625, 315);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			this.timer1.Interval = 2000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnKeyboard);
			this.panel1.Controls.Add(this.btnMouse);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(625, 25);
			this.panel1.TabIndex = 1;
			this.btnKeyboard.BackgroundImage = global::Server.Properties.Resources.keyboard;
			this.btnKeyboard.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnKeyboard.Location = new global::System.Drawing.Point(415, 2);
			this.btnKeyboard.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.Size = new global::System.Drawing.Size(21, 21);
			this.btnKeyboard.TabIndex = 6;
			this.btnKeyboard.UseVisualStyleBackColor = true;
			this.btnKeyboard.Click += new global::System.EventHandler(this.btnKeyboard_Click);
			this.btnMouse.BackgroundImage = global::Server.Properties.Resources.mouse;
			this.btnMouse.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnMouse.Location = new global::System.Drawing.Point(367, 2);
			this.btnMouse.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnMouse.Name = "btnMouse";
			this.btnMouse.Size = new global::System.Drawing.Size(21, 21);
			this.btnMouse.TabIndex = 3;
			this.btnMouse.UseVisualStyleBackColor = true;
			this.btnMouse.Click += new global::System.EventHandler(this.Button3_Click);
			this.btnSave.BackgroundImage = global::Server.Properties.Resources.save_image;
			this.btnSave.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.Location = new global::System.Drawing.Point(303, 2);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(21, 21);
			this.btnSave.TabIndex = 5;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.BtnSave_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(179, 6);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(51, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "SCREEN";
			this.numericUpDown2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown2.Enabled = false;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown2;
			int[] array = new int[4];
			array[0] = 10;
			numericUpDown.Increment = new decimal(array);
			this.numericUpDown2.Location = new global::System.Drawing.Point(235, 3);
			this.numericUpDown2.Margin = new global::System.Windows.Forms.Padding(2);
			this.numericUpDown2.Maximum = new decimal(new int[4]);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(42, 20);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown2.UpDownAlign = global::System.Windows.Forms.LeftRightAlignment.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(55, 6);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "QUALITY";
			this.numericUpDown1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Enabled = false;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 10;
			numericUpDown2.Increment = new decimal(array2);
			this.numericUpDown1.Location = new global::System.Drawing.Point(111, 3);
			this.numericUpDown1.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 20;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(55, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.UpDownAlign = global::System.Windows.Forms.LeftRightAlignment.Left;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown1;
			int[] array4 = new int[4];
			array4[0] = 30;
			numericUpDown4.Value = new decimal(array4);
			this.btnStart.BackgroundImage = global::Server.Properties.Resources.stop__1_;
			this.btnStart.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnStart.Location = new global::System.Drawing.Point(8, 2);
			this.btnStart.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(21, 21);
			this.btnStart.TabIndex = 0;
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnSlide.BackgroundImage = global::Server.Properties.Resources.arrow_up;
			this.btnSlide.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnSlide.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSlide.Location = new global::System.Drawing.Point(285, 29);
			this.btnSlide.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnSlide.Name = "btnSlide";
			this.btnSlide.Size = new global::System.Drawing.Size(12, 12);
			this.btnSlide.TabIndex = 2;
			this.btnSlide.Text = " ";
			this.btnSlide.UseVisualStyleBackColor = true;
			this.btnSlide.Click += new global::System.EventHandler(this.btnSlide_Click);
			this.timerSave.Interval = 1500;
			this.timerSave.Tick += new global::System.EventHandler(this.TimerSave_Tick);
			this.labelWait.AutoSize = true;
			this.labelWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.labelWait.Location = new global::System.Drawing.Point(251, 144);
			this.labelWait.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWait.Name = "labelWait";
			this.labelWait.Size = new global::System.Drawing.Size(53, 20);
			this.labelWait.TabIndex = 3;
			this.labelWait.Text = "Wait...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(625, 315);
			base.Controls.Add(this.labelWait);
			base.Controls.Add(this.btnSlide);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			this.MinimumSize = new global::System.Drawing.Size(442, 300);
			base.Name = "FormRemoteDesktop";
			this.Text = "RemoteDesktop";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormRemoteDesktop_FormClosed);
			base.Load += new global::System.EventHandler(this.FormRemoteDesktop_Load);
			base.ResizeEnd += new global::System.EventHandler(this.FormRemoteDesktop_ResizeEnd);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyDown);
			base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyUp);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000266 RID: 614
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000267 RID: 615
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000268 RID: 616
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000269 RID: 617
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400026A RID: 618
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400026B RID: 619
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.Button btnSlide;

		// Token: 0x0400026D RID: 621
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400026F RID: 623
		public global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.Timer timerSave;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.Button btnMouse;

		// Token: 0x04000273 RID: 627
		public global::System.Windows.Forms.Label labelWait;

		// Token: 0x04000274 RID: 628
		private global::System.Windows.Forms.Button btnKeyboard;
	}
}
