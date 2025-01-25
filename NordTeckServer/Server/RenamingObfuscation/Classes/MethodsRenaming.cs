using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000021 RID: 33
	public class MethodsRenaming : IRenaming
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x0000C064 File Offset: 0x0000A264
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.Types)
			{
				if (!typeDef.IsGlobalModuleType)
				{
					typeDef.Name = Utils.GenerateRandomString();
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (!methodDef.IsSpecialName && !methodDef.IsConstructor && !methodDef.HasCustomAttributes && !methodDef.IsAbstract && !methodDef.IsVirtual && methodDef.Name != "Main")
						{
							methodDef.Name = Utils.GenerateRandomString();
						}
						foreach (ParamDef paramDef in methodDef.ParamDefs)
						{
							paramDef.Name = Utils.GenerateRandomString();
						}
					}
				}
			}
			return module;
		}
	}
}
