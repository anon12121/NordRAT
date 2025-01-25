namespace Server.Forms
{
	// Token: 0x02000069 RID: 105
	public partial class FormFileSearcher : global::System.Windows.Forms.Form
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0001C18C File Offset: 0x0001A38C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileSearcher));
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtExtnsions = new global::System.Windows.Forms.TextBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Extensions:";
			this.txtExtnsions.Location = new global::System.Drawing.Point(16, 71);
			this.txtExtnsions.Name = "txtExtnsions";
			this.txtExtnsions.Size = new global::System.Drawing.Size(547, 26);
			this.txtExtnsions.TabIndex = 1;
			this.txtExtnsions.Text = ".txt .pdf .doc";
			this.btnOk.Location = new global::System.Drawing.Point(427, 129);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(136, 49);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 120);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(126, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max upload size:";
			this.numericUpDown1.Location = new global::System.Drawing.Point(16, 152);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 200;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(99, 26);
			this.numericUpDown1.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 5;
			numericUpDown3.Value = new decimal(array3);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f);
			this.label3.Location = new global::System.Drawing.Point(129, 156);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(28, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "MB";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(575, 214);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.txtExtnsions);
			base.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormFileSearcher";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "File Searcher - Search and upload a file by it extension";
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400021A RID: 538
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400021F RID: 543
		public global::System.Windows.Forms.TextBox txtExtnsions;

		// Token: 0x04000220 RID: 544
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
