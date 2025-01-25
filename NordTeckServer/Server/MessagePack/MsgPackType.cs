using System;

namespace Server.MessagePack
{
	// Token: 0x0200002D RID: 45
	public enum MsgPackType
	{
		// Token: 0x040000F2 RID: 242
		Unknown,
		// Token: 0x040000F3 RID: 243
		Null,
		// Token: 0x040000F4 RID: 244
		Map,
		// Token: 0x040000F5 RID: 245
		Array,
		// Token: 0x040000F6 RID: 246
		String,
		// Token: 0x040000F7 RID: 247
		Integer,
		// Token: 0x040000F8 RID: 248
		UInt64,
		// Token: 0x040000F9 RID: 249
		Boolean,
		// Token: 0x040000FA RID: 250
		Float,
		// Token: 0x040000FB RID: 251
		Single,
		// Token: 0x040000FC RID: 252
		DateTime,
		// Token: 0x040000FD RID: 253
		Binary
	}
}
