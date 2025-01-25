namespace Server.Forms
{
	// Token: 0x0200006A RID: 106
	public partial class FormKeylogger : global::System.Windows.Forms.Form
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001C80C File Offset: 0x0001AA0C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormKeylogger));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBox1 = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new global::System.Windows.Forms.ToolStripButton();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.toolStrip1.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.toolStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripLabel1,
				this.toolStripTextBox1,
				this.toolStripSeparator1,
				this.toolStripButton1
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(731, 34);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new global::System.Drawing.Size(64, 29);
			this.toolStripLabel1.Text = "Search";
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new global::System.Drawing.Size(100, 34);
			this.toolStripTextBox1.Text = "...";
			this.toolStripTextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyDown);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 34);
			this.toolStripButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new global::System.Drawing.Size(53, 29);
			this.toolStripButton1.Text = "Save";
			this.toolStripButton1.Click += new global::System.EventHandler(this.ToolStripButton1_Click);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 34);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(731, 376);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(731, 410);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.toolStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormKeylogger";
			this.Text = "Keylogger";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Keylogger_FormClosed);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000224 RID: 548
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel1;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.ToolStripTextBox toolStripTextBox1;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000229 RID: 553
		private global::System.Windows.Forms.ToolStripButton toolStripButton1;

		// Token: 0x0400022A RID: 554
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400022B RID: 555
		public global::System.Windows.Forms.Timer timer1;
	}
}
