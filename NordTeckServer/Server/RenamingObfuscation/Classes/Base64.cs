using System;
using System.Text;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000019 RID: 25
	public class Base64 : ICrypto
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000AF20 File Offset: 0x00009120
		public string Encrypt(string dataPlain)
		{
			string result;
			try
			{
				result = Convert.ToBase64String(Encoding.UTF8.GetBytes(dataPlain));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
