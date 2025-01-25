using System;
using System.Text;

namespace MessagePackLib.MessagePack
{
	// Token: 0x02000012 RID: 18
	public class BytesTools
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000423C File Offset: 0x0000243C
		public static byte[] GetUtf8Bytes(string s)
		{
			return BytesTools.utf8Encode.GetBytes(s);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000424C File Offset: 0x0000244C
		public static string GetString(byte[] utf8Bytes)
		{
			return BytesTools.utf8Encode.GetString(utf8Bytes);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000425C File Offset: 0x0000245C
		public static string BytesAsString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000042A8 File Offset: 0x000024A8
		public static string BytesAsHexString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000042F4 File Offset: 0x000024F4
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

		// Token: 0x06000059 RID: 89 RVA: 0x00004330 File Offset: 0x00002530
		public static byte[] SwapInt64(long v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004340 File Offset: 0x00002540
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

		// Token: 0x0600005B RID: 91 RVA: 0x00004364 File Offset: 0x00002564
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

		// Token: 0x0600005C RID: 92 RVA: 0x00004378 File Offset: 0x00002578
		public static byte[] SwapDouble(double v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x04000029 RID: 41
		private static UTF8Encoding utf8Encode = new UTF8Encoding();
	}
}
