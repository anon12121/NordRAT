using System;
using System.Drawing;
using Server.Connection;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x02000052 RID: 82
	public class HandleReportWindow
	{
		// Token: 0x060001CD RID: 461 RVA: 0x000110E0 File Offset: 0x0000F2E0
		public HandleReportWindow(Clients client, string title)
		{
			new HandleLogs().Addmsg(string.Concat(new string[]
			{
				"Client ",
				client.Ip,
				" Opened [",
				title,
				"]"
			}), Color.Blue);
			if (Settings.Default.Notification)
			{
				Program.form1.notifyIcon1.BalloonTipText = string.Concat(new string[]
				{
					"Client ",
					client.Ip,
					" Opened [",
					title,
					"]"
				});
				Program.form1.notifyIcon1.ShowBalloonTip(100);
			}
		}
	}
}
