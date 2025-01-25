using System;
using dnlib.DotNet;

namespace Server.RenamingObfuscation.Interfaces
{
	// Token: 0x02000018 RID: 24
	public interface IRenaming
	{
		// Token: 0x060000A7 RID: 167
		ModuleDefMD Rename(ModuleDefMD module);
	}
}
