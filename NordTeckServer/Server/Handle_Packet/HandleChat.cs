using System;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200003F RID: 63
	public class HandleChat
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0000EF2C File Offset: 0x0000D12C
		public void Read(MsgPack unpack_msgpack, Clients client)
		{
			try
			{
				FormChat formChat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				if (formChat != null)
				{
					Console.Beep();
					formChat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput").AsString);
					formChat.richTextBox1.SelectionStart = formChat.richTextBox1.TextLength;
					formChat.richTextBox1.ScrollToCaret();
				}
				else
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "chatExit";
					ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
					client.Disconnected();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		public void GetClient(MsgPack unpack_msgpack, Clients client)
		{
			FormChat formChat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			if (formChat != null && formChat.Client == null)
			{
				formChat.Client = client;
				formChat.textBox1.Enabled = true;
				formChat.timer1.Enabled = true;
			}
		}
	}
}
