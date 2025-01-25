using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x0200006E RID: 110
	public partial class FormProcessManager : Form
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001DD56 File Offset: 0x0001BF56
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0001DD5E File Offset: 0x0001BF5E
		public Form1 F { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001DD67 File Offset: 0x0001BF67
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0001DD6F File Offset: 0x0001BF6F
		internal Clients Client { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001DD78 File Offset: 0x0001BF78
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0001DD80 File Offset: 0x0001BF80
		internal Clients ParentClient { get; set; }

		// Token: 0x06000276 RID: 630 RVA: 0x0001DD89 File Offset: 0x0001BF89
		public FormProcessManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001DD98 File Offset: 0x0001BF98
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected || !this.ParentClient.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormProcessManager.<killToolStripMenuItem_Click>d__14 <killToolStripMenuItem_Click>d__;
			<killToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<killToolStripMenuItem_Click>d__.<>4__this = this;
			<killToolStripMenuItem_Click>d__.<>1__state = -1;
			<killToolStripMenuItem_Click>d__.<>t__builder.Start<FormProcessManager.<killToolStripMenuItem_Click>d__14>(ref <killToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001DE23 File Offset: 0x0001C023
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "processManager";
				msgPack.ForcePathObject("Option").AsString = "List";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			});
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001DE38 File Offset: 0x0001C038
		private void FormProcessManager_FormClosed(object sender, FormClosedEventArgs e)
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
	}
}
