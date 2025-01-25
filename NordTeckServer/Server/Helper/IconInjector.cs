using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Server.Helper
{
	// Token: 0x02000032 RID: 50
	public static class IconInjector
	{
		// Token: 0x06000184 RID: 388 RVA: 0x0000E77B File Offset: 0x0000C97B
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconInjector.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000E788 File Offset: 0x0000C988
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconInjector.IconFile iconFile = IconInjector.IconFile.FromFile(iconFileName);
			IntPtr hUpdate = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(14L), new IntPtr((long)((ulong)iconGroupID)), 0, array, array.Length);
			for (int i = 0; i <= iconFile.ImageCount - 1; i++)
			{
				byte[] array2 = iconFile.ImageData(i);
				IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(3L), new IntPtr((long)((ulong)iconBaseID + (ulong)((long)i))), 0, array2, array2.Length);
			}
			IconInjector.NativeMethods.EndUpdateResource(hUpdate, false);
		}

		// Token: 0x02000033 RID: 51
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x06000186 RID: 390
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x06000187 RID: 391
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x06000188 RID: 392
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x02000034 RID: 52
		private struct ICONDIR
		{
			// Token: 0x04000101 RID: 257
			public ushort Reserved;

			// Token: 0x04000102 RID: 258
			public ushort Type;

			// Token: 0x04000103 RID: 259
			public ushort Count;
		}

		// Token: 0x02000035 RID: 53
		private struct ICONDIRENTRY
		{
			// Token: 0x04000104 RID: 260
			public byte Width;

			// Token: 0x04000105 RID: 261
			public byte Height;

			// Token: 0x04000106 RID: 262
			public byte ColorCount;

			// Token: 0x04000107 RID: 263
			public byte Reserved;

			// Token: 0x04000108 RID: 264
			public ushort Planes;

			// Token: 0x04000109 RID: 265
			public ushort BitCount;

			// Token: 0x0400010A RID: 266
			public int BytesInRes;

			// Token: 0x0400010B RID: 267
			public int ImageOffset;
		}

		// Token: 0x02000036 RID: 54
		private struct BITMAPINFOHEADER
		{
			// Token: 0x0400010C RID: 268
			public uint Size;

			// Token: 0x0400010D RID: 269
			public int Width;

			// Token: 0x0400010E RID: 270
			public int Height;

			// Token: 0x0400010F RID: 271
			public ushort Planes;

			// Token: 0x04000110 RID: 272
			public ushort BitCount;

			// Token: 0x04000111 RID: 273
			public uint Compression;

			// Token: 0x04000112 RID: 274
			public uint SizeImage;

			// Token: 0x04000113 RID: 275
			public int XPelsPerMeter;

			// Token: 0x04000114 RID: 276
			public int YPelsPerMeter;

			// Token: 0x04000115 RID: 277
			public uint ClrUsed;

			// Token: 0x04000116 RID: 278
			public uint ClrImportant;
		}

		// Token: 0x02000037 RID: 55
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x04000117 RID: 279
			public byte Width;

			// Token: 0x04000118 RID: 280
			public byte Height;

			// Token: 0x04000119 RID: 281
			public byte ColorCount;

			// Token: 0x0400011A RID: 282
			public byte Reserved;

			// Token: 0x0400011B RID: 283
			public ushort Planes;

			// Token: 0x0400011C RID: 284
			public ushort BitCount;

			// Token: 0x0400011D RID: 285
			public int BytesInRes;

			// Token: 0x0400011E RID: 286
			public ushort ID;
		}

		// Token: 0x02000038 RID: 56
		private class IconFile
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600018A RID: 394 RVA: 0x0000E80A File Offset: 0x0000CA0A
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

			// Token: 0x0600018B RID: 395 RVA: 0x0000E817 File Offset: 0x0000CA17
			public byte[] ImageData(int index)
			{
				return this.iconImage[index];
			}

			// Token: 0x0600018C RID: 396 RVA: 0x0000E824 File Offset: 0x0000CA24
			public static IconInjector.IconFile FromFile(string filename)
			{
				IconInjector.IconFile iconFile = new IconInjector.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconInjector.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconInjector.ICONDIR));
				iconFile.iconEntry = new IconInjector.ICONDIRENTRY[(int)iconFile.iconDir.Count];
				iconFile.iconImage = new byte[(int)iconFile.iconDir.Count][];
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(iconFile.iconDir);
				Type typeFromHandle = typeof(IconInjector.ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				for (int i = 0; i <= (int)(iconFile.iconDir.Count - 1); i++)
				{
					IconInjector.ICONDIRENTRY icondirentry = (IconInjector.ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), typeFromHandle);
					iconFile.iconEntry[i] = icondirentry;
					iconFile.iconImage[i] = new byte[icondirentry.BytesInRes];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[i], 0, icondirentry.BytesInRes);
					num += num2;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x0600018D RID: 397 RVA: 0x0000E948 File Offset: 0x0000CB48
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				byte[] array = new byte[Marshal.SizeOf(typeof(IconInjector.ICONDIR)) + Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY)) * this.ImageCount];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr<IconInjector.ICONDIR>(this.iconDir, gchandle.AddrOfPinnedObject(), false);
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(this.iconDir);
				for (int i = 0; i <= this.ImageCount - 1; i++)
				{
					IconInjector.GRPICONDIRENTRY structure = default(IconInjector.GRPICONDIRENTRY);
					IconInjector.BITMAPINFOHEADER bitmapinfoheader = default(IconInjector.BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(this.ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconInjector.BITMAPINFOHEADER)));
					gchandle2.Free();
					structure.Width = this.iconEntry[i].Width;
					structure.Height = this.iconEntry[i].Height;
					structure.ColorCount = this.iconEntry[i].ColorCount;
					structure.Reserved = this.iconEntry[i].Reserved;
					structure.Planes = bitmapinfoheader.Planes;
					structure.BitCount = bitmapinfoheader.BitCount;
					structure.BytesInRes = this.iconEntry[i].BytesInRes;
					structure.ID = Convert.ToUInt16((long)((ulong)iconBaseID + (ulong)((long)i)));
					Marshal.StructureToPtr<IconInjector.GRPICONDIRENTRY>(structure, new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), false);
					num += Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY));
				}
				gchandle.Free();
				return array;
			}

			// Token: 0x0400011F RID: 287
			private IconInjector.ICONDIR iconDir;

			// Token: 0x04000120 RID: 288
			private IconInjector.ICONDIRENTRY[] iconEntry;

			// Token: 0x04000121 RID: 289
			private byte[][] iconImage;
		}
	}
}
