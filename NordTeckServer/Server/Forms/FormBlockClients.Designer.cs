﻿namespace Server.Forms
{
	// Token: 0x0200005D RID: 93
	public partial class FormBlockClients : global::System.Windows.Forms.Form
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x000127FC File Offset: 0x000109FC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001281C File Offset: 0x00010A1C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormBlockClients));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.listBlocked = new global::System.Windows.Forms.ListBox();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtBlock = new global::System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.listBlocked);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBlock);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(424, 355);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Block By HWID or IP";
			this.listBlocked.DataBindings.Add(new global::System.Windows.Forms.Binding("Name", global::Server.Properties.Settings.Default, "txtBlocked", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.listBlocked.FormattingEnabled = true;
			this.listBlocked.ItemHeight = 20;
			this.listBlocked.Location = new global::System.Drawing.Point(6, 165);
			this.listBlocked.Name = global::Server.Properties.Settings.Default.txtBlocked;
			this.listBlocked.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBlocked.Size = new global::System.Drawing.Size(290, 184);
			this.listBlocked.TabIndex = 4;
			this.btnDelete.Location = new global::System.Drawing.Point(352, 165);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(57, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "-";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.BtnDelete_Click);
			this.btnAdd.Location = new global::System.Drawing.Point(352, 86);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(57, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(135, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Insert HWID or IP";
			this.txtBlock.Location = new global::System.Drawing.Point(10, 87);
			this.txtBlock.Name = "txtBlock";
			this.txtBlock.Size = new global::System.Drawing.Size(286, 26);
			this.txtBlock.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(448, 379);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormBlockClients";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Block Clients | NordTeck";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormBlockClients_FormClosed);
			base.Load += new global::System.EventHandler(this.FormBlockClients_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000164 RID: 356
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.ListBox listBlocked;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400016A RID: 362
		public global::System.Windows.Forms.TextBox txtBlock;
	}
}
