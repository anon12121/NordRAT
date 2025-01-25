using System;
using System.Text;

namespace Server.MessagePack
{
	// Token: 0x02000027 RID: 39
	public class BytesTools
	{
		// Token: 0x06000130 RID: 304 RVA: 0x0000CDA6 File Offset: 0x0000AFA6
		public static byte[] GetUtf8Bytes(string s)
		{
			return BytesTools.utf8Encode.GetBytes(s);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000CDB3 File Offset: 0x0000AFB3
		public static string GetString(byte[] utf8Bytes)
		{
			return BytesTools.utf8Encode.GetString(utf8Bytes);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public static string BytesAsString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000CE04 File Offset: 0x0000B004
		public static string BytesAsHexString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000CE48 File Offset: 0x0000B048
		public static byte[] SwapBytes(byte[] v)
		{
			byte[] array = new byte[v.Length];
			int num = v.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = v[num];
				num--;
			}
			return array;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000CE7D File Offset: 0x0000B07D
		public static byte[] SwapInt64(long v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000CE8A File Offset: 0x0000B08A
		public static byte[] SwapInt32(int v)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)v
			};
			array[2] = (byte)(v >> 8);
			array[1] = (byte)(v >> 16);
			array[0] = (byte)(v >> 24);
			return array;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000CEAE File Offset: 0x0000B0AE
		public static byte[] SwapInt16(short v)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)v
			};
			array[0] = (byte)(v >> 8);
			return array;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000CEC2 File Offset: 0x0000B0C2
		public static byte[] SwapDouble(double v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x040000D7 RID: 215
		private static UTF8Encoding utf8Encode = new UTF8Encoding();
	}
}
