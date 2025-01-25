using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200001C RID: 28
	public class FieldsRenaming : IRenaming
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (FieldDef fieldDef in typeDef.Fields)
					{
						string text;
						if (FieldsRenaming._names.TryGetValue(fieldDef.Name, out text))
						{
							fieldDef.Name = text;
						}
						else if (!fieldDef.IsSpecialName && !fieldDef.HasCustomAttributes)
						{
							string text2 = Utils.GenerateRandomString();
							FieldsRenaming._names.Add(fieldDef.Name, text2);
							fieldDef.Name = text2;
						}
					}
				}
			}
			return FieldsRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000B3D8 File Offset: 0x000095D8
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (!(methodDef.Name != "InitializeComponent"))
						{
							IList<Instruction> instructions = methodDef.Body.Instructions;
							for (int i = 0; i < instructions.Count - 3; i++)
							{
								if (instructions[i].OpCode == OpCodes.Ldstr)
								{
									foreach (KeyValuePair<string, string> keyValuePair in FieldsRenaming._names)
									{
										if (keyValuePair.Key == instructions[i].Operand.ToString())
										{
											instructions[i].Operand = keyValuePair.Value;
										}
									}
								}
							}
						}
					}
				}
			}
			return module;
		}

		// Token: 0x040000CA RID: 202
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
