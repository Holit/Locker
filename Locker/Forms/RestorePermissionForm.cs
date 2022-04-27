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
    public partial class RestorePermissionForm : Form
    {
        bool clickable_28 = true;
        bool clickable_61 = true;
        bool clickable_23 = true;
        bool clickable_1 = true;

        int correct_attempt = 0;
        public RestorePermissionForm()
        {
            InitializeComponent();
        }

        private void RestorePermissionForm_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
            button2.BackColor = Color.AntiqueWhite;
            button3.BackColor = Color.Aqua;
            button4.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Azure;
            button6.BackColor = Color.Beige;
            button7.BackColor = Color.Bisque;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.BlanchedAlmond;
            button10.BackColor = Color.Blue;
            button11.BackColor = Color.BlueViolet;
            button12.BackColor = Color.Brown;
            button13.BackColor = Color.BurlyWood;
            button14.BackColor = Color.CadetBlue;
            button15.BackColor = Color.Chartreuse;
            button16.BackColor = Color.Chocolate;
            button17.BackColor = Color.Coral;
            button18.BackColor = Color.CornflowerBlue;
            button19.BackColor = Color.Cornsilk;
            button20.BackColor = Color.Crimson;
            button21.BackColor = Color.Cyan;
            button22.BackColor = Color.DarkBlue;
            button23.BackColor = Color.DarkCyan;
            button24.BackColor = Color.DarkGoldenrod;
            button25.BackColor = Color.DarkGray;
            button26.BackColor = Color.DarkGreen;
            button27.BackColor = Color.DarkKhaki;
            button28.BackColor = Color.DarkMagenta;
            button29.BackColor = Color.DarkOliveGreen;
            button30.BackColor = Color.DarkOrange;
            button31.BackColor = Color.DarkOrchid;
            button32.BackColor = Color.DarkRed;
            button33.BackColor = Color.DarkSalmon;
            button34.BackColor = Color.DarkSeaGreen;
            button35.BackColor = Color.DarkSlateBlue;
            button36.BackColor = Color.DarkSlateGray;
            button37.BackColor = Color.DarkTurquoise;
            button38.BackColor = Color.DarkViolet;
            button39.BackColor = Color.DeepPink;
            button40.BackColor = Color.DeepSkyBlue;
            button41.BackColor = Color.DimGray;
            button42.BackColor = Color.DodgerBlue;
            button43.BackColor = Color.Firebrick;
            button44.BackColor = Color.FloralWhite;
            button45.BackColor = Color.ForestGreen;
            button46.BackColor = Color.Fuchsia;
            button47.BackColor = Color.Gainsboro;
            button48.BackColor = Color.GhostWhite;
            button49.BackColor = Color.Gold;
            button50.BackColor = Color.Goldenrod;
            button51.BackColor = Color.Gray;
            button52.BackColor = Color.Green;
            button53.BackColor = Color.GreenYellow;
            button54.BackColor = Color.Honeydew;
            button55.BackColor = Color.HotPink;
            button56.BackColor = Color.IndianRed;
            button57.BackColor = Color.Indigo;
            button58.BackColor = Color.Ivory;
            button59.BackColor = Color.Khaki;
            button60.BackColor = Color.Lavender;
            button61.BackColor = Color.LavenderBlush;
            button62.BackColor = Color.LawnGreen;
            button63.BackColor = Color.LemonChiffon;
            button64.BackColor = Color.LightBlue;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if(clickable_28 == true)
            {
                correct_attempt = correct_attempt + 1;
                clickable_28 = false;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (clickable_61 == true)
            {
                correct_attempt = correct_attempt + 1;
                clickable_61 = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (clickable_23 == true)
            {
                correct_attempt = correct_attempt + 1;
                clickable_23 = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickable_1 == true)
            {
                correct_attempt = correct_attempt + 1;
                clickable_1 = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if(correct_attempt == 4)
            {
                switch(Permission.CreatePermissionFile(System.IO.Directory.GetCurrentDirectory() + "\\Permission.cGVy"))
                {
                    /// -1:文件已存在
                    /// -2:未知错误
                    /// 0:创建成功
                    case -1:
                        {
                            MessageBox.Show(this, "重建失败：文件已存在", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                    case -2:
                        {
                            MessageBox.Show(this, "重建失败：未知错误", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                    case 0:
                        {
                            MessageBox.Show(this, "创建成功 ("+ System.IO.Directory.GetCurrentDirectory() + "\\Permission.cGVy \n路径已复制到剪贴板" + ")", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Clipboard.SetDataObject(System.IO.Directory.GetCurrentDirectory() + "\\Permission.cGVy");

                            break;
                        }
                }
                this.Close();
            }
        }
    }
}
