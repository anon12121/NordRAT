namespace Server.Forms
{
	// Token: 0x02000065 RID: 101
	public partial class FormDOS : global::System.Windows.Forms.Form
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0001828C File Offset: 0x0001648C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000182AC File Offset: 0x000164AC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormDOS));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtPort = new global::System.Windows.Forms.TextBox();
			this.txtHost = new global::System.Windows.Forms.TextBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTimeout = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnAttack = new global::System.Windows.Forms.Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.txtHost);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(596, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Target";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(415, 47);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "PORT";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(17, 47);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "HOST";
			this.txtPort.Location = new global::System.Drawing.Point(477, 44);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new global::System.Drawing.Size(70, 26);
			this.txtPort.TabIndex = 1;
			this.txtPort.Text = "80";
			this.txtHost.Location = new global::System.Drawing.Point(79, 44);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new global::System.Drawing.Size(293, 26);
			this.txtHost.TabIndex = 1;
			this.txtHost.Text = "www.google.com";
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtTimeout);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 146);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(596, 102);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(178, 45);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(38, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "min.";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(18, 45);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(80, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "TIMEOUT";
			this.txtTimeout.Location = new global::System.Drawing.Point(109, 42);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new global::System.Drawing.Size(63, 26);
			this.txtTimeout.TabIndex = 3;
			this.txtTimeout.Text = "5";
			this.groupBox3.Controls.Add(this.btnStop);
			this.groupBox3.Controls.Add(this.btnAttack);
			this.groupBox3.Location = new global::System.Drawing.Point(12, 282);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(596, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Command";
			this.btnStop.Enabled = false;
			this.btnStop.Location = new global::System.Drawing.Point(477, 35);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(107, 43);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.BtnStop_Click);
			this.btnAttack.Location = new global::System.Drawing.Point(22, 35);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new global::System.Drawing.Size(107, 43);
			this.btnAttack.TabIndex = 0;
			this.btnAttack.Text = "Attack";
			this.btnAttack.UseVisualStyleBackColor = true;
			this.btnAttack.Click += new global::System.EventHandler(this.BtnAttack_Click);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.timer2.Interval = 5000;
			this.timer2.Tick += new global::System.EventHandler(this.Timer2_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(631, 408);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormDOS";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DOS";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormDOS_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001CE RID: 462
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.TextBox txtPort;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.TextBox txtTimeout;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.Button btnAttack;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.Timer timer2;
	}
}
