namespace Server.Forms
{
	// Token: 0x0200006E RID: 110
	public partial class FormProcessManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600027B RID: 635 RVA: 0x0001DE6C File Offset: 0x0001C06C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001DE8C File Offset: 0x0001C08C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormProcessManager));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.lv_name = new global::System.Windows.Forms.ColumnHeader();
			this.lv_id = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.killToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.lv_name,
				this.lv_id
			});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.Enabled = false;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(500, 577);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.lv_name.Text = "Name";
			this.lv_name.Width = 281;
			this.lv_id.Text = "ID";
			this.lv_id.Width = 150;
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.killToolStripMenuItem,
				this.refreshToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(144, 68);
			this.killToolStripMenuItem.Name = "killToolStripMenuItem";
			this.killToolStripMenuItem.Size = new global::System.Drawing.Size(143, 32);
			this.killToolStripMenuItem.Text = "Kill";
			this.killToolStripMenuItem.Click += new global::System.EventHandler(this.killToolStripMenuItem_Click);
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new global::System.Drawing.Size(143, 32);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new global::System.EventHandler(this.refreshToolStripMenuItem_Click);
			this.imageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(500, 577);
			base.Controls.Add(this.listView1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormProcessManager";
			this.Text = "ProcessManager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormProcessManager_FormClosed);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400024A RID: 586
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.ColumnHeader lv_name;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.ColumnHeader lv_id;

		// Token: 0x0400024D RID: 589
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400024E RID: 590
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

		// Token: 0x04000252 RID: 594
		public global::System.Windows.Forms.Timer timer1;
	}
}
