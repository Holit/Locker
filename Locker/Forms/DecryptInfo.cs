using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker.Forms
{
    public partial class DecryptInfo : Form
    {
        public Attributes properties;
        string dstPath = "";
        public DecryptInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\explorer.exe", textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox5.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox6.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Clipboard.SetDataObject(textBox7.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadText(Attributes attributes, string dstPath)
        {
            this.properties = attributes;
            this.dstPath = dstPath;

        }
        private void DecryptInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = properties.GetName();
            textBox2.Text = properties.GetFriendlyName();
            textBox3.Text = properties.GetSize().ToString();
            textBox4.Text = properties.GetSrcType();
            textBox5.Text = properties.GetLocation();
            textBox6.Text = dstPath;
            textBox7.Text = properties.GetDescription();
        }
    }
}
