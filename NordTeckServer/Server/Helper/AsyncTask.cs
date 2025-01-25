using System;
using System.Collections.Generic;

namespace Server.Helper
{
	// Token: 0x02000030 RID: 48
	public class AsyncTask
	{
		// Token: 0x06000182 RID: 386 RVA: 0x0000E65D File Offset: 0x0000C85D
		public AsyncTask(byte[] _msgPack, string _id)
		{
			this.msgPack = _msgPack;
			this.id = _id;
			this.doneClient = new List<string>();
		}

		// Token: 0x040000FE RID: 254
		public byte[] msgPack;

		// Token: 0x040000FF RID: 255
		public string id;

		// Token: 0x04000100 RID: 256
		public List<string> doneClient;
	}
}
