using System;
using System.Collections.Generic;

namespace MessagePackLib.MessagePack
{
	// Token: 0x02000014 RID: 20
	public class MsgPackArray
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000043F8 File Offset: 0x000025F8
		public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
		{
			this.owner = msgpackObj;
			this.children = listObj;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004410 File Offset: 0x00002610
		public MsgPack Add()
		{
			return this.owner.AddArrayChild();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004420 File Offset: 0x00002620
		public MsgPack Add(string value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.AsString = value;
			return msgPack;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004434 File Offset: 0x00002634
		public MsgPack Add(long value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsInteger(value);
			return msgPack;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004448 File Offset: 0x00002648
		public MsgPack Add(double value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsFloat(value);
			return msgPack;
		}

		// Token: 0x1700000D RID: 13
		public MsgPack this[int index]
		{
			get
			{
				return this.children[index];
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000446C File Offset: 0x0000266C
		public int Length
		{
			get
			{
				return this.children.Count;
			}
		}

		// Token: 0x0400002C RID: 44
		private List<MsgPack> children;

		// Token: 0x0400002D RID: 45
		private MsgPack owner;
	}
}
