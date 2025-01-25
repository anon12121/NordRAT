using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Handle_Packet
{
	// Token: 0x0200004C RID: 76
	public class HandleLogs
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0001090C File Offset: 0x0000EB0C
		public void Addmsg(string Msg, Color color)
		{
			try
			{
				ListViewItem LV = new ListViewItem();
				LV.Text = DateTime.Now.ToLongTimeString();
				LV.SubItems.Add(Msg);
				LV.ForeColor = color;
				if (Program.form1.InvokeRequired)
				{
					Program.form1.Invoke(new MethodInvoker(delegate()
					{
						object lockListviewLogs2 = Settings.LockListviewLogs;
						lock (lockListviewLogs2)
						{
							Program.form1.listView2.Items.Insert(0, LV);
						}
					}));
				}
				else
				{
					object lockListviewLogs = Settings.LockListviewLogs;
					lock (lockListviewLogs)
					{
						Program.form1.listView2.Items.Insert(0, LV);
					}
				}
			}
			catch
			{
			}
		}
	}
}
