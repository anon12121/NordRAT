using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000056 RID: 86
	public class HandleShell
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0001142C File Offset: 0x0000F62C
		public HandleShell(MsgPack unpack_msgpack, Clients client)
		{
			FormShell formShell = (FormShell)Application.OpenForms["shell:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			if (formShell != null)
			{
				if (formShell.Client == null)
				{
					formShell.Client = client;
					formShell.timer1.Enabled = true;
				}
				formShell.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("ReadInput").AsString);
				formShell.richTextBox1.SelectionStart = formShell.richTextBox1.TextLength;
				formShell.richTextBox1.ScrollToCaret();
			}
		}
	}
}
