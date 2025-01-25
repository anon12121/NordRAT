using System;
using System.Runtime.InteropServices;

namespace Server.StreamLibrary
{
	// Token: 0x02000010 RID: 16
	public static class NativeMethods
	{
		// Token: 0x0600006B RID: 107
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcmp(byte* ptr1, byte* ptr2, uint count);

		// Token: 0x0600006C RID: 108
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int memcpy(IntPtr dst, IntPtr src, uint count);

		// Token: 0x0600006D RID: 109
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcpy(void* dst, void* src, uint count);
	}
}
