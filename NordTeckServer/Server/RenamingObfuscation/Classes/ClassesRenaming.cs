using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200001A RID: 26
	public class ClassesRenaming : IRenaming
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000AF58 File Offset: 0x00009158
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "GeneratedInternalTypeHelper") && !(typeDef.Name == "Resources"))
				{
					string text;
					if (ClassesRenaming._names.TryGetValue(typeDef.Name, out text))
					{
						typeDef.Name = text;
					}
					else
					{
						string text2 = Utils.GenerateRandomString();
						ClassesRenaming._names.Add(typeDef.Name, text2);
						typeDef.Name = text2;
					}
				}
			}
			return ClassesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000B02C File Offset: 0x0000922C
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (Resource resource in module.Resources)
			{
				foreach (KeyValuePair<string, string> keyValuePair in ClassesRenaming._names)
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
								foreach (KeyValuePair<string, string> keyValuePair2 in ClassesRenaming._names)
								{
									if (instructions[i].Operand.ToString().Contains(keyValuePair2.Key))
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

		// Token: 0x040000C9 RID: 201
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
