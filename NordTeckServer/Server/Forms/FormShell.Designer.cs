namespace Server.Forms
{
	// Token: 0x02000073 RID: 115
	public partial class FormShell : global::System.Windows.Forms.Form
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000203A8 File Offset: 0x0001E5A8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000203C8 File Offset: 0x0001E5C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormShell));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.richTextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 54);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("Consolas", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(248, 248, 242);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(800, 412);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(248, 248, 242);
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Font = new global::System.Drawing.Font("Consolas", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.FromArgb(40, 42, 54);
			this.textBox1.Location = new global::System.Drawing.Point(46, 423);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(754, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 54);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(46, 449);
			this.panel1.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 54);
			base.ClientSize = new global::System.Drawing.Size(800, 449);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.panel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormShell";
			this.Text = "Remote Shell";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormShell_FormClosed);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000285 RID: 645
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000287 RID: 647
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000289 RID: 649
		public global::System.Windows.Forms.Timer timer1;
	}
}
