using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200003B RID: 59
	public static class Methods
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		public static string BytesToString(long byteCount)
		{
			string[] array = new string[]
			{
				"B",
				"KB",
				"MB",
				"GB",
				"TB",
				"PB",
				"EB"
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
			return ((double)Math.Sign(byteCount) * num3).ToString() + array[num2];
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000EC70 File Offset: 0x0000CE70
		public static Task FadeIn(Form o, int interval = 80)
		{
			Methods.<FadeIn>d__2 <FadeIn>d__;
			<FadeIn>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FadeIn>d__.o = o;
			<FadeIn>d__.interval = interval;
			<FadeIn>d__.<>1__state = -1;
			<FadeIn>d__.<>t__builder.Start<Methods.<FadeIn>d__2>(ref <FadeIn>d__);
			return <FadeIn>d__.<>t__builder.Task;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public static string GetRandomString(int length)
		{
			StringBuilder stringBuilder = new StringBuilder(length);
			for (int i = 0; i < length; i++)
			{
				stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[Methods.Random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000125 RID: 293
		private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		// Token: 0x04000126 RID: 294
		public static Random Random = new Random();
	}
}
