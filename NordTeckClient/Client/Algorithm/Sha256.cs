using System;
using System.Security.Cryptography;
using System.Text;

namespace Client.Algorithm
{
	// Token: 0x02000010 RID: 16
	public static class Sha256
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00004170 File Offset: 0x00002370
		public static string ComputeHash(string input)
		{
			byte[] array = Encoding.UTF8.GetBytes(input);
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				array = sha256Managed.ComputeHash(array);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000041FC File Offset: 0x000023FC
		public static byte[] ComputeHash(byte[] input)
		{
			byte[] result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = sha256Managed.ComputeHash(input);
			}
			return result;
		}
	}
}
