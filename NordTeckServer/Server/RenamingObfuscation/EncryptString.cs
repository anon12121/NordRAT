using System;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation
{
	// Token: 0x02000014 RID: 20
	public static class EncryptString
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0000AC0C File Offset: 0x00008E0C
		private static MethodDef InjectMethod(ModuleDef module, string methodName)
		{
			MethodDef result = (MethodDef)InjectHelper.Inject(ModuleDefMD.Load(typeof(DecryptionHelper).Module).ResolveTypeDef(MDToken.ToRID(typeof(DecryptionHelper).MetadataToken)), module.GlobalType, module).Single((IDnlibDef method) => method.Name == methodName);
			foreach (MethodDef methodDef in module.GlobalType.Methods)
			{
				if (methodDef.Name == ".ctor")
				{
					module.GlobalType.Remove(methodDef);
					break;
				}
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		public static void DoEncrypt(ModuleDef inPath)
		{
			EncryptString.EncryptStrings(inPath);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		private static ModuleDef EncryptStrings(ModuleDef inModule)
		{
			ICrypto crypto = new Base64();
			MethodDef methodDef = EncryptString.InjectMethod(inModule, "Decrypt_Base64");
			foreach (TypeDef typeDef in inModule.Types)
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "Resources") && !(typeDef.Name == "Settings"))
				{
					foreach (MethodDef methodDef2 in typeDef.Methods)
					{
						if (methodDef2.HasBody && methodDef2 != methodDef)
						{
							methodDef2.Body.KeepOldMaxStack = true;
							for (int i = 0; i < methodDef2.Body.Instructions.Count; i++)
							{
								if (methodDef2.Body.Instructions[i].OpCode == OpCodes.Ldstr)
								{
									string dataPlain = methodDef2.Body.Instructions[i].Operand.ToString();
									methodDef2.Body.Instructions[i].Operand = crypto.Encrypt(dataPlain);
									methodDef2.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, methodDef));
								}
							}
							methodDef2.Body.SimplifyBranches();
							methodDef2.Body.OptimizeBranches();
						}
					}
				}
			}
			return inModule;
		}
	}
}
