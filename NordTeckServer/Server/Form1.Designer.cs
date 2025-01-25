namespace Server
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000573C File Offset: 0x0000393C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000575C File Offset: 0x0000395C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Form1));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.lv_ip = new global::System.Windows.Forms.ColumnHeader();
			this.lv_country = new global::System.Windows.Forms.ColumnHeader();
			this.lv_group = new global::System.Windows.Forms.ColumnHeader();
			this.lv_hwid = new global::System.Windows.Forms.ColumnHeader();
			this.lv_user = new global::System.Windows.Forms.ColumnHeader();
			this.lv_os = new global::System.Windows.Forms.ColumnHeader();
			this.lv_version = new global::System.Windows.Forms.ColumnHeader();
			this.lv_ins = new global::System.Windows.Forms.ColumnHeader();
			this.lv_admin = new global::System.Windows.Forms.ColumnHeader();
			this.lv_av = new global::System.Windows.Forms.ColumnHeader();
			this.lv_ping = new global::System.Windows.Forms.ColumnHeader();
			this.lv_act = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuClient = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.aBOUTToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sENDFILEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tOMEMORYToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tODISKToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.monitoringToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.remoteDesktopToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.keyloggerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passwordRecoveryToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fileManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.processManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.reportWindowToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.webcamToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.miscellaneousToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.botsKillerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uSBSpreadToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.seedTorrentToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.remoteShellToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dOSAttackToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.executeNETCodeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xMRMinerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.killToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.filesSearcherToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.extraToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.visitWebsiteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sendMessageBoxToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chatToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.getAdminPrivilegesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.blankScreenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.disableWindowsDefenderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.setWallpaperToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.systemToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pCToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.serverToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.blockClientsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.bUILDERToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ping = new global::System.Windows.Forms.Timer(this.components);
			this.UpdateUI = new global::System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuLogs = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cLEARToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.listView3 = new global::System.Windows.Forms.ListView();
			this.contextMenuThumbnail = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.sTARTToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sTOPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ThumbnailImageList = new global::System.Windows.Forms.ImageList(this.components);
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.listView4 = new global::System.Windows.Forms.ListView();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuTasks = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.pASSWORDRECOVERYToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.downloadAndExecuteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sENDFILETOMEMORYToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.minerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uPDATEToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.dELETETASKToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.performanceCounter1 = new global::System.Diagnostics.PerformanceCounter();
			this.performanceCounter2 = new global::System.Diagnostics.PerformanceCounter();
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.TimerTask = new global::System.Windows.Forms.Timer(this.components);
			this.shutdownToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.restartToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.logoffToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.restartToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uninstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.showFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.clientToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuClient.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.contextMenuLogs.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.contextMenuThumbnail.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.contextMenuTasks.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).BeginInit();
			base.SuspendLayout();
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.lv_ip,
				this.lv_country,
				this.lv_group,
				this.lv_hwid,
				this.lv_user,
				this.lv_os,
				this.lv_version,
				this.lv_ins,
				this.lv_admin,
				this.lv_av,
				this.lv_ping,
				this.lv_act
			});
			this.listView1.ContextMenuStrip = this.contextMenuClient;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(3, 3);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(1287, 440);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
			this.listView1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
			this.listView1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
			this.lv_ip.Text = "IP Address";
			this.lv_ip.Width = 121;
			this.lv_country.Text = "Country";
			this.lv_country.Width = 124;
			this.lv_group.Text = "Group";
			this.lv_group.Width = 110;
			this.lv_hwid.Text = "HWID";
			this.lv_hwid.Width = 117;
			this.lv_user.Text = "Username";
			this.lv_user.Width = 117;
			this.lv_os.Text = "Operating System";
			this.lv_os.Width = 179;
			this.lv_version.Text = "Payload Version";
			this.lv_version.Width = 126;
			this.lv_ins.Text = "Installed";
			this.lv_ins.Width = 120;
			this.lv_admin.Text = "Privileges";
			this.lv_admin.Width = 166;
			this.lv_av.Text = "Anti-Virus Software";
			this.lv_av.Width = 136;
			this.lv_ping.Text = "Ping";
			this.lv_act.Text = "Active Window";
			this.lv_act.Width = 350;
			this.contextMenuClient.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuClient.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.aBOUTToolStripMenuItem,
				this.toolStripSeparator2,
				this.sENDFILEToolStripMenuItem,
				this.monitoringToolStripMenuItem,
				this.miscellaneousToolStripMenuItem,
				this.extraToolStripMenuItem,
				this.systemToolStripMenuItem,
				this.toolStripSeparator1,
				this.serverToolStripMenuItem,
				this.toolStripSeparator5,
				this.bUILDERToolStripMenuItem
			});
			this.contextMenuClient.Name = "contextMenuStrip1";
			this.contextMenuClient.Size = new global::System.Drawing.Size(238, 278);
			this.aBOUTToolStripMenuItem.Image = global::Server.Properties.Resources.info;
			this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
			this.aBOUTToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.aBOUTToolStripMenuItem.Text = "ABOUT";
			this.aBOUTToolStripMenuItem.Click += new global::System.EventHandler(this.ABOUTToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(199, 6);
			this.sENDFILEToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tOMEMORYToolStripMenuItem,
				this.tODISKToolStripMenuItem
			});
			this.sENDFILEToolStripMenuItem.Image = global::Server.Properties.Resources.tomem;
			this.sENDFILEToolStripMenuItem.Name = "sENDFILEToolStripMenuItem";
			this.sENDFILEToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.sENDFILEToolStripMenuItem.Text = "Send File";
			this.tOMEMORYToolStripMenuItem.Image = global::Server.Properties.Resources.tomem1;
			this.tOMEMORYToolStripMenuItem.Name = "tOMEMORYToolStripMenuItem";
			this.tOMEMORYToolStripMenuItem.Size = new global::System.Drawing.Size(206, 34);
			this.tOMEMORYToolStripMenuItem.Text = "To Memory";
			this.tOMEMORYToolStripMenuItem.Click += new global::System.EventHandler(this.TOMEMORYToolStripMenuItem_Click);
			this.tODISKToolStripMenuItem.Image = global::Server.Properties.Resources.tomem1;
			this.tODISKToolStripMenuItem.Name = "tODISKToolStripMenuItem";
			this.tODISKToolStripMenuItem.Size = new global::System.Drawing.Size(206, 34);
			this.tODISKToolStripMenuItem.Text = "To Disk";
			this.tODISKToolStripMenuItem.Click += new global::System.EventHandler(this.TODISKToolStripMenuItem_Click);
			this.monitoringToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.remoteDesktopToolStripMenuItem1,
				this.keyloggerToolStripMenuItem1,
				this.passwordRecoveryToolStripMenuItem1,
				this.fileManagerToolStripMenuItem1,
				this.processManagerToolStripMenuItem1,
				this.reportWindowToolStripMenuItem,
				this.webcamToolStripMenuItem
			});
			this.monitoringToolStripMenuItem.Image = global::Server.Properties.Resources.monitoring_system;
			this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
			this.monitoringToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.monitoringToolStripMenuItem.Text = "Monitoring";
			this.remoteDesktopToolStripMenuItem1.Image = global::Server.Properties.Resources.remotedesktop;
			this.remoteDesktopToolStripMenuItem1.Name = "remoteDesktopToolStripMenuItem1";
			this.remoteDesktopToolStripMenuItem1.Size = new global::System.Drawing.Size(267, 34);
			this.remoteDesktopToolStripMenuItem1.Text = "Remote Desktop";
			this.remoteDesktopToolStripMenuItem1.Click += new global::System.EventHandler(this.RemoteDesktopToolStripMenuItem1_Click);
			this.keyloggerToolStripMenuItem1.Image = global::Server.Properties.Resources.logger;
			this.keyloggerToolStripMenuItem1.Name = "keyloggerToolStripMenuItem1";
			this.keyloggerToolStripMenuItem1.Size = new global::System.Drawing.Size(267, 34);
			this.keyloggerToolStripMenuItem1.Text = "Keylogger";
			this.keyloggerToolStripMenuItem1.Click += new global::System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
			this.passwordRecoveryToolStripMenuItem1.Image = global::Server.Properties.Resources.key;
			this.passwordRecoveryToolStripMenuItem1.Name = "passwordRecoveryToolStripMenuItem1";
			this.passwordRecoveryToolStripMenuItem1.Size = new global::System.Drawing.Size(267, 34);
			this.passwordRecoveryToolStripMenuItem1.Text = "Password Recovery";
			this.passwordRecoveryToolStripMenuItem1.Click += new global::System.EventHandler(this.PasswordRecoveryToolStripMenuItem1_Click);
			this.fileManagerToolStripMenuItem1.Image = global::Server.Properties.Resources.filemanager;
			this.fileManagerToolStripMenuItem1.Name = "fileManagerToolStripMenuItem1";
			this.fileManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(267, 34);
			this.fileManagerToolStripMenuItem1.Text = "File Manager";
			this.fileManagerToolStripMenuItem1.Click += new global::System.EventHandler(this.FileManagerToolStripMenuItem1_Click);
			this.processManagerToolStripMenuItem1.Image = global::Server.Properties.Resources.process;
			this.processManagerToolStripMenuItem1.Name = "processManagerToolStripMenuItem1";
			this.processManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(267, 34);
			this.processManagerToolStripMenuItem1.Text = "Process Manager";
			this.processManagerToolStripMenuItem1.Click += new global::System.EventHandler(this.ProcessManagerToolStripMenuItem1_Click);
			this.reportWindowToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.runToolStripMenuItem1,
				this.stopToolStripMenuItem2
			});
			this.reportWindowToolStripMenuItem.Image = global::Server.Properties.Resources.report;
			this.reportWindowToolStripMenuItem.Name = "reportWindowToolStripMenuItem";
			this.reportWindowToolStripMenuItem.Size = new global::System.Drawing.Size(267, 34);
			this.reportWindowToolStripMenuItem.Text = "Report Window";
			this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
			this.runToolStripMenuItem1.Size = new global::System.Drawing.Size(152, 34);
			this.runToolStripMenuItem1.Text = "Run";
			this.runToolStripMenuItem1.Click += new global::System.EventHandler(this.RunToolStripMenuItem1_Click);
			this.stopToolStripMenuItem2.Name = "stopToolStripMenuItem2";
			this.stopToolStripMenuItem2.Size = new global::System.Drawing.Size(152, 34);
			this.stopToolStripMenuItem2.Text = "Stop";
			this.stopToolStripMenuItem2.Click += new global::System.EventHandler(this.StopToolStripMenuItem2_Click);
			this.webcamToolStripMenuItem.Image = global::Server.Properties.Resources.webcam;
			this.webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
			this.webcamToolStripMenuItem.Size = new global::System.Drawing.Size(267, 34);
			this.webcamToolStripMenuItem.Text = "Webcam";
			this.webcamToolStripMenuItem.Click += new global::System.EventHandler(this.WebcamToolStripMenuItem_Click);
			this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.botsKillerToolStripMenuItem,
				this.uSBSpreadToolStripMenuItem1,
				this.seedTorrentToolStripMenuItem1,
				this.remoteShellToolStripMenuItem1,
				this.dOSAttackToolStripMenuItem,
				this.executeNETCodeToolStripMenuItem,
				this.xMRMinerToolStripMenuItem,
				this.filesSearcherToolStripMenuItem
			});
			this.miscellaneousToolStripMenuItem.Image = global::Server.Properties.Resources.Miscellaneous;
			this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
			this.miscellaneousToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
			this.botsKillerToolStripMenuItem.Image = global::Server.Properties.Resources.botkiller;
			this.botsKillerToolStripMenuItem.Name = "botsKillerToolStripMenuItem";
			this.botsKillerToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.botsKillerToolStripMenuItem.Text = "Bots Killer";
			this.botsKillerToolStripMenuItem.Click += new global::System.EventHandler(this.BotsKillerToolStripMenuItem_Click);
			this.uSBSpreadToolStripMenuItem1.Image = global::Server.Properties.Resources.usb;
			this.uSBSpreadToolStripMenuItem1.Name = "uSBSpreadToolStripMenuItem1";
			this.uSBSpreadToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.uSBSpreadToolStripMenuItem1.Text = "USB Spread";
			this.uSBSpreadToolStripMenuItem1.Click += new global::System.EventHandler(this.USBSpreadToolStripMenuItem1_Click);
			this.seedTorrentToolStripMenuItem1.Image = global::Server.Properties.Resources.u_torrent_logo;
			this.seedTorrentToolStripMenuItem1.Name = "seedTorrentToolStripMenuItem1";
			this.seedTorrentToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.seedTorrentToolStripMenuItem1.Text = "Seed Torrent";
			this.seedTorrentToolStripMenuItem1.Click += new global::System.EventHandler(this.SeedTorrentToolStripMenuItem1_Click_1);
			this.remoteShellToolStripMenuItem1.Image = global::Server.Properties.Resources.shell;
			this.remoteShellToolStripMenuItem1.Name = "remoteShellToolStripMenuItem1";
			this.remoteShellToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.remoteShellToolStripMenuItem1.Text = "Remote Shell";
			this.remoteShellToolStripMenuItem1.Click += new global::System.EventHandler(this.RemoteShellToolStripMenuItem1_Click_1);
			this.dOSAttackToolStripMenuItem.Image = global::Server.Properties.Resources.ddos;
			this.dOSAttackToolStripMenuItem.Name = "dOSAttackToolStripMenuItem";
			this.dOSAttackToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.dOSAttackToolStripMenuItem.Text = "DOS Attack";
			this.dOSAttackToolStripMenuItem.Click += new global::System.EventHandler(this.DOSAttackToolStripMenuItem_Click_1);
			this.executeNETCodeToolStripMenuItem.Image = global::Server.Properties.Resources.coding;
			this.executeNETCodeToolStripMenuItem.Name = "executeNETCodeToolStripMenuItem";
			this.executeNETCodeToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.executeNETCodeToolStripMenuItem.Text = "Execute .NET Code";
			this.executeNETCodeToolStripMenuItem.Click += new global::System.EventHandler(this.ExecuteNETCodeToolStripMenuItem_Click_1);
			this.xMRMinerToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.runToolStripMenuItem,
				this.killToolStripMenuItem
			});
			this.xMRMinerToolStripMenuItem.Image = global::Server.Properties.Resources.xmr;
			this.xMRMinerToolStripMenuItem.Name = "xMRMinerToolStripMenuItem";
			this.xMRMinerToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.xMRMinerToolStripMenuItem.Text = "XMR Miner";
			this.xMRMinerToolStripMenuItem.Visible = false;
			this.runToolStripMenuItem.Image = global::Server.Properties.Resources.play_button;
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new global::System.Drawing.Size(152, 34);
			this.runToolStripMenuItem.Text = "Run";
			this.runToolStripMenuItem.Click += new global::System.EventHandler(this.RunToolStripMenuItem_Click);
			this.killToolStripMenuItem.Image = global::Server.Properties.Resources.stop__1_;
			this.killToolStripMenuItem.Name = "killToolStripMenuItem";
			this.killToolStripMenuItem.Size = new global::System.Drawing.Size(152, 34);
			this.killToolStripMenuItem.Text = "Stop";
			this.killToolStripMenuItem.Click += new global::System.EventHandler(this.KillToolStripMenuItem_Click);
			this.filesSearcherToolStripMenuItem.Image = global::Server.Properties.Resources.report;
			this.filesSearcherToolStripMenuItem.Name = "filesSearcherToolStripMenuItem";
			this.filesSearcherToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.filesSearcherToolStripMenuItem.Text = "Files Searcher";
			this.filesSearcherToolStripMenuItem.Click += new global::System.EventHandler(this.filesSearcherToolStripMenuItem_Click);
			this.extraToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.visitWebsiteToolStripMenuItem1,
				this.sendMessageBoxToolStripMenuItem1,
				this.chatToolStripMenuItem1,
				this.getAdminPrivilegesToolStripMenuItem,
				this.blankScreenToolStripMenuItem,
				this.disableWindowsDefenderToolStripMenuItem,
				this.setWallpaperToolStripMenuItem
			});
			this.extraToolStripMenuItem.Image = global::Server.Properties.Resources.extra;
			this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
			this.extraToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.extraToolStripMenuItem.Text = "Extra";
			this.visitWebsiteToolStripMenuItem1.Image = global::Server.Properties.Resources.visit;
			this.visitWebsiteToolStripMenuItem1.Name = "visitWebsiteToolStripMenuItem1";
			this.visitWebsiteToolStripMenuItem1.Size = new global::System.Drawing.Size(329, 34);
			this.visitWebsiteToolStripMenuItem1.Text = "Visit Website";
			this.visitWebsiteToolStripMenuItem1.Click += new global::System.EventHandler(this.VisitWebsiteToolStripMenuItem1_Click);
			this.sendMessageBoxToolStripMenuItem1.Image = global::Server.Properties.Resources.msgbox;
			this.sendMessageBoxToolStripMenuItem1.Name = "sendMessageBoxToolStripMenuItem1";
			this.sendMessageBoxToolStripMenuItem1.Size = new global::System.Drawing.Size(329, 34);
			this.sendMessageBoxToolStripMenuItem1.Text = "Send MessageBox";
			this.sendMessageBoxToolStripMenuItem1.Click += new global::System.EventHandler(this.SendMessageBoxToolStripMenuItem1_Click);
			this.chatToolStripMenuItem1.Image = global::Server.Properties.Resources.chat;
			this.chatToolStripMenuItem1.Name = "chatToolStripMenuItem1";
			this.chatToolStripMenuItem1.Size = new global::System.Drawing.Size(329, 34);
			this.chatToolStripMenuItem1.Text = "Chat";
			this.chatToolStripMenuItem1.Click += new global::System.EventHandler(this.ChatToolStripMenuItem1_Click);
			this.getAdminPrivilegesToolStripMenuItem.Image = global::Server.Properties.Resources.uac;
			this.getAdminPrivilegesToolStripMenuItem.Name = "getAdminPrivilegesToolStripMenuItem";
			this.getAdminPrivilegesToolStripMenuItem.Size = new global::System.Drawing.Size(329, 34);
			this.getAdminPrivilegesToolStripMenuItem.Text = "Get Admin Privileges";
			this.getAdminPrivilegesToolStripMenuItem.Click += new global::System.EventHandler(this.GetAdminPrivilegesToolStripMenuItem_Click_1);
			this.blankScreenToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.runToolStripMenuItem2,
				this.stopToolStripMenuItem1
			});
			this.blankScreenToolStripMenuItem.Image = global::Server.Properties.Resources.blank_screen;
			this.blankScreenToolStripMenuItem.Name = "blankScreenToolStripMenuItem";
			this.blankScreenToolStripMenuItem.Size = new global::System.Drawing.Size(329, 34);
			this.blankScreenToolStripMenuItem.Text = "Blank Screen";
			this.runToolStripMenuItem2.Image = global::Server.Properties.Resources.play_button;
			this.runToolStripMenuItem2.Name = "runToolStripMenuItem2";
			this.runToolStripMenuItem2.Size = new global::System.Drawing.Size(152, 34);
			this.runToolStripMenuItem2.Text = "Run";
			this.runToolStripMenuItem2.Click += new global::System.EventHandler(this.RunToolStripMenuItem2_Click);
			this.stopToolStripMenuItem1.Image = global::Server.Properties.Resources.stop__1_;
			this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
			this.stopToolStripMenuItem1.Size = new global::System.Drawing.Size(152, 34);
			this.stopToolStripMenuItem1.Text = "Stop";
			this.stopToolStripMenuItem1.Click += new global::System.EventHandler(this.StopToolStripMenuItem1_Click);
			this.disableWindowsDefenderToolStripMenuItem.Image = global::Server.Properties.Resources.disabled;
			this.disableWindowsDefenderToolStripMenuItem.Name = "disableWindowsDefenderToolStripMenuItem";
			this.disableWindowsDefenderToolStripMenuItem.Size = new global::System.Drawing.Size(329, 34);
			this.disableWindowsDefenderToolStripMenuItem.Text = "Disable Windows Defender";
			this.disableWindowsDefenderToolStripMenuItem.Click += new global::System.EventHandler(this.DisableWindowsDefenderToolStripMenuItem_Click_1);
			this.setWallpaperToolStripMenuItem.Image = global::Server.Properties.Resources.iconfinder_32_171485__1_;
			this.setWallpaperToolStripMenuItem.Name = "setWallpaperToolStripMenuItem";
			this.setWallpaperToolStripMenuItem.Size = new global::System.Drawing.Size(329, 34);
			this.setWallpaperToolStripMenuItem.Text = "Set Wallpaper";
			this.setWallpaperToolStripMenuItem.Click += new global::System.EventHandler(this.setWallpaperToolStripMenuItem_Click);
			this.systemToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.clientToolStripMenuItem,
				this.pCToolStripMenuItem
			});
			this.systemToolStripMenuItem.Image = global::Server.Properties.Resources.system;
			this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
			this.systemToolStripMenuItem.Size = new global::System.Drawing.Size(237, 32);
			this.systemToolStripMenuItem.Text = "Client Managment";
			this.pCToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.logoffToolStripMenuItem1,
				this.restartToolStripMenuItem3,
				this.shutdownToolStripMenuItem1
			});
			this.pCToolStripMenuItem.Image = global::Server.Properties.Resources.pc;
			this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
			this.pCToolStripMenuItem.Size = new global::System.Drawing.Size(158, 34);
			this.pCToolStripMenuItem.Text = "PC";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(199, 6);
			this.serverToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.blockClientsToolStripMenuItem
			});
			this.serverToolStripMenuItem.Image = global::Server.Properties.Resources.server;
			this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
			this.serverToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.serverToolStripMenuItem.Text = "Server";
			this.blockClientsToolStripMenuItem.Image = global::Server.Properties.Resources.disabled;
			this.blockClientsToolStripMenuItem.Name = "blockClientsToolStripMenuItem";
			this.blockClientsToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.blockClientsToolStripMenuItem.Text = "Block Clients";
			this.blockClientsToolStripMenuItem.Click += new global::System.EventHandler(this.BlockClientsToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(199, 6);
			this.bUILDERToolStripMenuItem.Image = global::Server.Properties.Resources.builder;
			this.bUILDERToolStripMenuItem.Name = "bUILDERToolStripMenuItem";
			this.bUILDERToolStripMenuItem.Size = new global::System.Drawing.Size(202, 32);
			this.bUILDERToolStripMenuItem.Text = "BUILDER";
			this.bUILDERToolStripMenuItem.Click += new global::System.EventHandler(this.bUILDERToolStripMenuItem_Click);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 479);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(1301, 32);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(179, 25);
			this.toolStripStatusLabel2.Text = "[Notification]             ";
			this.toolStripStatusLabel2.Click += new global::System.EventHandler(this.ToolStripStatusLabel2_Click);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(24, 25);
			this.toolStripStatusLabel1.Text = "...";
			this.ping.Enabled = true;
			this.ping.Interval = 30000;
			this.ping.Tick += new global::System.EventHandler(this.ping_Tick);
			this.UpdateUI.Enabled = true;
			this.UpdateUI.Interval = 500;
			this.UpdateUI.Tick += new global::System.EventHandler(this.UpdateUI_Tick);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(1301, 479);
			this.tabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 2;
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(1293, 446);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Clients";
			this.tabPage2.Controls.Add(this.listView2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(1293, 446);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Logs";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.listView2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.listView2.ContextMenuStrip = this.contextMenuLogs;
			this.listView2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(3, 3);
			this.listView2.Name = "listView2";
			this.listView2.ShowGroups = false;
			this.listView2.ShowItemToolTips = true;
			this.listView2.Size = new global::System.Drawing.Size(1287, 440);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "Time";
			this.columnHeader1.Width = 150;
			this.columnHeader2.Text = "Message";
			this.columnHeader2.Width = 1078;
			this.contextMenuLogs.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuLogs.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cLEARToolStripMenuItem
			});
			this.contextMenuLogs.Name = "contextMenuLogs";
			this.contextMenuLogs.ShowImageMargin = false;
			this.contextMenuLogs.Size = new global::System.Drawing.Size(111, 36);
			this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
			this.cLEARToolStripMenuItem.Size = new global::System.Drawing.Size(110, 32);
			this.cLEARToolStripMenuItem.Text = "CLEAR";
			this.cLEARToolStripMenuItem.Click += new global::System.EventHandler(this.CLEARToolStripMenuItem_Click);
			this.tabPage3.Controls.Add(this.listView3);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new global::System.Drawing.Size(1293, 446);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Thumbnail";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.listView3.ContextMenuStrip = this.contextMenuThumbnail;
			this.listView3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView3.HideSelection = false;
			this.listView3.LargeImageList = this.ThumbnailImageList;
			this.listView3.Location = new global::System.Drawing.Point(0, 0);
			this.listView3.Name = "listView3";
			this.listView3.ShowItemToolTips = true;
			this.listView3.Size = new global::System.Drawing.Size(1293, 446);
			this.listView3.SmallImageList = this.ThumbnailImageList;
			this.listView3.TabIndex = 0;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.contextMenuThumbnail.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuThumbnail.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sTARTToolStripMenuItem,
				this.sTOPToolStripMenuItem
			});
			this.contextMenuThumbnail.Name = "contextMenuStrip2";
			this.contextMenuThumbnail.Size = new global::System.Drawing.Size(144, 68);
			this.sTARTToolStripMenuItem.Image = global::Server.Properties.Resources.play_button;
			this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
			this.sTARTToolStripMenuItem.Size = new global::System.Drawing.Size(143, 32);
			this.sTARTToolStripMenuItem.Text = "START";
			this.sTARTToolStripMenuItem.Click += new global::System.EventHandler(this.STARTToolStripMenuItem_Click);
			this.sTOPToolStripMenuItem.Image = global::Server.Properties.Resources.stop__1_;
			this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
			this.sTOPToolStripMenuItem.Size = new global::System.Drawing.Size(143, 32);
			this.sTOPToolStripMenuItem.Text = "STOP";
			this.sTOPToolStripMenuItem.Click += new global::System.EventHandler(this.STOPToolStripMenuItem_Click);
			this.ThumbnailImageList.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ThumbnailImageList.ImageSize = new global::System.Drawing.Size(256, 256);
			this.ThumbnailImageList.TransparentColor = global::System.Drawing.Color.Transparent;
			this.tabPage4.Controls.Add(this.listView4);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(1293, 446);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Tasks";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.listView4.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView4.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader4,
				this.columnHeader5
			});
			this.listView4.ContextMenuStrip = this.contextMenuTasks;
			this.listView4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView4.FullRowSelect = true;
			this.listView4.HideSelection = false;
			this.listView4.Location = new global::System.Drawing.Point(3, 3);
			this.listView4.Name = "listView4";
			this.listView4.Size = new global::System.Drawing.Size(1287, 440);
			this.listView4.TabIndex = 0;
			this.listView4.UseCompatibleStateImageBehavior = false;
			this.listView4.View = global::System.Windows.Forms.View.Details;
			this.columnHeader4.Text = "Task";
			this.columnHeader4.Width = 97;
			this.columnHeader5.Text = "Execution";
			this.columnHeader5.Width = 116;
			this.contextMenuTasks.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuTasks.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.pASSWORDRECOVERYToolStripMenuItem,
				this.downloadAndExecuteToolStripMenuItem,
				this.sENDFILETOMEMORYToolStripMenuItem1,
				this.minerToolStripMenuItem1,
				this.uPDATEToolStripMenuItem1,
				this.toolStripSeparator4,
				this.dELETETASKToolStripMenuItem
			});
			this.contextMenuTasks.Name = "contextMenuStrip4";
			this.contextMenuTasks.ShowImageMargin = false;
			this.contextMenuTasks.Size = new global::System.Drawing.Size(250, 202);
			this.pASSWORDRECOVERYToolStripMenuItem.Name = "pASSWORDRECOVERYToolStripMenuItem";
			this.pASSWORDRECOVERYToolStripMenuItem.Size = new global::System.Drawing.Size(249, 32);
			this.pASSWORDRECOVERYToolStripMenuItem.Text = "PASSWORD RECOVERY";
			this.pASSWORDRECOVERYToolStripMenuItem.Click += new global::System.EventHandler(this.PASSWORDRECOVERYToolStripMenuItem_Click);
			this.downloadAndExecuteToolStripMenuItem.Name = "downloadAndExecuteToolStripMenuItem";
			this.downloadAndExecuteToolStripMenuItem.Size = new global::System.Drawing.Size(249, 32);
			this.downloadAndExecuteToolStripMenuItem.Text = "SEND FILE TO DISK";
			this.downloadAndExecuteToolStripMenuItem.Click += new global::System.EventHandler(this.DownloadAndExecuteToolStripMenuItem_Click);
			this.sENDFILETOMEMORYToolStripMenuItem1.Name = "sENDFILETOMEMORYToolStripMenuItem1";
			this.sENDFILETOMEMORYToolStripMenuItem1.Size = new global::System.Drawing.Size(249, 32);
			this.sENDFILETOMEMORYToolStripMenuItem1.Text = "SEND FILE TO MEMORY";
			this.sENDFILETOMEMORYToolStripMenuItem1.Click += new global::System.EventHandler(this.SENDFILETOMEMORYToolStripMenuItem1_Click);
			this.minerToolStripMenuItem1.Name = "minerToolStripMenuItem1";
			this.minerToolStripMenuItem1.Size = new global::System.Drawing.Size(249, 32);
			this.minerToolStripMenuItem1.Text = "XMR MINER";
			this.minerToolStripMenuItem1.Visible = false;
			this.minerToolStripMenuItem1.Click += new global::System.EventHandler(this.MinerToolStripMenuItem1_Click);
			this.uPDATEToolStripMenuItem1.Name = "uPDATEToolStripMenuItem1";
			this.uPDATEToolStripMenuItem1.Size = new global::System.Drawing.Size(249, 32);
			this.uPDATEToolStripMenuItem1.Text = "UPDATE ALL CLIENTS";
			this.uPDATEToolStripMenuItem1.Click += new global::System.EventHandler(this.UPDATEToolStripMenuItem1_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(246, 6);
			this.dELETETASKToolStripMenuItem.Name = "dELETETASKToolStripMenuItem";
			this.dELETETASKToolStripMenuItem.Size = new global::System.Drawing.Size(249, 32);
			this.dELETETASKToolStripMenuItem.Text = "DELETE TASK";
			this.dELETETASKToolStripMenuItem.Click += new global::System.EventHandler(this.DELETETASKToolStripMenuItem_Click);
			this.performanceCounter1.CategoryName = "Processor";
			this.performanceCounter1.CounterName = "% Processor Time";
			this.performanceCounter1.InstanceName = "_Total";
			this.performanceCounter2.CategoryName = "Memory";
			this.performanceCounter2.CounterName = "% Committed Bytes In Use";
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "NordTeck";
			this.notifyIcon1.Visible = true;
			this.TimerTask.Enabled = true;
			this.TimerTask.Interval = 5000;
			this.TimerTask.Tick += new global::System.EventHandler(this.TimerTask_Tick);
			this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
			this.shutdownToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.shutdownToolStripMenuItem1.Text = "Shutdown";
			this.shutdownToolStripMenuItem1.Click += new global::System.EventHandler(this.ShutdownToolStripMenuItem1_Click);
			this.restartToolStripMenuItem3.Name = "restartToolStripMenuItem3";
			this.restartToolStripMenuItem3.Size = new global::System.Drawing.Size(270, 34);
			this.restartToolStripMenuItem3.Text = "Restart";
			this.restartToolStripMenuItem3.Click += new global::System.EventHandler(this.RestartToolStripMenuItem3_Click);
			this.logoffToolStripMenuItem1.Name = "logoffToolStripMenuItem1";
			this.logoffToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.logoffToolStripMenuItem1.Text = "Logoff";
			this.logoffToolStripMenuItem1.Click += new global::System.EventHandler(this.LogoffToolStripMenuItem1_Click);
			this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
			this.closeToolStripMenuItem1.Size = new global::System.Drawing.Size(270, 34);
			this.closeToolStripMenuItem1.Text = "Close";
			this.closeToolStripMenuItem1.Click += new global::System.EventHandler(this.CloseToolStripMenuItem1_Click);
			this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
			this.restartToolStripMenuItem2.Size = new global::System.Drawing.Size(270, 34);
			this.restartToolStripMenuItem2.Text = "Restart";
			this.restartToolStripMenuItem2.Click += new global::System.EventHandler(this.RestartToolStripMenuItem2_Click);
			this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
			this.updateToolStripMenuItem2.Size = new global::System.Drawing.Size(270, 34);
			this.updateToolStripMenuItem2.Text = "Update";
			this.updateToolStripMenuItem2.Click += new global::System.EventHandler(this.UpdateToolStripMenuItem2_Click);
			this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
			this.uninstallToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.uninstallToolStripMenuItem.Text = "Uninstall";
			this.uninstallToolStripMenuItem.Click += new global::System.EventHandler(this.UninstallToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(267, 6);
			this.showFolderToolStripMenuItem.Name = "showFolderToolStripMenuItem";
			this.showFolderToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.showFolderToolStripMenuItem.Text = "Show Folder";
			this.showFolderToolStripMenuItem.Click += new global::System.EventHandler(this.ShowFolderToolStripMenuItem_Click);
			this.clientToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.closeToolStripMenuItem1,
				this.restartToolStripMenuItem2,
				this.updateToolStripMenuItem2,
				this.uninstallToolStripMenuItem,
				this.toolStripSeparator3,
				this.showFolderToolStripMenuItem
			});
			this.clientToolStripMenuItem.Image = global::Server.Properties.Resources.client;
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new global::System.Drawing.Size(270, 34);
			this.clientToolStripMenuItem.Text = "Client";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1301, 511);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.statusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NordTeck-Sharp";
			base.Activated += new global::System.EventHandler(this.Form1_Activated);
			base.Deactivate += new global::System.EventHandler(this.Form1_Deactivate);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.contextMenuClient.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.contextMenuLogs.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.contextMenuThumbnail.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.contextMenuTasks.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000007 RID: 7
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ColumnHeader lv_ip;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ColumnHeader lv_user;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ColumnHeader lv_os;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ContextMenuStrip contextMenuClient;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Timer ping;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Timer UpdateUI;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ToolStripMenuItem sENDFILEToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		public global::System.Windows.Forms.ColumnHeader lv_hwid;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ColumnHeader lv_country;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ToolStripMenuItem bUILDERToolStripMenuItem;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ColumnHeader lv_version;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000019 RID: 25
		public global::System.Windows.Forms.ListView listView2;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x0400001C RID: 28
		private global::System.Diagnostics.PerformanceCounter performanceCounter1;

		// Token: 0x0400001D RID: 29
		private global::System.Diagnostics.PerformanceCounter performanceCounter2;

		// Token: 0x0400001E RID: 30
		public global::System.Windows.Forms.ColumnHeader lv_act;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ContextMenuStrip contextMenuThumbnail;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripMenuItem sTOPToolStripMenuItem;

		// Token: 0x04000024 RID: 36
		public global::System.Windows.Forms.ImageList ThumbnailImageList;

		// Token: 0x04000025 RID: 37
		public global::System.Windows.Forms.ListView listView3;

		// Token: 0x04000026 RID: 38
		public global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ColumnHeader lv_admin;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ContextMenuStrip contextMenuTasks;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolStripMenuItem downloadAndExecuteToolStripMenuItem;

		// Token: 0x0400002D RID: 45
		public global::System.Windows.Forms.ListView listView4;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStripMenuItem sENDFILETOMEMORYToolStripMenuItem1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem dELETETASKToolStripMenuItem;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Timer TimerTask;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripMenuItem tOMEMORYToolStripMenuItem;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem tODISKToolStripMenuItem;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ContextMenuStrip contextMenuLogs;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem1;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ToolStripMenuItem processManagerToolStripMenuItem1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.ToolStripMenuItem reportWindowToolStripMenuItem;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripMenuItem botsKillerToolStripMenuItem;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripMenuItem uSBSpreadToolStripMenuItem1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripMenuItem sendMessageBoxToolStripMenuItem1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem2;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripMenuItem pCToolStripMenuItem;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem seedTorrentToolStripMenuItem1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ToolStripMenuItem remoteShellToolStripMenuItem1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ToolStripMenuItem dOSAttackToolStripMenuItem;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ToolStripMenuItem executeNETCodeToolStripMenuItem;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ColumnHeader lv_av;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ToolStripMenuItem pASSWORDRECOVERYToolStripMenuItem;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ToolStripMenuItem blankScreenToolStripMenuItem;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ToolStripMenuItem getAdminPrivilegesToolStripMenuItem;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ToolStripMenuItem disableWindowsDefenderToolStripMenuItem;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ToolStripMenuItem webcamToolStripMenuItem;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ToolStripMenuItem xMRMinerToolStripMenuItem;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripMenuItem blockClientsToolStripMenuItem;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ColumnHeader lv_ins;

		// Token: 0x0400005C RID: 92
		public global::System.Windows.Forms.ColumnHeader lv_ping;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem minerToolStripMenuItem1;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem2;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ToolStripMenuItem setWallpaperToolStripMenuItem;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ToolStripMenuItem filesSearcherToolStripMenuItem;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.ColumnHeader lv_group;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem2;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ToolStripMenuItem showFolderToolStripMenuItem;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem1;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem3;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;
	}
}
