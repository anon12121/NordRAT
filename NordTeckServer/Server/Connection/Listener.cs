using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Handle_Packet;

namespace Server.Connection
{
	// Token: 0x02000013 RID: 19
	internal class Listener
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000AAEC File Offset: 0x00008CEC
		private Socket Server { get; set; }

		// Token: 0x0600009B RID: 155 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		public void Connect(object port)
		{
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
				this.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
				{
					SendBufferSize = 51200,
					ReceiveBufferSize = 51200
				};
				this.Server.Bind(localEP);
				this.Server.Listen(500);
				new HandleLogs().Addmsg(string.Format("Listenning {0}", port), Color.Green);
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		private void EndAccept(IAsyncResult ar)
		{
			try
			{
				new Clients(this.Server.EndAccept(ar));
			}
			catch
			{
			}
			finally
			{
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
		}
	}
}
