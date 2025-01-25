using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000023 RID: 35
	public class PropertiesRenaming : IRenaming
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (PropertyDef propertyDef in typeDef.Properties)
					{
						propertyDef.Name = Utils.GenerateRandomString();
					}
				}
			}
			return module;
		}
	}
}
