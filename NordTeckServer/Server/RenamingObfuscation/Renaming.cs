using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation
{
	// Token: 0x02000016 RID: 22
	public class Renaming
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000AECB File Offset: 0x000090CB
		public static ModuleDefMD DoRenaming(ModuleDefMD inPath)
		{
			return Renaming.RenamingObfuscation(inPath);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000AED4 File Offset: 0x000090D4
		private static ModuleDefMD RenamingObfuscation(ModuleDefMD inModule)
		{
			ModuleDefMD module = ((IRenaming)new NamespacesRenaming()).Rename(inModule);
			module = ((IRenaming)new ClassesRenaming()).Rename(module);
			module = ((IRenaming)new MethodsRenaming()).Rename(module);
			module = ((IRenaming)new PropertiesRenaming()).Rename(module);
			return ((IRenaming)new FieldsRenaming()).Rename(module);
		}
	}
}
