using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000040 RID: 64
	internal class HandleDos
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x0000F05C File Offset: 0x0000D25C
		public void Add(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormDOS formDOS = (FormDOS)Application.OpenForms["DOS"];
				if (formDOS != null)
				{
					object sync = formDOS.sync;
					lock (sync)
					{
						formDOS.PlguinClients.Add(client);
					}
				}
			}
			catch
			{
			}
		}
	}
}
