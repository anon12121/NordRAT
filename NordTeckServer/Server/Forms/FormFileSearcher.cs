using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Forms
{
	// Token: 0x02000069 RID: 105
	public partial class FormFileSearcher : Form
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0001C14C File Offset: 0x0001A34C
		public FormFileSearcher()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001C15A File Offset: 0x0001A35A
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtExtnsions.Text) && this.numericUpDown1.Value > 0m)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
