using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Server.Helper
{
	// Token: 0x0200003D RID: 61
	public class ReferenceLoader : MarshalByRefObject
	{
		// Token: 0x0600019C RID: 412 RVA: 0x0000EE10 File Offset: 0x0000D010
		public string[] LoadReferences(string assemblyPath)
		{
			string[] result;
			try
			{
				result = (from x in Assembly.ReflectionOnlyLoadFrom(assemblyPath).GetReferencedAssemblies()
				select x.FullName).ToArray<string>();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public void AppDomainSetup(string assemblyPath)
		{
			try
			{
				AppDomainSetup info = new AppDomainSetup
				{
					ApplicationBase = AppDomain.CurrentDomain.BaseDirectory
				};
				AppDomain domain = AppDomain.CreateDomain(Guid.NewGuid().ToString(), null, info);
				((ReferenceLoader)Activator.CreateInstance(domain, typeof(ReferenceLoader).Assembly.FullName, typeof(ReferenceLoader).FullName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, CultureInfo.CurrentCulture, new object[0]).Unwrap()).LoadReferences(assemblyPath);
				AppDomain.Unload(domain);
			}
			catch
			{
			}
		}
	}
}
