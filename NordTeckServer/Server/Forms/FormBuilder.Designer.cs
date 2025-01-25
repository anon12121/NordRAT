namespace Server.Forms
{
	// Token: 0x0200005E RID: 94
	public partial class FormBuilder : global::System.Windows.Forms.Form
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00014090 File Offset: 0x00012290
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000140B0 File Offset: 0x000122B0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormBuilder));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnRemoveIP = new global::System.Windows.Forms.Button();
			this.btnAddIP = new global::System.Windows.Forms.Button();
			this.listBoxIP = new global::System.Windows.Forms.ListBox();
			this.textIP = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnRemovePort = new global::System.Windows.Forms.Button();
			this.btnAddPort = new global::System.Windows.Forms.Button();
			this.listBoxPort = new global::System.Windows.Forms.ListBox();
			this.chkPastebin = new global::System.Windows.Forms.CheckBox();
			this.txtPastebin = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textPort = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.comboBoxFolder = new global::System.Windows.Forms.ComboBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textFilename = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.txtGroup = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.numDelay = new global::System.Windows.Forms.NumericUpDown();
			this.label16 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.chkBdos = new global::System.Windows.Forms.CheckBox();
			this.txtMutex = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.chkAnti = new global::System.Windows.Forms.CheckBox();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.btnClone = new global::System.Windows.Forms.Button();
			this.btnAssembly = new global::System.Windows.Forms.CheckBox();
			this.txtFileVersion = new global::System.Windows.Forms.TextBox();
			this.txtProductVersion = new global::System.Windows.Forms.TextBox();
			this.txtOriginalFilename = new global::System.Windows.Forms.TextBox();
			this.txtTrademarks = new global::System.Windows.Forms.TextBox();
			this.txtCopyright = new global::System.Windows.Forms.TextBox();
			this.txtCompany = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtDescription = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtProduct = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.chkIcon = new global::System.Windows.Forms.CheckBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtIcon = new global::System.Windows.Forms.TextBox();
			this.btnIcon = new global::System.Windows.Forms.Button();
			this.picIcon = new global::System.Windows.Forms.PictureBox();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.chkObfu = new global::System.Windows.Forms.CheckBox();
			this.btnBuild = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
			this.tabPage6.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.btnRemoveIP);
			this.groupBox1.Controls.Add(this.btnAddIP);
			this.groupBox1.Controls.Add(this.listBoxIP);
			this.groupBox1.Controls.Add(this.textIP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnRemovePort);
			this.groupBox1.Controls.Add(this.btnAddPort);
			this.groupBox1.Controls.Add(this.listBoxPort);
			this.groupBox1.Controls.Add(this.chkPastebin);
			this.groupBox1.Controls.Add(this.txtPastebin);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new global::System.Drawing.Point(4, 12);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new global::System.Drawing.Size(391, 284);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection";
			this.btnRemoveIP.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRemoveIP.Location = new global::System.Drawing.Point(127, 101);
			this.btnRemoveIP.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRemoveIP.Name = "btnRemoveIP";
			this.btnRemoveIP.Size = new global::System.Drawing.Size(29, 17);
			this.btnRemoveIP.TabIndex = 18;
			this.btnRemoveIP.Text = "-";
			this.btnRemoveIP.UseVisualStyleBackColor = true;
			this.btnRemoveIP.Click += new global::System.EventHandler(this.BtnRemoveIP_Click);
			this.btnAddIP.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddIP.Location = new global::System.Drawing.Point(48, 101);
			this.btnAddIP.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddIP.Name = "btnAddIP";
			this.btnAddIP.Size = new global::System.Drawing.Size(29, 17);
			this.btnAddIP.TabIndex = 17;
			this.btnAddIP.Text = "+";
			this.btnAddIP.UseVisualStyleBackColor = true;
			this.btnAddIP.Click += new global::System.EventHandler(this.BtnAddIP_Click);
			this.listBoxIP.FormattingEnabled = true;
			this.listBoxIP.Location = new global::System.Drawing.Point(48, 43);
			this.listBoxIP.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxIP.Name = "listBoxIP";
			this.listBoxIP.Size = new global::System.Drawing.Size(109, 56);
			this.listBoxIP.TabIndex = 16;
			this.textIP.Location = new global::System.Drawing.Point(48, 22);
			this.textIP.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textIP.Name = "textIP";
			this.textIP.Size = new global::System.Drawing.Size(109, 20);
			this.textIP.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 24);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(30, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "DNS";
			this.btnRemovePort.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRemovePort.Location = new global::System.Drawing.Point(320, 101);
			this.btnRemovePort.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRemovePort.Name = "btnRemovePort";
			this.btnRemovePort.Size = new global::System.Drawing.Size(29, 17);
			this.btnRemovePort.TabIndex = 13;
			this.btnRemovePort.Text = "-";
			this.btnRemovePort.UseVisualStyleBackColor = true;
			this.btnRemovePort.Click += new global::System.EventHandler(this.BtnRemovePort_Click);
			this.btnAddPort.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddPort.Location = new global::System.Drawing.Point(241, 101);
			this.btnAddPort.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddPort.Name = "btnAddPort";
			this.btnAddPort.Size = new global::System.Drawing.Size(29, 17);
			this.btnAddPort.TabIndex = 12;
			this.btnAddPort.Text = "+";
			this.btnAddPort.UseVisualStyleBackColor = true;
			this.btnAddPort.Click += new global::System.EventHandler(this.BtnAddPort_Click);
			this.listBoxPort.FormattingEnabled = true;
			this.listBoxPort.Location = new global::System.Drawing.Point(241, 43);
			this.listBoxPort.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxPort.Name = "listBoxPort";
			this.listBoxPort.Size = new global::System.Drawing.Size(109, 56);
			this.listBoxPort.TabIndex = 10;
			this.chkPastebin.AutoSize = true;
			this.chkPastebin.Location = new global::System.Drawing.Point(15, 200);
			this.chkPastebin.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkPastebin.Name = "chkPastebin";
			this.chkPastebin.Size = new global::System.Drawing.Size(89, 17);
			this.chkPastebin.TabIndex = 9;
			this.chkPastebin.Text = "Use Pastebin";
			this.toolTip1.SetToolTip(this.chkPastebin, "IP:PORT .. Example 127.0.0.1:6606");
			this.chkPastebin.UseVisualStyleBackColor = true;
			this.chkPastebin.CheckedChanged += new global::System.EventHandler(this.CheckBox2_CheckedChanged);
			this.txtPastebin.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Pastebin", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPastebin.Enabled = false;
			this.txtPastebin.Location = new global::System.Drawing.Point(71, 229);
			this.txtPastebin.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPastebin.Name = "txtPastebin";
			this.txtPastebin.Size = new global::System.Drawing.Size(182, 20);
			this.txtPastebin.TabIndex = 8;
			this.txtPastebin.Text = global::Server.Properties.Settings.Default.Pastebin;
			this.toolTip1.SetToolTip(this.txtPastebin, "IP:PORT .. Example 127.0.0.1:6606");
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(9, 231);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(48, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Pastebin";
			this.textPort.Location = new global::System.Drawing.Point(241, 22);
			this.textPort.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textPort.Name = "textPort";
			this.textPort.Size = new global::System.Drawing.Size(109, 20);
			this.textPort.TabIndex = 6;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(205, 24);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(26, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Port";
			this.groupBox2.Controls.Add(this.comboBoxFolder);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.textFilename);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new global::System.Drawing.Point(4, 11);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new global::System.Drawing.Size(390, 285);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Install";
			this.comboBoxFolder.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFolder.Enabled = false;
			this.comboBoxFolder.FormattingEnabled = true;
			this.comboBoxFolder.Items.AddRange(new object[]
			{
				"%AppData%",
				"%Temp%"
			});
			this.comboBoxFolder.Location = new global::System.Drawing.Point(69, 97);
			this.comboBoxFolder.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxFolder.Name = "comboBoxFolder";
			this.comboBoxFolder.Size = new global::System.Drawing.Size(182, 21);
			this.comboBoxFolder.TabIndex = 8;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(10, 19);
			this.checkBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(46, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "OFF";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.textFilename.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Filename", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textFilename.Enabled = false;
			this.textFilename.Location = new global::System.Drawing.Point(69, 60);
			this.textFilename.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textFilename.Name = "textFilename";
			this.textFilename.Size = new global::System.Drawing.Size(182, 20);
			this.textFilename.TabIndex = 5;
			this.textFilename.Text = global::Server.Properties.Settings.Default.Filename;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 99);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(36, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Folder";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 62);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(49, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Filename";
			this.groupBox3.Controls.Add(this.txtGroup);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.numDelay);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this.chkBdos);
			this.groupBox3.Controls.Add(this.txtMutex);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.chkAnti);
			this.groupBox3.Location = new global::System.Drawing.Point(4, 11);
			this.groupBox3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new global::System.Drawing.Size(390, 285);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "MISC";
			this.txtGroup.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Group", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtGroup.Location = new global::System.Drawing.Point(15, 49);
			this.txtGroup.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.Size = new global::System.Drawing.Size(202, 20);
			this.txtGroup.TabIndex = 17;
			this.txtGroup.Text = global::Server.Properties.Settings.Default.Group;
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(13, 28);
			this.label17.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(36, 13);
			this.label17.TabIndex = 16;
			this.label17.Text = "Group";
			this.numDelay.Location = new global::System.Drawing.Point(18, 239);
			this.numDelay.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numDelay;
			int[] array = new int[4];
			array[0] = 999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numDelay;
			int[] array2 = new int[4];
			array2[0] = 3;
			numericUpDown2.Minimum = new decimal(array2);
			this.numDelay.Name = "numDelay";
			this.numDelay.Size = new global::System.Drawing.Size(56, 20);
			this.numDelay.TabIndex = 15;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numDelay;
			int[] array3 = new int[4];
			array3[0] = 3;
			numericUpDown3.Value = new decimal(array3);
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(15, 218);
			this.label16.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(83, 13);
			this.label16.TabIndex = 14;
			this.label16.Text = "Delay (seconds)";
			this.pictureBox1.Image = global::Server.Properties.Resources.uac;
			this.pictureBox1.Location = new global::System.Drawing.Point(122, 179);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.chkBdos.AutoSize = true;
			this.chkBdos.Location = new global::System.Drawing.Point(15, 184);
			this.chkBdos.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkBdos.Name = "chkBdos";
			this.chkBdos.Size = new global::System.Drawing.Size(98, 17);
			this.chkBdos.TabIndex = 12;
			this.chkBdos.Text = "Process Critical";
			this.chkBdos.UseVisualStyleBackColor = true;
			this.txtMutex.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Mutex", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtMutex.Location = new global::System.Drawing.Point(15, 106);
			this.txtMutex.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMutex.Name = "txtMutex";
			this.txtMutex.Size = new global::System.Drawing.Size(202, 20);
			this.txtMutex.TabIndex = 11;
			this.txtMutex.Text = global::Server.Properties.Settings.Default.Mutex;
			this.txtMutex.MouseEnter += new global::System.EventHandler(this.txtMutex_MouseEnter);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(13, 85);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(36, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Mutex";
			this.chkAnti.AutoSize = true;
			this.chkAnti.Location = new global::System.Drawing.Point(15, 151);
			this.chkAnti.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkAnti.Name = "chkAnti";
			this.chkAnti.Size = new global::System.Drawing.Size(85, 17);
			this.chkAnti.TabIndex = 9;
			this.chkAnti.Text = "Anti Analysis";
			this.chkAnti.UseVisualStyleBackColor = true;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(405, 323);
			this.tabControl1.TabIndex = 10;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Connection";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Install";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Misc";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.tabPage4.Controls.Add(this.groupBox4);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage4.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage4.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Assembly";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.groupBox4.Controls.Add(this.btnClone);
			this.groupBox4.Controls.Add(this.btnAssembly);
			this.groupBox4.Controls.Add(this.txtFileVersion);
			this.groupBox4.Controls.Add(this.txtProductVersion);
			this.groupBox4.Controls.Add(this.txtOriginalFilename);
			this.groupBox4.Controls.Add(this.txtTrademarks);
			this.groupBox4.Controls.Add(this.txtCopyright);
			this.groupBox4.Controls.Add(this.txtCompany);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.txtDescription);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.txtProduct);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Location = new global::System.Drawing.Point(4, 11);
			this.groupBox4.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Size = new global::System.Drawing.Size(390, 285);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Assembly Information";
			this.btnClone.Enabled = false;
			this.btnClone.Location = new global::System.Drawing.Point(302, 28);
			this.btnClone.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnClone.Name = "btnClone";
			this.btnClone.Size = new global::System.Drawing.Size(69, 25);
			this.btnClone.TabIndex = 21;
			this.btnClone.Text = "Clone";
			this.btnClone.UseVisualStyleBackColor = true;
			this.btnClone.Click += new global::System.EventHandler(this.BtnClone_Click);
			this.btnAssembly.AutoSize = true;
			this.btnAssembly.Location = new global::System.Drawing.Point(10, 19);
			this.btnAssembly.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAssembly.Name = "btnAssembly";
			this.btnAssembly.Size = new global::System.Drawing.Size(59, 17);
			this.btnAssembly.TabIndex = 20;
			this.btnAssembly.Text = "Enable";
			this.btnAssembly.UseVisualStyleBackColor = true;
			this.btnAssembly.CheckedChanged += new global::System.EventHandler(this.BtnAssembly_CheckedChanged);
			this.txtFileVersion.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtFileVersion", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtFileVersion.Enabled = false;
			this.txtFileVersion.Location = new global::System.Drawing.Point(106, 259);
			this.txtFileVersion.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtFileVersion.Name = "txtFileVersion";
			this.txtFileVersion.Size = new global::System.Drawing.Size(266, 20);
			this.txtFileVersion.TabIndex = 19;
			this.txtFileVersion.Text = global::Server.Properties.Settings.Default.txtFileVersion;
			this.txtProductVersion.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtProductVersion", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtProductVersion.Enabled = false;
			this.txtProductVersion.Location = new global::System.Drawing.Point(106, 231);
			this.txtProductVersion.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtProductVersion.Name = "txtProductVersion";
			this.txtProductVersion.Size = new global::System.Drawing.Size(266, 20);
			this.txtProductVersion.TabIndex = 18;
			this.txtProductVersion.Text = global::Server.Properties.Settings.Default.txtProductVersion;
			this.txtOriginalFilename.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtOriginalFilename", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtOriginalFilename.Enabled = false;
			this.txtOriginalFilename.Location = new global::System.Drawing.Point(106, 204);
			this.txtOriginalFilename.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtOriginalFilename.Name = "txtOriginalFilename";
			this.txtOriginalFilename.Size = new global::System.Drawing.Size(266, 20);
			this.txtOriginalFilename.TabIndex = 17;
			this.txtOriginalFilename.Text = global::Server.Properties.Settings.Default.txtOriginalFilename;
			this.txtTrademarks.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtTrademarks", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtTrademarks.Enabled = false;
			this.txtTrademarks.Location = new global::System.Drawing.Point(106, 177);
			this.txtTrademarks.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTrademarks.Name = "txtTrademarks";
			this.txtTrademarks.Size = new global::System.Drawing.Size(266, 20);
			this.txtTrademarks.TabIndex = 16;
			this.txtTrademarks.Text = global::Server.Properties.Settings.Default.txtTrademarks;
			this.txtCopyright.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCopyright", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtCopyright.Enabled = false;
			this.txtCopyright.Location = new global::System.Drawing.Point(106, 149);
			this.txtCopyright.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCopyright.Name = "txtCopyright";
			this.txtCopyright.Size = new global::System.Drawing.Size(266, 20);
			this.txtCopyright.TabIndex = 15;
			this.txtCopyright.Text = global::Server.Properties.Settings.Default.txtCopyright;
			this.txtCompany.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCompany", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtCompany.Enabled = false;
			this.txtCompany.Location = new global::System.Drawing.Point(106, 122);
			this.txtCompany.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new global::System.Drawing.Size(266, 20);
			this.txtCompany.TabIndex = 14;
			this.txtCompany.Text = global::Server.Properties.Settings.Default.txtCompany;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(5, 233);
			this.label14.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(85, 13);
			this.label14.TabIndex = 13;
			this.label14.Text = "Product Version:";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(5, 261);
			this.label13.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(64, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "File Version:";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(5, 206);
			this.label12.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(90, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Original Filename:";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(5, 179);
			this.label11.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(66, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Trademarks:";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(5, 151);
			this.label10.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(54, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Copyright:";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(5, 124);
			this.label9.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(54, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Company:";
			this.txtDescription.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtDescription", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtDescription.Enabled = false;
			this.txtDescription.Location = new global::System.Drawing.Point(106, 95);
			this.txtDescription.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new global::System.Drawing.Size(266, 20);
			this.txtDescription.TabIndex = 7;
			this.txtDescription.Text = global::Server.Properties.Settings.Default.txtDescription;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(5, 97);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(63, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Description:";
			this.txtProduct.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "ProductName", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtProduct.Enabled = false;
			this.txtProduct.Location = new global::System.Drawing.Point(106, 68);
			this.txtProduct.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new global::System.Drawing.Size(266, 20);
			this.txtProduct.TabIndex = 5;
			this.txtProduct.Text = global::Server.Properties.Settings.Default.ProductName;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(5, 70);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(47, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Product:";
			this.tabPage5.Controls.Add(this.groupBox5);
			this.tabPage5.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage5.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage5.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Icon";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.groupBox5.Controls.Add(this.chkIcon);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.txtIcon);
			this.groupBox5.Controls.Add(this.btnIcon);
			this.groupBox5.Controls.Add(this.picIcon);
			this.groupBox5.Location = new global::System.Drawing.Point(4, 11);
			this.groupBox5.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox5.Size = new global::System.Drawing.Size(390, 285);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Add Icon";
			this.chkIcon.AutoSize = true;
			this.chkIcon.Location = new global::System.Drawing.Point(10, 19);
			this.chkIcon.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkIcon.Name = "chkIcon";
			this.chkIcon.Size = new global::System.Drawing.Size(59, 17);
			this.chkIcon.TabIndex = 8;
			this.chkIcon.Text = "Enable";
			this.chkIcon.UseVisualStyleBackColor = true;
			this.chkIcon.CheckedChanged += new global::System.EventHandler(this.ChkIcon_CheckedChanged);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(7, 58);
			this.label15.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(29, 13);
			this.label15.TabIndex = 7;
			this.label15.Text = "Path";
			this.txtIcon.Enabled = false;
			this.txtIcon.Location = new global::System.Drawing.Point(10, 79);
			this.txtIcon.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtIcon.Name = "txtIcon";
			this.txtIcon.Size = new global::System.Drawing.Size(299, 20);
			this.txtIcon.TabIndex = 6;
			this.btnIcon.Enabled = false;
			this.btnIcon.Location = new global::System.Drawing.Point(323, 79);
			this.btnIcon.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.Size = new global::System.Drawing.Size(40, 17);
			this.btnIcon.TabIndex = 5;
			this.btnIcon.Text = " ";
			this.btnIcon.UseVisualStyleBackColor = true;
			this.btnIcon.Click += new global::System.EventHandler(this.BtnIcon_Click);
			this.picIcon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIcon.ErrorImage = null;
			this.picIcon.InitialImage = null;
			this.picIcon.Location = new global::System.Drawing.Point(10, 111);
			this.picIcon.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new global::System.Drawing.Size(86, 84);
			this.picIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIcon.TabIndex = 4;
			this.picIcon.TabStop = false;
			this.tabPage6.Controls.Add(this.chkObfu);
			this.tabPage6.Controls.Add(this.btnBuild);
			this.tabPage6.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage6.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage6.Size = new global::System.Drawing.Size(397, 297);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Build";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.chkObfu.AutoSize = true;
			this.chkObfu.Location = new global::System.Drawing.Point(12, 96);
			this.chkObfu.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkObfu.Name = "chkObfu";
			this.chkObfu.Size = new global::System.Drawing.Size(112, 17);
			this.chkObfu.TabIndex = 2;
			this.chkObfu.Text = "Simple Obfuscator";
			this.chkObfu.UseVisualStyleBackColor = true;
			this.btnBuild.Location = new global::System.Drawing.Point(12, 127);
			this.btnBuild.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnBuild.Name = "btnBuild";
			this.btnBuild.Size = new global::System.Drawing.Size(359, 32);
			this.btnBuild.TabIndex = 1;
			this.btnBuild.Text = "Build";
			this.btnBuild.UseVisualStyleBackColor = true;
			this.btnBuild.Click += new global::System.EventHandler(this.BtnBuild_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(405, 323);
			base.Controls.Add(this.tabControl1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "FormBuilder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Builder";
			base.Load += new global::System.EventHandler(this.Builder_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400016B RID: 363
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.TextBox textFilename;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.ComboBox comboBoxFolder;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.CheckBox chkAnti;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.TextBox txtMutex;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.TextBox txtPastebin;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.CheckBox chkPastebin;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.CheckBox chkBdos;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.ListBox listBoxPort;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.TextBox textPort;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Button btnAddPort;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.Button btnRemovePort;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Button btnRemoveIP;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.Button btnAddIP;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.ListBox listBoxIP;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.TextBox textIP;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.TextBox txtFileVersion;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.TextBox txtProductVersion;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.TextBox txtOriginalFilename;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.TextBox txtTrademarks;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.TextBox txtCopyright;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.TextBox txtCompany;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.TextBox txtDescription;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.TextBox txtProduct;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400019F RID: 415
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040001A0 RID: 416
		private global::System.Windows.Forms.TextBox txtIcon;

		// Token: 0x040001A1 RID: 417
		private global::System.Windows.Forms.PictureBox picIcon;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.Forms.CheckBox chkIcon;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.CheckBox btnAssembly;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.Button btnBuild;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.CheckBox chkObfu;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Forms.Button btnClone;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.Button btnIcon;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.NumericUpDown numDelay;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.TextBox txtGroup;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Label label17;
	}
}
