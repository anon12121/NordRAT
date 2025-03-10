﻿using System;
using System.IO;
using System.IO.Compression;

namespace Server.Algorithm
{
	// Token: 0x02000079 RID: 121
	public static class Zip
	{
		// Token: 0x060002DB RID: 731 RVA: 0x00021B94 File Offset: 0x0001FD94
		public static byte[] Decompress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				byte[] array = new byte[4];
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					byte[] array2 = new byte[num];
					gzipStream.Read(array2, 0, num);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00021C14 File Offset: 0x0001FE14
		public static byte[] Compress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = BitConverter.GetBytes(input.Length);
				memoryStream.Write(bytes, 0, 4);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
				{
					gzipStream.Write(input, 0, input.Length);
					gzipStream.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}
}
