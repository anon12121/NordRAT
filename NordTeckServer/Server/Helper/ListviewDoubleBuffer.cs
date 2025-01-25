using System;
using System.Reflection;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x0200003A RID: 58
	public static class ListviewDoubleBuffer
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000EB99 File Offset: 0x0000CD99
		public static void Enable(ListView listView)
		{
			typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(listView, true, null);
		}
	}
}
