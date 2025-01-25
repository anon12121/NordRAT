using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x02000078 RID: 120
	public static class Sha256
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x00021AD8 File Offset: 0x0001FCD8
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

		// Token: 0x060002DA RID: 730 RVA: 0x00021B5C File Offset: 0x0001FD5C
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
