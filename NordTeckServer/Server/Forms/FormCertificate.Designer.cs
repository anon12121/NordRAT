﻿namespace Server.Forms
{
	// Token: 0x02000061 RID: 97
	public partial class FormCertificate : global::System.Windows.Forms.Form
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0001732F File Offset: 0x0001552F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00017350 File Offset: 0x00015550
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormCertificate));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(579, 189);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Certificate";
			this.button1.Location = new global::System.Drawing.Point(11, 129);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(149, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(191, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(325, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "NordTeck Server";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(7, 49);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(132, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "-Certificate Name";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(603, 213);
			base.ControlBox = false;
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormCertificate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Certificate";
			base.Load += new global::System.EventHandler(this.FormCertificate_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001B5 RID: 437
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
