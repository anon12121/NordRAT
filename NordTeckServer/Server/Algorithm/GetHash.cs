using System;
using System.IO;
using System.Security.Cryptography;

namespace Server.Algorithm
{
	// Token: 0x02000077 RID: 119
	public static class GetHash
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00021A84 File Offset: 0x0001FC84
		public static string GetChecksum(string file)
		{
			string result;
			using (FileStream fileStream = File.OpenRead(file))
			{
				result = BitConverter.ToString(new SHA256Managed().ComputeHash(fileStream)).Replace("-", string.Empty);
			}
			return result;
		}
	}
}
