﻿using System;
using System.IO;

namespace MessagePackLib.MessagePack
{
	// Token: 0x02000017 RID: 23
	internal class ReadTools
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005568 File Offset: 0x00003768
		public static string ReadString(Stream ms, int len)
		{
			byte[] array = new byte[len];
			ms.Read(array, 0, len);
			return BytesTools.GetString(array);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005590 File Offset: 0x00003790
		public static string ReadString(Stream ms)
		{
			return ReadTools.ReadString((byte)ms.ReadByte(), ms);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000055A0 File Offset: 0x000037A0
		public static string ReadString(byte strFlag, Stream ms)
		{
			int num = 0;
			byte[] array;
			if (strFlag >= 160 && strFlag <= 191)
			{
				num = (int)(strFlag - 160);
			}
			else if (strFlag == 217)
			{
				num = ms.ReadByte();
			}
			else if (strFlag == 218)
			{
				array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (strFlag == 219)
			{
				array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			ms.Read(array, 0, num);
			return BytesTools.GetString(array);
		}
	}
}
