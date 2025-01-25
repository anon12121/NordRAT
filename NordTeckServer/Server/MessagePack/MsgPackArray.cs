using System;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000029 RID: 41
	public class MsgPackArray
	{
		// Token: 0x0600013F RID: 319 RVA: 0x0000CF30 File Offset: 0x0000B130
		public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
		{
			this.owner = msgpackObj;
			this.children = listObj;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000CF46 File Offset: 0x0000B146
		public MsgPack Add()
		{
			return this.owner.AddArrayChild();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000CF53 File Offset: 0x0000B153
		public MsgPack Add(string value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.AsString = value;
			return msgPack;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000CF67 File Offset: 0x0000B167
		public MsgPack Add(long value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsInteger(value);
			return msgPack;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000CF7B File Offset: 0x0000B17B
		public MsgPack Add(double value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsFloat(value);
			return msgPack;
		}

		// Token: 0x1700005B RID: 91
		public MsgPack this[int index]
		{
			get
			{
				return this.children[index];
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000CF9D File Offset: 0x0000B19D
		public int Length
		{
			get
			{
				return this.children.Count;
			}
		}

		// Token: 0x040000DA RID: 218
		private List<MsgPack> children;

		// Token: 0x040000DB RID: 219
		private MsgPack owner;
	}
}
