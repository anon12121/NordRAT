using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Server.Forms
{
	// Token: 0x02000061 RID: 97
	public partial class FormCertificate : Form
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00017266 File Offset: 0x00015466
		public FormCertificate()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00017274 File Offset: 0x00015474
		private void FormCertificate_Load(object sender, EventArgs e)
		{
			try
			{
				string text = Application.StartupPath + "\\BackupCertificate.zip";
				if (File.Exists(text))
				{
					MessageBox.Show(this, "Found a zip backup, Extracting (BackupCertificate.zip)", "Certificate backup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ZipFile.ExtractToDirectory(text, Application.StartupPath);
					Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000172F8 File Offset: 0x000154F8
		private void Button1_Click(object sender, EventArgs e)
		{
			FormCertificate.<Button1_Click>d__2 <Button1_Click>d__;
			<Button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Button1_Click>d__.<>4__this = this;
			<Button1_Click>d__.<>1__state = -1;
			<Button1_Click>d__.<>t__builder.Start<FormCertificate.<Button1_Click>d__2>(ref <Button1_Click>d__);
		}
	}
}
