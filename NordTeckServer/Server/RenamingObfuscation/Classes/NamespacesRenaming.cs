using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000022 RID: 34
	public class NamespacesRenaming : IRenaming
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			module.Name = Utils.GenerateRandomString();
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Namespace == ""))
				{
					string text;
					if (NamespacesRenaming._names.TryGetValue(typeDef.Namespace, out text))
					{
						typeDef.Namespace = text;
					}
					else
					{
						string text2 = Utils.GenerateRandomString();
						NamespacesRenaming._names.Add(typeDef.Namespace, text2);
						typeDef.Namespace = text2;
					}
				}
			}
			return NamespacesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000C270 File Offset: 0x0000A470
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (Resource resource in module.Resources)
			{
				foreach (KeyValuePair<string, string> keyValuePair in NamespacesRenaming._names)
				{
					if (resource.Name.Contains(keyValuePair.Key))
					{
						resource.Name = resource.Name.Replace(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			foreach (TypeDef typeDef in module.GetTypes())
			{
				foreach (PropertyDef propertyDef in typeDef.Properties)
				{
					if (!(propertyDef.Name != "ResourceManager"))
					{
						IList<Instruction> instructions = propertyDef.GetMethod.Body.Instructions;
						for (int i = 0; i < instructions.Count; i++)
						{
							if (instructions[i].OpCode == OpCodes.Ldstr)
							{
								foreach (KeyValuePair<string, string> keyValuePair2 in NamespacesRenaming._names)
								{
									if (instructions[i].ToString().Contains(keyValuePair2.Key))
									{
										instructions[i].Operand = instructions[i].Operand.ToString().Replace(keyValuePair2.Key, keyValuePair2.Value);
									}
								}
							}
						}
					}
				}
			}
			return module;
		}

		// Token: 0x040000D1 RID: 209
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
