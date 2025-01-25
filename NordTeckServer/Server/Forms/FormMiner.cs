using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200006B RID: 107
	public partial class FormMiner : Form
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0001CC32 File Offset: 0x0001AE32
		public FormMiner()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001CC40 File Offset: 0x0001AE40
		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtPool.Text) && !string.IsNullOrWhiteSpace(this.txtWallet.Text) && !string.IsNullOrWhiteSpace(this.txtPass.Text))
			{
				base.DialogResult = DialogResult.OK;
				Settings.Default.Save();
				base.Hide();
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		private void FormMiner_Load(object sender, EventArgs e)
		{
			try
			{
				this.comboInjection.SelectedIndex = 0;
				this.txtPool.Text = Settings.Default.txtPool;
				this.txtWallet.Text = Settings.Default.txtWallet;
				this.txtPass.Text = Settings.Default.txtxmrPass;
			}
			catch
			{
			}
		}
	}
}
