using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Connection;

namespace Server
{
	// Token: 0x0200000D RID: 13
	public static class Settings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00009633 File Offset: 0x00007833
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000963A File Offset: 0x0000783A
		public static long SentValue { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00009642 File Offset: 0x00007842
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00009649 File Offset: 0x00007849
		public static long ReceivedValue { get; set; }

		// Token: 0x0400009C RID: 156
		public static List<string> Blocked = new List<string>();

		// Token: 0x0400009D RID: 157
		public static object LockBlocked = new object();

		// Token: 0x040000A0 RID: 160
		public static object LockReceivedSendValue = new object();

		// Token: 0x040000A1 RID: 161
		public static string CertificatePath = Application.StartupPath + "\\ServerCertificate.p12";

		// Token: 0x040000A2 RID: 162
		public static X509Certificate2 ServerCertificate;

		// Token: 0x040000A3 RID: 163
		public static readonly string Version = "NordTeck 0.5.8";

		// Token: 0x040000A4 RID: 164
		public static object LockListviewClients = new object();

		// Token: 0x040000A5 RID: 165
		public static object LockListviewLogs = new object();

		// Token: 0x040000A6 RID: 166
		public static object LockListviewThumb = new object();

		// Token: 0x040000A7 RID: 167
		public static bool ReportWindow = false;

		// Token: 0x040000A8 RID: 168
		public static List<Clients> ReportWindowClients = new List<Clients>();

		// Token: 0x040000A9 RID: 169
		public static object LockReportWindowClients = new object();
	}
}
