using System;
using System.Text;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200001B RID: 27
	internal static class DecryptionHelper
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000B2A0 File Offset: 0x000094A0
		public static string Decrypt_Base64(string dataEnc)
		{
			string result;
			try
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(dataEnc));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
