using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker
{
    public partial class InitForm : Form
    {
        bool is_Verified = false;
        bool is_btnVerified_1 = false;
        bool is_btnVerified_2 = false;
        bool is_btnVerified_3 = false;
        bool is_btnVerified_4 = false;

        int VerifyIndex = 1;

        public InitForm()
        {
            InitializeComponent();
        }
        private void InitForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(is_Verified)
            {
                MainForm frm = new MainForm();
                frm.ShowDialog();
                Close();
            }
            else
            {

                switch (Permission.VerifyPermissionFile(textBox6.Text))
                {

                    /// -1:文件不存在
                    /// -2:未知错误
                    /// -3:参数个数溢出
                    /// -255:验证失败
                    /// 0:验证成功
                    case 0:
                        is_Verified = true;
                        button8.Text = "✔";
                        button8.BackColor = Color.Green;
                        break;
                    case -1:
                        is_Verified = false;
                        button8.Text = "❌";
                        button8.BackColor = Color.Red;
                        MessageBox.Show("验证无效：文件不存在", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Close();
                        break;
                    case -2:
                        is_Verified = false;
                        button8.Text = "❌";
                        button8.BackColor = Color.Red;
                        MessageBox.Show("验证无效", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Close();
                        break;
                    case -3:
                        is_Verified = false;
                        button8.Text = "❌";
                        button8.BackColor = Color.Red;
                        MessageBox.Show("验证无效：伪造的文件", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Close();
                        break;
                    case -255:
                        is_Verified = false;
                        button8.Text = "❌";
                        button8.BackColor = Color.Red;
                        MessageBox.Show("验证无效", "错误", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Close();
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestorePermissionForm frm = new RestorePermissionForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "授权文件(Permission.cGVy)|*Permission.cGVy";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != "")
                {
                    this.textBox6.Text = fileDialog.FileName;
                    button8.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == true &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == true &&
                checkBox9.Checked == false &&
                checkBox10.Checked == true &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == true &&
                is_btnVerified_1 == true &&
                is_btnVerified_2 == true &&
                is_btnVerified_3 == true &&
                is_btnVerified_4 == true &&
                VerifyIndex == 5
                )
            {

                is_Verified = true;
                button8.Text = "✔";
                button8.BackColor = Color.Green;
                button8.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == true &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == false &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false
                )
            {
                is_btnVerified_1 = true;
                VerifyIndex = VerifyIndex + 1;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == true &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == true &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false
                )
            {
                is_btnVerified_2 = true;
                VerifyIndex = VerifyIndex + 1;
            }
            else
            {

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == true &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == true &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false
                )
            {
                is_btnVerified_3 = true;
                VerifyIndex = VerifyIndex + 1;
            }
            else
            {

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == true &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == true &&
                checkBox9.Checked == false &&
                checkBox10.Checked == true &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false
                )
            {
                is_btnVerified_4 = true;
                VerifyIndex = VerifyIndex + 1;
            }
            else
            {

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            is_btnVerified_1 = false;
            is_btnVerified_2 = false;
            is_btnVerified_3 = false;
            is_btnVerified_4 = false;
            VerifyIndex = 1;
        }
    }
}
