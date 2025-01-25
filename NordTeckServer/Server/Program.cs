using System;
using System.IO;
using System.Windows.Forms;
using Server.Properties;

namespace Server
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00008CA8 File Offset: 0x00006EA8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				string path = Path.Combine(Application.StartupPath, "Fixer.bat");
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Resources.Fixer);
				}
			}
			catch
			{
			}
			Program.form1 = new Form1();
			Application.Run(Program.form1);
		}

		// Token: 0x0400008E RID: 142
		public static Form1 form1;
	}
}
