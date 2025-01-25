using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200005D RID: 93
	public partial class FormBlockClients : Form
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x000125DD File Offset: 0x000107DD
		public FormBlockClients()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000125EC File Offset: 0x000107EC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				this.listBlocked.Items.Add(this.txtBlock.Text);
				this.txtBlock.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00012638 File Offset: 0x00010838
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = this.listBlocked.SelectedIndices.Count - 1; i >= 0; i--)
				{
					this.listBlocked.Items.RemoveAt(this.listBlocked.SelectedIndices[i]);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00012698 File Offset: 0x00010898
		private void FormBlockClients_Load(object sender, EventArgs e)
		{
			try
			{
				this.listBlocked.Items.Clear();
				if (!string.IsNullOrWhiteSpace(Settings.Default.txtBlocked))
				{
					foreach (string text in Settings.Default.txtBlocked.Split(new char[]
					{
						','
					}))
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							this.listBlocked.Items.Add(text);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00012724 File Offset: 0x00010924
		private void FormBlockClients_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				List<string> blocked = Settings.Blocked;
				lock (blocked)
				{
					Settings.Blocked.Clear();
					List<string> list = new List<string>();
					foreach (object obj in this.listBlocked.Items)
					{
						string item = (string)obj;
						list.Add(item);
						Settings.Blocked.Add(item);
					}
					Settings.Default.txtBlocked = string.Join(",", list);
					Settings.Default.Save();
				}
			}
			catch
			{
			}
		}
	}
}
