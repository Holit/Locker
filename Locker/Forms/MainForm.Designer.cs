namespace Locker
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.label_Query = new System.Windows.Forms.Label();
            this.QueryTextbox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Checkbox_isSavToSrc = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FriendlyNameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Checkbox_isDelAfterEncrypt = new System.Windows.Forms.CheckBox();
            this.Checkbox_isLoadDB = new System.Windows.Forms.CheckBox();
            this.EncryptPwdTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EncryptDstDialBtn = new System.Windows.Forms.Button();
            this.EncryptSrcDialBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptDstTextbox = new System.Windows.Forms.TextBox();
            this.EncryptSrcTextbox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Checkbox_isUseSrcName = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DecryptPwdTextbox = new System.Windows.Forms.TextBox();
            this.Checkbox_isDelAfterDecrypt = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DecryptDstDialBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DecryptSrcDialBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Checkbox_isMultiAES = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DBDialBtn = new System.Windows.Forms.Button();
            this.Checkbox_isDelDescription = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Checkbox_isAutoloadDB = new System.Windows.Forms.CheckBox();
            this.Checkbox_isEnablePermissionVerify = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SavConfigFileBtn = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_progress = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1050, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "内容索引";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.QueryBtn);
            this.groupBox1.Controls.Add(this.label_Query);
            this.groupBox1.Controls.Add(this.QueryTextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1038, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据内容索引";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(24, 379);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(46, 48);
            this.RefreshBtn.TabIndex = 6;
            this.RefreshBtn.Text = "R";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(694, 346);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "在资源管理器中打开数据库";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 304);
            this.dataGridView1.TabIndex = 4;
            // 
            // QueryBtn
            // 
            this.QueryBtn.Enabled = false;
            this.QueryBtn.Location = new System.Drawing.Point(872, 377);
            this.QueryBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(126, 50);
            this.QueryBtn.TabIndex = 3;
            this.QueryBtn.Text = "查询";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Query
            // 
            this.label_Query.AutoSize = true;
            this.label_Query.Location = new System.Drawing.Point(82, 390);
            this.label_Query.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Query.Name = "label_Query";
            this.label_Query.Size = new System.Drawing.Size(104, 25);
            this.label_Query.TabIndex = 2;
            this.label_Query.Text = "UUID查询";
            // 
            // QueryTextbox
            // 
            this.QueryTextbox.Location = new System.Drawing.Point(200, 377);
            this.QueryTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.QueryTextbox.Name = "QueryTextbox";
            this.QueryTextbox.Size = new System.Drawing.Size(654, 31);
            this.QueryTextbox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.EncryptBtn);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1050, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "加密";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.EncryptBtn.Location = new System.Drawing.Point(856, 162);
            this.EncryptBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(188, 310);
            this.EncryptBtn.TabIndex = 2;
            this.EncryptBtn.Text = "加密";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Checkbox_isSavToSrc);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.DescriptionTextbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.FriendlyNameTextbox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Checkbox_isDelAfterEncrypt);
            this.groupBox3.Controls.Add(this.Checkbox_isLoadDB);
            this.groupBox3.Controls.Add(this.EncryptPwdTextbox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(6, 162);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(838, 310);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置";
            // 
            // Checkbox_isSavToSrc
            // 
            this.Checkbox_isSavToSrc.AutoSize = true;
            this.Checkbox_isSavToSrc.Location = new System.Drawing.Point(448, 42);
            this.Checkbox_isSavToSrc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isSavToSrc.Name = "Checkbox_isSavToSrc";
            this.Checkbox_isSavToSrc.Size = new System.Drawing.Size(212, 29);
            this.Checkbox_isSavToSrc.TabIndex = 13;
            this.Checkbox_isSavToSrc.Text = "加密到源文件路径";
            this.Checkbox_isSavToSrc.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 102);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "密码";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(168, 196);
            this.DescriptionTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(646, 71);
            this.DescriptionTextbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "描述";
            // 
            // FriendlyNameTextbox
            // 
            this.FriendlyNameTextbox.Location = new System.Drawing.Point(168, 140);
            this.FriendlyNameTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FriendlyNameTextbox.Name = "FriendlyNameTextbox";
            this.FriendlyNameTextbox.Size = new System.Drawing.Size(646, 31);
            this.FriendlyNameTextbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "友好名称";
            // 
            // Checkbox_isDelAfterEncrypt
            // 
            this.Checkbox_isDelAfterEncrypt.AutoSize = true;
            this.Checkbox_isDelAfterEncrypt.Location = new System.Drawing.Point(196, 42);
            this.Checkbox_isDelAfterEncrypt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isDelAfterEncrypt.Name = "Checkbox_isDelAfterEncrypt";
            this.Checkbox_isDelAfterEncrypt.Size = new System.Drawing.Size(212, 29);
            this.Checkbox_isDelAfterEncrypt.TabIndex = 7;
            this.Checkbox_isDelAfterEncrypt.Text = "加密后删除源文件";
            this.Checkbox_isDelAfterEncrypt.UseVisualStyleBackColor = true;
            // 
            // Checkbox_isLoadDB
            // 
            this.Checkbox_isLoadDB.AutoSize = true;
            this.Checkbox_isLoadDB.Checked = true;
            this.Checkbox_isLoadDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_isLoadDB.Enabled = false;
            this.Checkbox_isLoadDB.Location = new System.Drawing.Point(16, 42);
            this.Checkbox_isLoadDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isLoadDB.Name = "Checkbox_isLoadDB";
            this.Checkbox_isLoadDB.Size = new System.Drawing.Size(149, 29);
            this.Checkbox_isLoadDB.TabIndex = 5;
            this.Checkbox_isLoadDB.Text = "写入数据库";
            this.Checkbox_isLoadDB.UseVisualStyleBackColor = true;
            // 
            // EncryptPwdTextbox
            // 
            this.EncryptPwdTextbox.Location = new System.Drawing.Point(168, 83);
            this.EncryptPwdTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptPwdTextbox.Name = "EncryptPwdTextbox";
            this.EncryptPwdTextbox.Size = new System.Drawing.Size(646, 31);
            this.EncryptPwdTextbox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EncryptDstDialBtn);
            this.groupBox2.Controls.Add(this.EncryptSrcDialBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EncryptDstTextbox);
            this.groupBox2.Controls.Add(this.EncryptSrcTextbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1038, 156);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "路径及内容指示";
            // 
            // EncryptDstDialBtn
            // 
            this.EncryptDstDialBtn.Location = new System.Drawing.Point(850, 96);
            this.EncryptDstDialBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptDstDialBtn.Name = "EncryptDstDialBtn";
            this.EncryptDstDialBtn.Size = new System.Drawing.Size(62, 48);
            this.EncryptDstDialBtn.TabIndex = 10;
            this.EncryptDstDialBtn.Text = "...";
            this.EncryptDstDialBtn.UseVisualStyleBackColor = true;
            this.EncryptDstDialBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // EncryptSrcDialBtn
            // 
            this.EncryptSrcDialBtn.Location = new System.Drawing.Point(850, 40);
            this.EncryptSrcDialBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptSrcDialBtn.Name = "EncryptSrcDialBtn";
            this.EncryptSrcDialBtn.Size = new System.Drawing.Size(62, 48);
            this.EncryptSrcDialBtn.TabIndex = 4;
            this.EncryptSrcDialBtn.Text = "...";
            this.EncryptSrcDialBtn.UseVisualStyleBackColor = true;
            this.EncryptSrcDialBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "保存路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "源文件路径";
            // 
            // EncryptDstTextbox
            // 
            this.EncryptDstTextbox.Location = new System.Drawing.Point(154, 96);
            this.EncryptDstTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptDstTextbox.Name = "EncryptDstTextbox";
            this.EncryptDstTextbox.Size = new System.Drawing.Size(680, 31);
            this.EncryptDstTextbox.TabIndex = 8;
            // 
            // EncryptSrcTextbox
            // 
            this.EncryptSrcTextbox.Location = new System.Drawing.Point(154, 40);
            this.EncryptSrcTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EncryptSrcTextbox.Name = "EncryptSrcTextbox";
            this.EncryptSrcTextbox.ReadOnly = true;
            this.EncryptSrcTextbox.Size = new System.Drawing.Size(680, 31);
            this.EncryptSrcTextbox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.DecryptBtn);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1050, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "解密";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DecryptBtn.Location = new System.Drawing.Point(862, 156);
            this.DecryptBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(188, 322);
            this.DecryptBtn.TabIndex = 5;
            this.DecryptBtn.Text = "解密";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Checkbox_isUseSrcName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.DecryptPwdTextbox);
            this.groupBox4.Controls.Add(this.Checkbox_isDelAfterDecrypt);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 156);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(838, 322);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "配置";
            // 
            // Checkbox_isUseSrcName
            // 
            this.Checkbox_isUseSrcName.AutoSize = true;
            this.Checkbox_isUseSrcName.Checked = true;
            this.Checkbox_isUseSrcName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_isUseSrcName.Enabled = false;
            this.Checkbox_isUseSrcName.Location = new System.Drawing.Point(16, 156);
            this.Checkbox_isUseSrcName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isUseSrcName.Name = "Checkbox_isUseSrcName";
            this.Checkbox_isUseSrcName.Size = new System.Drawing.Size(212, 29);
            this.Checkbox_isUseSrcName.TabIndex = 9;
            this.Checkbox_isUseSrcName.Text = "按照源文件名解密";
            this.Checkbox_isUseSrcName.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "密码";
            // 
            // DecryptPwdTextbox
            // 
            this.DecryptPwdTextbox.Location = new System.Drawing.Point(86, 54);
            this.DecryptPwdTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DecryptPwdTextbox.Name = "DecryptPwdTextbox";
            this.DecryptPwdTextbox.Size = new System.Drawing.Size(736, 31);
            this.DecryptPwdTextbox.TabIndex = 7;
            // 
            // Checkbox_isDelAfterDecrypt
            // 
            this.Checkbox_isDelAfterDecrypt.AutoSize = true;
            this.Checkbox_isDelAfterDecrypt.Location = new System.Drawing.Point(16, 110);
            this.Checkbox_isDelAfterDecrypt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isDelAfterDecrypt.Name = "Checkbox_isDelAfterDecrypt";
            this.Checkbox_isDelAfterDecrypt.Size = new System.Drawing.Size(233, 29);
            this.Checkbox_isDelAfterDecrypt.TabIndex = 6;
            this.Checkbox_isDelAfterDecrypt.Text = "解密后删除加密文件";
            this.Checkbox_isDelAfterDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DecryptDstDialBtn);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.DecryptSrcDialBtn);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(1050, 156);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "路径及内容指示";
            // 
            // DecryptDstDialBtn
            // 
            this.DecryptDstDialBtn.Location = new System.Drawing.Point(850, 94);
            this.DecryptDstDialBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DecryptDstDialBtn.Name = "DecryptDstDialBtn";
            this.DecryptDstDialBtn.Size = new System.Drawing.Size(62, 48);
            this.DecryptDstDialBtn.TabIndex = 7;
            this.DecryptDstDialBtn.Text = "...";
            this.DecryptDstDialBtn.UseVisualStyleBackColor = true;
            this.DecryptDstDialBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "保存路径";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 96);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(680, 31);
            this.textBox6.TabIndex = 5;
            // 
            // DecryptSrcDialBtn
            // 
            this.DecryptSrcDialBtn.Location = new System.Drawing.Point(850, 38);
            this.DecryptSrcDialBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DecryptSrcDialBtn.Name = "DecryptSrcDialBtn";
            this.DecryptSrcDialBtn.Size = new System.Drawing.Size(62, 48);
            this.DecryptSrcDialBtn.TabIndex = 4;
            this.DecryptSrcDialBtn.Text = "...";
            this.DecryptSrcDialBtn.UseVisualStyleBackColor = true;
            this.DecryptSrcDialBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "源文件路径";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 40);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(680, 31);
            this.textBox5.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.SavConfigFileBtn);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage4.Size = new System.Drawing.Size(1050, 478);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "高级配置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Checkbox_isMultiAES);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DBDialBtn);
            this.panel1.Controls.Add(this.Checkbox_isDelDescription);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Checkbox_isAutoloadDB);
            this.panel1.Controls.Add(this.Checkbox_isEnablePermissionVerify);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 387);
            this.panel1.TabIndex = 13;
            // 
            // Checkbox_isMultiAES
            // 
            this.Checkbox_isMultiAES.AutoSize = true;
            this.Checkbox_isMultiAES.Location = new System.Drawing.Point(18, 6);
            this.Checkbox_isMultiAES.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isMultiAES.Name = "Checkbox_isMultiAES";
            this.Checkbox_isMultiAES.Size = new System.Drawing.Size(212, 29);
            this.Checkbox_isMultiAES.TabIndex = 1;
            this.Checkbox_isMultiAES.Text = "使用多次AES迭代";
            this.Checkbox_isMultiAES.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 346);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "数据库文件路径";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(855, 50);
            this.label9.TabIndex = 2;
            this.label9.Text = "    多次AES迭代会在数学上有效提高文件加密的不可破解性，但是多次AES迭代会占用大量\r\nCPU资源并占用大量CPU时间。程序能够迭代加密4次，理论上破解可能" +
    "为2.9E-37%";
            // 
            // DBDialBtn
            // 
            this.DBDialBtn.Location = new System.Drawing.Point(582, 335);
            this.DBDialBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DBDialBtn.Name = "DBDialBtn";
            this.DBDialBtn.Size = new System.Drawing.Size(62, 48);
            this.DBDialBtn.TabIndex = 4;
            this.DBDialBtn.Text = "...";
            this.DBDialBtn.UseVisualStyleBackColor = true;
            this.DBDialBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // Checkbox_isDelDescription
            // 
            this.Checkbox_isDelDescription.AutoSize = true;
            this.Checkbox_isDelDescription.Location = new System.Drawing.Point(18, 106);
            this.Checkbox_isDelDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isDelDescription.Name = "Checkbox_isDelDescription";
            this.Checkbox_isDelDescription.Size = new System.Drawing.Size(128, 29);
            this.Checkbox_isDelDescription.TabIndex = 3;
            this.Checkbox_isDelDescription.Text = "删除描述";
            this.Checkbox_isDelDescription.UseVisualStyleBackColor = true;
            this.Checkbox_isDelDescription.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(246, 335);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(320, 31);
            this.textBox7.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(771, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "    描述文字将内嵌到加密后的文件中。您可以选择禁用该功能来防止加密文件过大";
            // 
            // Checkbox_isAutoloadDB
            // 
            this.Checkbox_isAutoloadDB.AutoSize = true;
            this.Checkbox_isAutoloadDB.Location = new System.Drawing.Point(18, 306);
            this.Checkbox_isAutoloadDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isAutoloadDB.Name = "Checkbox_isAutoloadDB";
            this.Checkbox_isAutoloadDB.Size = new System.Drawing.Size(191, 29);
            this.Checkbox_isAutoloadDB.TabIndex = 10;
            this.Checkbox_isAutoloadDB.Text = "自动加载数据库";
            this.Checkbox_isAutoloadDB.UseVisualStyleBackColor = true;
            this.Checkbox_isAutoloadDB.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // Checkbox_isEnablePermissionVerify
            // 
            this.Checkbox_isEnablePermissionVerify.AutoSize = true;
            this.Checkbox_isEnablePermissionVerify.Checked = true;
            this.Checkbox_isEnablePermissionVerify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_isEnablePermissionVerify.Enabled = false;
            this.Checkbox_isEnablePermissionVerify.Location = new System.Drawing.Point(18, 181);
            this.Checkbox_isEnablePermissionVerify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Checkbox_isEnablePermissionVerify.Name = "Checkbox_isEnablePermissionVerify";
            this.Checkbox_isEnablePermissionVerify.Size = new System.Drawing.Size(170, 29);
            this.Checkbox_isEnablePermissionVerify.TabIndex = 5;
            this.Checkbox_isEnablePermissionVerify.Text = "启用授权验证";
            this.Checkbox_isEnablePermissionVerify.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(641, 75);
            this.label11.TabIndex = 6;
            this.label11.Text = "    授权验证是为了防止未授权的访问导致的数据库泄密。\r\n授权文件由{UUID1+UUID2+UUID3}{MD5}构成的Base64字符串构成\r\n禁用授权验证" +
    "可以简化操作，使用密码验证";
            // 
            // SavConfigFileBtn
            // 
            this.SavConfigFileBtn.Location = new System.Drawing.Point(858, 402);
            this.SavConfigFileBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SavConfigFileBtn.Name = "SavConfigFileBtn";
            this.SavConfigFileBtn.Size = new System.Drawing.Size(180, 62);
            this.SavConfigFileBtn.TabIndex = 0;
            this.SavConfigFileBtn.Text = "保存配置文件";
            this.SavConfigFileBtn.UseVisualStyleBackColor = true;
            this.SavConfigFileBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.pictureBox2);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage5.Size = new System.Drawing.Size(1050, 478);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "关于";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Locker.Properties.Resources._128277_24_7;
            this.pictureBox3.Location = new System.Drawing.Point(6, 125);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 322);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Locker.Properties.Resources._175202_26_3;
            this.pictureBox2.Location = new System.Drawing.Point(338, 125);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 322);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Locker.Properties.Resources._58068_80_7;
            this.pictureBox1.Location = new System.Drawing.Point(702, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(6, 447);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1038, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "警告：这是一个私人程序，任何未经授权的访问可能会导致您负法律责任";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(6, 6);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1038, 119);
            this.label16.TabIndex = 0;
            this.label16.Text = "    这是一个私有加密工具，目的是防止未经允许的文件访问。\r\n    本工具使用AES32位加密，采用MD5密码格式和内嵌合成文段方法，加密后的文件能够离线解密" +
    "。\r\n    同时应用程序支持存储入数据库，使用UUID进行索引和文件名加密，防止文件名泄密。\r\n\r\n\r\n    ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1066, 41);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusToolStrip
            // 
            this.statusToolStrip.Name = "statusToolStrip";
            this.statusToolStrip.Size = new System.Drawing.Size(62, 31);
            this.statusToolStrip.Text = "就绪";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 563);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1066, 56);
            this.progressBar.TabIndex = 6;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_progress.Location = new System.Drawing.Point(0, 538);
            this.label_progress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(96, 25);
            this.label_progress.TabIndex = 7;
            this.label_progress.Text = "操作进度";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 660);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Locker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.Label label_Query;
        private System.Windows.Forms.TextBox QueryTextbox;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Checkbox_isLoadDB;
        private System.Windows.Forms.TextBox EncryptPwdTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EncryptSrcDialBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptSrcTextbox;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button DecryptSrcDialBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button DBDialBtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox Checkbox_isDelAfterEncrypt;
        private System.Windows.Forms.CheckBox Checkbox_isDelAfterDecrypt;
        private System.Windows.Forms.Button DecryptDstDialBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button EncryptDstDialBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EncryptDstTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FriendlyNameTextbox;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DecryptPwdTextbox;
        private System.Windows.Forms.CheckBox Checkbox_isUseSrcName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Checkbox_isEnablePermissionVerify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Checkbox_isDelDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Checkbox_isMultiAES;
        private System.Windows.Forms.Button SavConfigFileBtn;
        private System.Windows.Forms.CheckBox Checkbox_isAutoloadDB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox Checkbox_isSavToSrc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

