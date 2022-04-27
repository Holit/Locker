using Azylee.Core.DelegateUtils.ProcessDelegateUtils;
using Locker.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Locker
{
    //UUID,源文件名,友好名称,大小,单位,文件类型,加密后文件类型,加密类型,内部密码,存储位置,存储路径
    /*
     * 
     */
    public partial class MainForm : Form
    {
        bool is_loaded_database = false;
        delegate void AddItemCallback(string text);
        string exefilepath = System.IO.Directory.GetCurrentDirectory();
        string mdbPath = "D:\\Program Files (Custom)\\Locker\\Database\\db.mdb";

        delegate void ActionProgressDelegate(long Current, long Total);
        void ActionProgress(long Current, long Total)
        {
            progressBar.Maximum = 1000;
            progressBar.Value = (int)((Current * 1000 / Total));
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public void UpdateInfo(string info)
        {
            statusToolStrip.Text = info;
        }
        private  void UpdateProgress(object sender, ProgressEventArgs e)
        {
            ActionProgressDelegate progressDelegate = new ActionProgressDelegate(ActionProgress);
            progressDelegate.Invoke(e.Current, e.Total);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 加载配置
            bool tmp_is_autoloadDB = false;
            if (File.Exists("D:\\Program Files (Custom)\\Locker\\Locker.config"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("D:\\Program Files (Custom)\\Locker\\Locker.config");
                XmlElement rootElem = xmlDoc.DocumentElement;
                XmlNodeList executeNodes = rootElem.GetElementsByTagName("database");

                string dbPath = ((XmlElement)executeNodes.Item(0)).GetAttribute("dbPath");
                //function
                executeNodes = rootElem.GetElementsByTagName("function");
                if (((XmlElement)executeNodes.Item(0)).GetAttribute("isDisableDescription") == "true")
                {
                    Checkbox_isDelDescription.Checked = true;
                }
                //details
                executeNodes = rootElem.GetElementsByTagName("details");
                if (((XmlElement)executeNodes.Item(0)).GetAttribute("isAutoLoadDB") == "true")
                {
                    tmp_is_autoloadDB = true;
                }
                if (((XmlElement)executeNodes.Item(0)).GetAttribute("isMultiAES") == "true")
                {
                    Checkbox_isMultiAES.Checked = true;
                }

                if (File.Exists(dbPath))
                {
                    this.textBox7.Text = dbPath;
                    if(tmp_is_autoloadDB)
                    {
                        mdbPath = textBox7.Text;//载入数据库路径
                        is_loaded_database = true;
                        string Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;//第二个参数为文件的路径  
                        OleDbConnection dbconn = new OleDbConnection(Con);
                        dbconn.Open();//建立连接
                        OleDbDataAdapter inst = new OleDbDataAdapter("SELECT *FROM Files", dbconn);//选择全部内容
                        DataSet ds = new DataSet();//临时存储
                        inst.Fill(ds);//用inst填充ds
                        dataGridView1.DataSource = ds.Tables[0];//展示ds第一张表到dataGridView1控件
                        dbconn.Close();//关闭连接  
                    }
                    is_loaded_database = true;
                    QueryBtn.Enabled = true;
                    linkLabel1.Enabled = true;
                    this.statusToolStrip.Text = "配置文件已加载 就绪";
                }
                else
                {
                    this.statusToolStrip.Text = "数据库不存在 就绪";
                }
            }
            #endregion
            #region 确认功能配置
            if (Checkbox_isDelDescription.Checked)
            {
                DescriptionTextbox.Text = "";
                DescriptionTextbox.Enabled = false;
                DescriptionTextbox.Visible = false;
                label7.Text = "描述已关闭，可以在高级配置中打开";
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = "C://",
                Filter = "任意文件|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    this.EncryptSrcTextbox.Text = fileDialog.FileName;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = "C://",
                Filter = "任意文件|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    this.textBox5.Text = fileDialog.FileName;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            QueryBtn.Enabled = true;
            linkLabel1.Enabled = true;
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = "C://",
                Filter = "Access数据库(2000-2003)(db.mdb)|db.mdb",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    this.textBox7.Text = fileDialog.FileName;
                    mdbPath = textBox7.Text;//载入数据库路径
                    is_loaded_database = true;
                    string Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;//第二个参数为文件的路径  
                    OleDbConnection dbconn = new OleDbConnection(Con);
                    dbconn.Open();//建立连接
                    OleDbDataAdapter inst = new OleDbDataAdapter("SELECT *FROM Files", dbconn);//选择全部内容
                    DataSet ds = new DataSet();//临时存储
                    inst.Fill(ds);//用inst填充ds
                    dataGridView1.DataSource = ds.Tables[0];//展示ds第一张表到dataGridView1控件
                    dbconn.Close();//关闭连接  
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(is_loaded_database)
            {
                string Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;//第二个参数为文件的路径  
                OleDbConnection dbconn = new OleDbConnection(Con);
                dbconn.Open();//建立连接
                DataSet ds = new DataSet();//临时存储

                string s = "'" + QueryTextbox.Text + "'";//接受textBox1的字符串
                string Select = "SELECT *FROM Files WHERE UUID = " + s;
                //select *from 表名 where 字段名='字段值';*表示全表，从全表中
                OleDbDataAdapter inst = new OleDbDataAdapter(Select, dbconn);//只匹配满足条件的行

                inst.Fill(ds);//用inst填充ds
                dataGridView1.DataSource = ds.Tables[0];//展示ds第一张表到dataGridView1控件

                dbconn.Close();//关闭连接
            }
            else
            {
                MessageBox.Show(this, "您需要指定数据库", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EncryptSrcTextbox.Text))
            {
                MessageBox.Show(this, "存在一个或多个参数为零", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (string.IsNullOrWhiteSpace(EncryptDstTextbox.Text))
            {
                if (!Checkbox_isSavToSrc.Checked)
                {
                    MessageBox.Show(this, "存在一个或多个参数为零", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            if (is_loaded_database)
            {
                label_progress.Text = "正在加密";
                string FileUUID = System.Guid.NewGuid().ToString();
                bool DatabaseWrited = Checkbox_isLoadDB.Checked;
                bool DeleteAfterFinished = Checkbox_isDelAfterEncrypt.Checked;
                bool isSaveToSrcPath = Checkbox_isSavToSrc.Checked;

                string srcPath = EncryptSrcTextbox.Text;
                string dstPath;
                if (isSaveToSrcPath)
                {
                    dstPath = Azylee.Core.IOUtils.DirUtils.DirTool.GetFilePath(srcPath) + "\\" + FileUUID + ".locked";
                }
                else
                {

                    dstPath = EncryptDstTextbox.Text + "\\" + FileUUID + ".locked";
                }
                string password = EncryptPwdTextbox.Text;
                string FriendlyName = FriendlyNameTextbox.Text;
                string Description = DescriptionTextbox.Text;

                Attributes propetries = new Attributes();

                propetries.SetPropetries(FileUUID, srcPath, FriendlyName, password, Description);
                //正式解密
                tabControl1.Enabled = false;
                FileEncryptTool.Encrypt(DeleteAfterFinished, propetries, srcPath, dstPath, password,UpdateProgress);
                tabControl1.Enabled = true;

                string Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;//第二个参数为文件的路径  
                OleDbConnection dbconn = new OleDbConnection(Con);
                dbconn.Open();//建立连接
                DataSet ds = new DataSet();//临时存储


                //TODO:新增一条数据库

                string Insert = "INSERT INTO Files(UUID,源文件名,友好名称,大小,文件类型,加密类型,内部密码,存储位置) values('" 
                    + FileUUID + "','" 
                    + propetries.GetName() + "','" 
                    + propetries.GetFriendlyName() + "','"
                    + propetries.GetSize() + "','"
                    + propetries.GetSrcType() + "','"
                    + ".locked" + "','"
                    + propetries.GetPassword_MD5() + "','"
                    + propetries.GetLocation() + "')";

                OleDbCommand myCommand = new OleDbCommand(Insert, dbconn);//执行命令
                myCommand.ExecuteNonQuery();//更新数据库，返回受影响行数;可通过判断其是否>0来判断操作是否成功

                OleDbDataAdapter inst = new OleDbDataAdapter("SELECT *FROM Files", dbconn);//选择全部内容
                inst.Fill(ds);//用inst填充ds

                dataGridView1.DataSource = ds.Tables[0];//展示ds第一张表到dataGridView1控件
                
                UpdateInfo("加密完成");
                dbconn.Close();//关闭连接
            }
            else
            {
                MessageBox.Show(this, "您需要指定数据库", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool DeleteAfterFinished = Checkbox_isDelAfterDecrypt.Checked;
            string srcPath = textBox5.Text;
            string dstPath = textBox6.Text;
            string password = DecryptPwdTextbox.Text;
            if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show(this, "存在一个或多个参数为零", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            DecryptInfo frmRes = new DecryptInfo();
            label_progress.Text = "正在解密";
            //正式解密
            tabControl1.Enabled = false;
            Attributes attributes = FileEncryptTool.Decrypt(srcPath, dstPath, password, UpdateProgress);
            tabControl1.Enabled = true;
            if (attributes.GetResult()<0)
            {
                switch (attributes.GetResult())
                {
                    /// >0：操作成功（操作共计秒数）
                    /// -11：要解密的文件不存在
                    /// -12：解密后的目标文件已存在
                    /// -20：文件类型不匹配
                    /// -30：文件头不长度不吻合
                    /// -90：解锁密码错误
                    /// -100：未知错误，操作失败
                    case -11:
                        MessageBox.Show("要解密的文件不存在", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case -12:
                        MessageBox.Show("解密后的目标文件已存在", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case -20:
                        MessageBox.Show("文件类型不匹配", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case -30:
                        MessageBox.Show("文件头不长度不吻合", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case -90:
                        MessageBox.Show("解锁密码错误", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case -100:
                        MessageBox.Show("未知错误，操作失败", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    default:
                        MessageBox.Show("未知错误，操作失败", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                }
            }
            else
            {
                frmRes.LoadText(attributes, dstPath);
                frmRes.Show();
            }
            UpdateInfo("解密完成");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(EncryptDstTextbox.Text))
            {
                UpdateInfo("目标路径不存在，尝试创建");
                try
                {
                    Azylee.Core.IOUtils.DirUtils.DirTool.Create(textBox6.Text);
                    UpdateInfo("创建成功");
                }
                catch (Exception ex)
                {
                    UpdateInfo(ex.Message);
                    return;
                }
            }
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog
            {
                Description = "选择保存文件夹"
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                EncryptDstTextbox.Text = dialog.SelectedPath;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(!System.IO.Directory.Exists(textBox6.Text))
            {
                UpdateInfo("目标路径不存在，尝试创建");
                try
                {
                    Azylee.Core.IOUtils.DirUtils.DirTool.Create(textBox6.Text);
                    UpdateInfo("创建成功");
                }
                catch (Exception ex)
                {
                    UpdateInfo(ex.Message);
                    return;
                }
            }
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog
            {
                Description = "选择保存文件夹"
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                textBox6.Text = dialog.SelectedPath;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("D:\\Program Files (Custom)\\Locker\\");
            if (File.Exists("D:\\Program Files (Custom)\\Locker\\Locker.config"))
            {
                UpdateInfo("配置文件已存在，正在重建");
                File.Delete("D:\\Program Files (Custom)\\Locker\\Locker.config");
            }
            string dbPath = "D:\\Program Files (Custom)\\Locker\\Database\\db.mdb";

            bool isDisableDescription = Checkbox_isDelDescription.Checked;
            bool isAutoLoadDB = Checkbox_isAutoloadDB.Checked;
            bool isMultiAES = Checkbox_isMultiAES.Checked;

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show(this, "数据库路径不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                dbPath = textBox7.Text;
            }
            XElement xElement = new XElement(
                new XElement("configuration",
                    new XElement("support",
                        new XElement("database", new XAttribute("dbPath", dbPath))
                                ),
                    new XElement("config",
                        new XElement("function", new XAttribute("isDisableDescription", isDisableDescription)),
                        new XElement("details", new XAttribute("isAutoLoadDB", isAutoLoadDB),
                                                  new XAttribute("isMultiAES", isMultiAES))
                                )
                        )
                );
            //需要指定编码格式，否则在读取时会抛：根级别上的数据无效。 第 1 行 位置 1异常
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true
            };
            XmlWriter xw = XmlWriter.Create("D:\\Program Files (Custom)\\Locker\\Locker.config", settings);
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(textBox6.Text))
            {
                UpdateInfo("目标路径不存在，尝试创建");
                try
                {
                    Azylee.Core.IOUtils.DirUtils.DirTool.Create(textBox6.Text);
                    UpdateInfo("创建成功");
                }
                catch (Exception ex)
                {
                    UpdateInfo(ex.Message);
                    return;
                }
            }
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog
            {
                Description = "选择保存文件夹"
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                textBox6.Text = dialog.SelectedPath;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox7.Text))
            {
                Checkbox_isAutoloadDB.Checked = false;
                MessageBox.Show(this, "数据库路径不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_isDelDescription.Checked)
            {
                DescriptionTextbox.Text = "";
                DescriptionTextbox.Enabled = false;
                DescriptionTextbox.Visible = false;
                label7.Text = "描述已关闭，可以在高级配置中打开";
            }
            else
            {
                DescriptionTextbox.Text = "";
                DescriptionTextbox.Enabled = true;
                DescriptionTextbox.Visible = true;
                label7.Text = "描述";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:gao1021229073@163.com");
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(this, "4709", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (is_loaded_database)
            {
                mdbPath = textBox7.Text;//载入数据库路径
                is_loaded_database = true;
                string Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;//第二个参数为文件的路径  
                OleDbConnection dbconn = new OleDbConnection(Con);
                dbconn.Open();//建立连接
                OleDbDataAdapter inst = new OleDbDataAdapter("SELECT *FROM Files", dbconn);//选择全部内容
                DataSet ds = new DataSet();//临时存储
                inst.Fill(ds);//用inst填充ds
                dataGridView1.DataSource = ds.Tables[0];//展示ds第一张表到dataGridView1控件
                dbconn.Close();//关闭连接  
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (is_loaded_database)
            {
                Process.Start("C:\\Windows\\explorer.exe",Azylee.Core.IOUtils.DirUtils.DirTool.GetFilePath(mdbPath));
            }
        }
    }
}
