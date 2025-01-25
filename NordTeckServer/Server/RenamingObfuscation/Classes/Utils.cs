using System;
using System.Text;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000024 RID: 36
	public static class Utils
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x0000C570 File Offset: 0x0000A770
		public static string GenerateRandomString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i <= Utils.random.Next(10, 20); i++)
			{
				int index = Utils.random.Next(0, "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".Length);
				stringBuilder.Append("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"[index]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040000D2 RID: 210
		private static readonly Random random = new Random();

		// Token: 0x040000D3 RID: 211
		private const string alphabet = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
	}
}
