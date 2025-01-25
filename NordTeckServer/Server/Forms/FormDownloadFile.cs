using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Connection;
using Server.Helper;

namespace Server.Forms
{
	// Token: 0x02000072 RID: 114
	public partial class FormDownloadFile : Form
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001FBED File Offset: 0x0001DDED
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0001FBF5 File Offset: 0x0001DDF5
		public Form1 F { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001FBFE File Offset: 0x0001DDFE
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0001FC06 File Offset: 0x0001DE06
		internal Clients Client { get; set; }

		// Token: 0x060002A6 RID: 678 RVA: 0x0001FC0F File Offset: 0x0001DE0F
		public FormDownloadFile()
		{
			this.InitializeComponent();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001FC20 File Offset: 0x0001DE20
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!this.IsUpload)
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.Client.BytesRecevied);
				if (this.Client.BytesRecevied >= this.FileSize)
				{
					this.labelsize.Text = "Downloaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
					return;
				}
			}
			else
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.BytesSent);
				if (this.BytesSent >= this.FileSize)
				{
					this.labelsize.Text = "Uploaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
				}
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		private void SocketDownload_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Clients client = this.Client;
				if (client != null)
				{
					client.Disconnected();
				}
				Timer timer = this.timer1;
				if (timer != null)
				{
					timer.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001FD50 File Offset: 0x0001DF50
		public void Send(object obj)
		{
			object sendSync = this.Client.SendSync;
			lock (sendSync)
			{
				try
				{
					this.IsUpload = true;
					byte[] array = (byte[])obj;
					byte[] bytes = BitConverter.GetBytes(array.Length);
					this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
					this.Client.SslClient.Write(bytes, 0, bytes.Length);
					using (MemoryStream memoryStream = new MemoryStream(array))
					{
						memoryStream.Position = 0L;
						byte[] array2 = new byte[50000];
						int num;
						while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
						{
							this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
							this.Client.SslClient.Write(array2, 0, num);
							this.BytesSent += (long)num;
						}
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						base.Close();
					}));
				}
				catch
				{
					Clients client = this.Client;
					if (client != null)
					{
						client.Disconnected();
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						this.labelsize.Text = "Error";
						this.labelsize.ForeColor = Color.Red;
					}));
				}
			}
		}

		// Token: 0x04000277 RID: 631
		public long FileSize;

		// Token: 0x04000278 RID: 632
		private long BytesSent;

		// Token: 0x04000279 RID: 633
		public string FullFileName;

		// Token: 0x0400027A RID: 634
		public string ClientFullFileName;

		// Token: 0x0400027B RID: 635
		private bool IsUpload;

		// Token: 0x0400027C RID: 636
		public string DirPath;
	}
}
