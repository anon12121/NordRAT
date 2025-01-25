using System;
using System.Collections;
using System.Collections.Generic;

namespace MessagePackLib.MessagePack
{
	// Token: 0x02000013 RID: 19
	public class MsgPackEnum : IEnumerator
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000439C File Offset: 0x0000259C
		public MsgPackEnum(List<MsgPack> obj)
		{
			this.children = obj;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000043B4 File Offset: 0x000025B4
		object IEnumerator.Current
		{
			get
			{
				return this.children[this.position];
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000043C8 File Offset: 0x000025C8
		bool IEnumerator.MoveNext()
		{
			this.position++;
			return this.position < this.children.Count;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000043EC File Offset: 0x000025EC
		void IEnumerator.Reset()
		{
			this.position = -1;
		}

		// Token: 0x0400002A RID: 42
		private List<MsgPack> children;

		// Token: 0x0400002B RID: 43
		private int position = -1;
	}
}
