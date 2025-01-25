using System;
using System.Drawing;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x0200004A RID: 74
	public class HandleListView
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00010294 File Offset: 0x0000E494
		public void AddToListview(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockBlocked = Settings.LockBlocked;
				lock (lockBlocked)
				{
					try
					{
						if (Settings.Blocked.Count > 0)
						{
							if (Settings.Blocked.Contains(unpack_msgpack.ForcePathObject("HWID").AsString))
							{
								client.Disconnected();
								return;
							}
							if (Settings.Blocked.Contains(client.Ip))
							{
								client.Disconnected();
								return;
							}
						}
					}
					catch
					{
					}
				}
				client.LV = new ListViewItem
				{
					Tag = client,
					Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(new char[]
					{
						':'
					})[1])
				};
				try
				{
					string[] array = Program.form1.cGeoMain.GetIpInf(client.TcpClient.RemoteEndPoint.ToString().Split(new char[]
					{
						':'
					})[0]).Split(new char[]
					{
						':'
					});
					client.LV.SubItems.Add(array[1]);
					try
					{
						client.LV.ImageKey = array[2] + ".png";
					}
					catch
					{
					}
				}
				catch
				{
					client.LV.SubItems.Add("??");
				}
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Group").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("HWID").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("User").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("OS").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Version").AsString);
				try
				{
					client.LV.SubItems.Add(Convert.ToDateTime(unpack_msgpack.ForcePathObject("Installed").AsString).ToLocalTime().ToString());
				}
				catch
				{
					try
					{
						client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Installed").AsString);
					}
					catch
					{
						client.LV.SubItems.Add("??");
					}
				}
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Admin").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Antivirus").AsString);
				client.LV.SubItems.Add("0000 MS");
				try
				{
					client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Performance").AsString);
				}
				catch
				{
					client.LV.SubItems.Add("...");
				}
				client.LV.ToolTipText = "[Path] " + unpack_msgpack.ForcePathObject("Path").AsString + Environment.NewLine;
				ListViewItem lv = client.LV;
				lv.ToolTipText = lv.ToolTipText + "[Pastebin] " + unpack_msgpack.ForcePathObject("Pastebin").AsString;
				client.ID = unpack_msgpack.ForcePathObject("HWID").AsString;
				client.LV.UseItemStyleForSubItems = false;
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					object lockListviewClients = Settings.LockListviewClients;
					lock (lockListviewClients)
					{
						Program.form1.listView1.Items.Add(client.LV);
						Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						Program.form1.lv_act.Width = 500;
					}
					if (Settings.Default.Notification)
					{
						Program.form1.notifyIcon1.BalloonTipText = "Connected \r\n" + client.Ip + " : " + client.TcpClient.LocalEndPoint.ToString().Split(new char[]
						{
							':'
						})[1];
						Program.form1.notifyIcon1.ShowBalloonTip(100);
					}
					new HandleLogs().Addmsg("Client " + client.Ip + " connected", Color.Green);
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00010794 File Offset: 0x0000E994
		public void Received(Clients client)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.ForeColor = Color.Empty;
					}
				}
			}
			catch
			{
			}
		}
	}
}
