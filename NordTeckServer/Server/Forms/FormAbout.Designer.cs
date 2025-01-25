namespace Server.Forms
{
	// Token: 0x0200005C RID: 92
	public partial class FormAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00012446 File Offset: 0x00010646
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00012468 File Offset: 0x00010668
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormAbout));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			base.SuspendLayout();
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.DetectUrls = false;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.ShortcutsEnabled = false;
			this.richTextBox1.Size = new global::System.Drawing.Size(557, 210);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.richTextBox1.ZoomFactor = 1.1f;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(557, 210);
			base.Controls.Add(this.richTextBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormAbout";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NordTeck | About";
			base.ResumeLayout(false);
		}

		// Token: 0x04000162 RID: 354
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
