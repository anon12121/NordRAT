using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Server.Properties
{
	// Token: 0x02000026 RID: 38
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000CB1C File Offset: 0x0000AD1C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000CB23 File Offset: 0x0000AD23
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000CB35 File Offset: 0x0000AD35
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Ports
		{
			get
			{
				return (string)this["Ports"];
			}
			set
			{
				this["Ports"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000CB43 File Offset: 0x0000AD43
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000CB55 File Offset: 0x0000AD55
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Filename
		{
			get
			{
				return (string)this["Filename"];
			}
			set
			{
				this["Filename"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000CB63 File Offset: 0x0000AD63
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000CB75 File Offset: 0x0000AD75
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Notification
		{
			get
			{
				return (bool)this["Notification"];
			}
			set
			{
				this["Notification"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Mutex
		{
			get
			{
				return (string)this["Mutex"];
			}
			set
			{
				this["Mutex"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000CBA8 File Offset: 0x0000ADA8
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://pastebin.com/raw/s14cUU5G")]
		public string Pastebin
		{
			get
			{
				return (string)this["Pastebin"];
			}
			set
			{
				this["Pastebin"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000CBDA File Offset: 0x0000ADDA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string IP
		{
			get
			{
				return (string)this["IP"];
			}
			set
			{
				this["IP"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000CBFA File Offset: 0x0000ADFA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ProductName
		{
			get
			{
				return (string)this["ProductName"];
			}
			set
			{
				this["ProductName"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000CC08 File Offset: 0x0000AE08
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000CC1A File Offset: 0x0000AE1A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtDescription
		{
			get
			{
				return (string)this["txtDescription"];
			}
			set
			{
				this["txtDescription"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000CC28 File Offset: 0x0000AE28
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000CC3A File Offset: 0x0000AE3A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCompany
		{
			get
			{
				return (string)this["txtCompany"];
			}
			set
			{
				this["txtCompany"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000CC48 File Offset: 0x0000AE48
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000CC5A File Offset: 0x0000AE5A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCopyright
		{
			get
			{
				return (string)this["txtCopyright"];
			}
			set
			{
				this["txtCopyright"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000CC68 File Offset: 0x0000AE68
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000CC7A File Offset: 0x0000AE7A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtTrademarks
		{
			get
			{
				return (string)this["txtTrademarks"];
			}
			set
			{
				this["txtTrademarks"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000CC88 File Offset: 0x0000AE88
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000CC9A File Offset: 0x0000AE9A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtOriginalFilename
		{
			get
			{
				return (string)this["txtOriginalFilename"];
			}
			set
			{
				this["txtOriginalFilename"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000CCBA File Offset: 0x0000AEBA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtProductVersion
		{
			get
			{
				return (string)this["txtProductVersion"];
			}
			set
			{
				this["txtProductVersion"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000CCDA File Offset: 0x0000AEDA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtFileVersion
		{
			get
			{
				return (string)this["txtFileVersion"];
			}
			set
			{
				this["txtFileVersion"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000CCFA File Offset: 0x0000AEFA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtPool
		{
			get
			{
				return (string)this["txtPool"];
			}
			set
			{
				this["txtPool"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000CD08 File Offset: 0x0000AF08
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000CD1A File Offset: 0x0000AF1A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtWallet
		{
			get
			{
				return (string)this["txtWallet"];
			}
			set
			{
				this["txtWallet"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000CD28 File Offset: 0x0000AF28
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000CD3A File Offset: 0x0000AF3A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtxmrPass
		{
			get
			{
				return (string)this["txtxmrPass"];
			}
			set
			{
				this["txtxmrPass"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000CD48 File Offset: 0x0000AF48
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000CD5A File Offset: 0x0000AF5A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtBlocked
		{
			get
			{
				return (string)this["txtBlocked"];
			}
			set
			{
				this["txtBlocked"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000CD68 File Offset: 0x0000AF68
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000CD7A File Offset: 0x0000AF7A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Default")]
		public string Group
		{
			get
			{
				return (string)this["Group"];
			}
			set
			{
				this["Group"] = value;
			}
		}

		// Token: 0x040000D6 RID: 214
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
