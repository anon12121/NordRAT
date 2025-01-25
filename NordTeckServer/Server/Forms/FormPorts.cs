using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Helper;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200006D RID: 109
	public partial class FormPorts : Form
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0001D609 File Offset: 0x0001B809
		public FormPorts()
		{
			this.InitializeComponent();
			base.Opacity = 0.0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001D628 File Offset: 0x0001B828
		private void PortsFrm_Load(object sender, EventArgs e)
		{
			Methods.FadeIn(this, 5);
			if (Settings.Default.Ports.Length == 0)
			{
				this.listBox1.Items.AddRange(new object[]
				{
					"6606",
					"7707",
					"8808"
				});
			}
			else
			{
				try
				{
					foreach (string text in Settings.Default.Ports.Split(new string[]
					{
						","
					}, StringSplitOptions.None))
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							this.listBox1.Items.Add(text.Trim());
						}
					}
				}
				catch
				{
				}
			}
			this.Text = Settings.Version + " | Welcome " + Environment.UserName;
			if (!File.Exists(Settings.CertificatePath))
			{
				using (FormCertificate formCertificate = new FormCertificate())
				{
					formCertificate.ShowDialog();
					return;
				}
			}
			Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001D740 File Offset: 0x0001B940
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count > 0)
			{
				string text = "";
				foreach (object obj in this.listBox1.Items)
				{
					string str = (string)obj;
					text = text + str + ",";
				}
				Settings.Default.Ports = text.Remove(text.Length - 1);
				Settings.Default.Save();
				FormPorts.isOK = true;
				base.Close();
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001D7EC File Offset: 0x0001B9EC
		private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!FormPorts.isOK)
			{
				Program.form1.notifyIcon1.Dispose();
				Environment.Exit(0);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001D80C File Offset: 0x0001BA0C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Convert.ToInt32(this.textPorts.Text.Trim());
				this.listBox1.Items.Add(this.textPorts.Text.Trim());
				this.textPorts.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001D870 File Offset: 0x0001BA70
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Remove(this.listBox1.SelectedItem);
		}

		// Token: 0x0400023E RID: 574
		private static bool isOK;
	}
}
