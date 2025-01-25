namespace Server.Forms
{
	// Token: 0x0200006D RID: 109
	public partial class FormPorts : global::System.Windows.Forms.Form
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0001D88D File Offset: 0x0001BA8D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001D8AC File Offset: 0x0001BAAC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormPorts));
			this.button1 = new global::System.Windows.Forms.Button();
			this.textPorts = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(23, 237);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(378, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start NordTeck";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textPorts.Location = new global::System.Drawing.Point(82, 48);
			this.textPorts.Name = "textPorts";
			this.textPorts.Size = new global::System.Drawing.Size(164, 26);
			this.textPorts.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(46, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ports";
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textPorts);
			this.groupBox1.Location = new global::System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(401, 198);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new global::System.Drawing.Point(82, 99);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(164, 84);
			this.listBox1.TabIndex = 4;
			this.btnDelete.Location = new global::System.Drawing.Point(301, 55);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(57, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "-";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.BtnDelete_Click);
			this.btnAdd.Location = new global::System.Drawing.Point(301, 26);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(57, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(450, 333);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormPorts";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ports | NordTeck";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.PortsFrm_FormClosed);
			base.Load += new global::System.EventHandler(this.PortsFrm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400023F RID: 575
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000241 RID: 577
		public global::System.Windows.Forms.TextBox textPorts;

		// Token: 0x04000242 RID: 578
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000245 RID: 581
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x04000246 RID: 582
		private global::System.Windows.Forms.Button btnAdd;
	}
}
