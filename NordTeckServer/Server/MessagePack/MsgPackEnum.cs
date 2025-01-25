using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000028 RID: 40
	public class MsgPackEnum : IEnumerator
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0000CEDB File Offset: 0x0000B0DB
		public MsgPackEnum(List<MsgPack> obj)
		{
			this.children = obj;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		object IEnumerator.Current
		{
			get
			{
				return this.children[this.position];
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000CF04 File Offset: 0x0000B104
		bool IEnumerator.MoveNext()
		{
			this.position++;
			return this.position < this.children.Count;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000CF27 File Offset: 0x0000B127
		void IEnumerator.Reset()
		{
			this.position = -1;
		}

		// Token: 0x040000D8 RID: 216
		private List<MsgPack> children;

		// Token: 0x040000D9 RID: 217
		private int position = -1;
	}
}
