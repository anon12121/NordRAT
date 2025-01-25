namespace Server.Forms
{
	// Token: 0x02000067 RID: 103
	public partial class FormFileManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0001B1EC File Offset: 0x000193EC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001B20C File Offset: 0x0001940C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewGroup listViewGroup = new global::System.Windows.Forms.ListViewGroup("Folders", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.Windows.Forms.ListViewGroup listViewGroup2 = new global::System.Windows.Forms.ListViewGroup("File", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileManager));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.backToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rEFRESHToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gOTOToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dESKTOPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aPPDATAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.userProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.driversListsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.downloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uPLOADToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.eXECUTEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dELETEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sevenZiplStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.installToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.zipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.unzipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.createFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.openClientFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.AllowColumnReorder = true;
			this.listView1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			listViewGroup.Header = "Folders";
			listViewGroup.Name = "Folders";
			listViewGroup2.Header = "File";
			listViewGroup2.Name = "File";
			this.listView1.Groups.AddRange(new global::System.Windows.Forms.ListViewGroup[]
			{
				listViewGroup,
				listViewGroup2
			});
			this.listView1.HideSelection = false;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new global::System.Drawing.Point(0, 1);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(1058, 511);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Tile;
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backToolStripMenuItem,
				this.rEFRESHToolStripMenuItem,
				this.gOTOToolStripMenuItem,
				this.toolStripSeparator1,
				this.downloadToolStripMenuItem,
				this.uPLOADToolStripMenuItem,
				this.eXECUTEToolStripMenuItem,
				this.renameToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.cutToolStripMenuItem1,
				this.pasteToolStripMenuItem,
				this.dELETEToolStripMenuItem,
				this.toolStripSeparator4,
				this.sevenZiplStripMenuItem1,
				this.toolStripSeparator5,
				this.createFolderToolStripMenuItem,
				this.toolStripSeparator3,
				this.openClientFolderToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(233, 476);
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new global::System.EventHandler(this.backToolStripMenuItem_Click);
			this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
			this.rEFRESHToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.rEFRESHToolStripMenuItem.Text = "Refresh";
			this.rEFRESHToolStripMenuItem.Click += new global::System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
			this.gOTOToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.dESKTOPToolStripMenuItem,
				this.aPPDATAToolStripMenuItem,
				this.userProfileToolStripMenuItem,
				this.toolStripSeparator2,
				this.driversListsToolStripMenuItem
			});
			this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
			this.gOTOToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.gOTOToolStripMenuItem.Text = "Go To";
			this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
			this.dESKTOPToolStripMenuItem.Size = new global::System.Drawing.Size(204, 34);
			this.dESKTOPToolStripMenuItem.Text = "Desktop";
			this.dESKTOPToolStripMenuItem.Click += new global::System.EventHandler(this.DESKTOPToolStripMenuItem_Click);
			this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
			this.aPPDATAToolStripMenuItem.Size = new global::System.Drawing.Size(204, 34);
			this.aPPDATAToolStripMenuItem.Text = "AppData";
			this.aPPDATAToolStripMenuItem.Click += new global::System.EventHandler(this.APPDATAToolStripMenuItem_Click);
			this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
			this.userProfileToolStripMenuItem.Size = new global::System.Drawing.Size(204, 34);
			this.userProfileToolStripMenuItem.Text = "User Profile";
			this.userProfileToolStripMenuItem.Click += new global::System.EventHandler(this.UserProfileToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(201, 6);
			this.driversListsToolStripMenuItem.Name = "driversListsToolStripMenuItem";
			this.driversListsToolStripMenuItem.Size = new global::System.Drawing.Size(204, 34);
			this.driversListsToolStripMenuItem.Text = "Drivers";
			this.driversListsToolStripMenuItem.Click += new global::System.EventHandler(this.DriversListsToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(229, 6);
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.downloadToolStripMenuItem.Text = "Download";
			this.downloadToolStripMenuItem.Click += new global::System.EventHandler(this.downloadToolStripMenuItem_Click);
			this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
			this.uPLOADToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.uPLOADToolStripMenuItem.Text = "Upload";
			this.uPLOADToolStripMenuItem.Click += new global::System.EventHandler(this.uPLOADToolStripMenuItem_Click);
			this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
			this.eXECUTEToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.eXECUTEToolStripMenuItem.Text = "Execute";
			this.eXECUTEToolStripMenuItem.Click += new global::System.EventHandler(this.eXECUTEToolStripMenuItem_Click);
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new global::System.EventHandler(this.RenameToolStripMenuItem_Click);
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			this.cutToolStripMenuItem1.Size = new global::System.Drawing.Size(232, 32);
			this.cutToolStripMenuItem1.Text = "Cut";
			this.cutToolStripMenuItem1.Click += new global::System.EventHandler(this.CutToolStripMenuItem1_Click);
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click_1);
			this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
			this.dELETEToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.dELETEToolStripMenuItem.Text = "Delete";
			this.dELETEToolStripMenuItem.Click += new global::System.EventHandler(this.dELETEToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(229, 6);
			this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.installToolStripMenuItem,
				this.toolStripSeparator6,
				this.zipToolStripMenuItem,
				this.unzipToolStripMenuItem
			});
			this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
			this.sevenZiplStripMenuItem1.Size = new global::System.Drawing.Size(232, 32);
			this.sevenZiplStripMenuItem1.Text = "7-Zip";
			this.installToolStripMenuItem.Name = "installToolStripMenuItem";
			this.installToolStripMenuItem.Size = new global::System.Drawing.Size(263, 34);
			this.installToolStripMenuItem.Text = "Hidden Installation";
			this.installToolStripMenuItem.Click += new global::System.EventHandler(this.InstallToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(260, 6);
			this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
			this.zipToolStripMenuItem.Size = new global::System.Drawing.Size(263, 34);
			this.zipToolStripMenuItem.Text = "Zip";
			this.zipToolStripMenuItem.Click += new global::System.EventHandler(this.ZipToolStripMenuItem_Click);
			this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
			this.unzipToolStripMenuItem.Size = new global::System.Drawing.Size(263, 34);
			this.unzipToolStripMenuItem.Text = "Unzip";
			this.unzipToolStripMenuItem.Click += new global::System.EventHandler(this.UnzipToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(229, 6);
			this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
			this.createFolderToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.createFolderToolStripMenuItem.Text = "Create Folder";
			this.createFolderToolStripMenuItem.Click += new global::System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(229, 6);
			this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
			this.openClientFolderToolStripMenuItem.Size = new global::System.Drawing.Size(232, 32);
			this.openClientFolderToolStripMenuItem.Text = "Open Client Folder";
			this.openClientFolderToolStripMenuItem.Click += new global::System.EventHandler(this.OpenClientFolderToolStripMenuItem_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
			this.imageList1.Images.SetKeyName(1, "AsyncHDDFixed.png");
			this.imageList1.Images.SetKeyName(2, "AsyncUSB.png");
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1,
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel3
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 513);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(1058, 32);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(20, 25);
			this.toolStripStatusLabel1.Text = "..";
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(20, 25);
			this.toolStripStatusLabel2.Text = "..";
			this.toolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(20, 25);
			this.toolStripStatusLabel3.Text = "..";
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1058, 545);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.listView1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormFileManager";
			this.Text = "FileManager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormFileManager_FormClosed);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001F2 RID: 498
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001F3 RID: 499
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x040001F4 RID: 500
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;

		// Token: 0x040001F7 RID: 503
		public global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040001F8 RID: 504
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x040001F9 RID: 505
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.ToolStripMenuItem uPLOADToolStripMenuItem;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.ToolStripMenuItem eXECUTEToolStripMenuItem;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.ToolStripMenuItem dESKTOPToolStripMenuItem;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.ToolStripMenuItem aPPDATAToolStripMenuItem;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x04000208 RID: 520
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Forms.ToolStripMenuItem driversListsToolStripMenuItem;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;

		// Token: 0x0400020E RID: 526
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.ToolStripMenuItem sevenZiplStripMenuItem1;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.ColumnHeader columnHeader2;
	}
}
