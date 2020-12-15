using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Fangko
{
    public partial class Frm10_XoGame : Form
    {
        public Frm10_XoGame()
        {
            InitializeComponent();
        }
        string flag = "X";
        int count = 0;
        void switchFlag()
        {
            if(flag == "X")
            {
                flag = "O";
            }
            else
            {
                flag = "X";
            }
            count++;
        }
        void checkWin()
        {
            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text && btn11.Enabled != true)
            {
                MessageBox.Show($"{btn11.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text && btn21.Enabled != true)
            {
                MessageBox.Show($"{btn21.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text && btn31.Enabled != true)
            {
                MessageBox.Show($"{btn31.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Enabled != true)
            {
                MessageBox.Show($"{btn11.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Enabled != true)
            {
                MessageBox.Show($"{btn12.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && btn13.Enabled != true)
            {
                MessageBox.Show($"{btn13.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && btn11.Enabled != true)
            {
                MessageBox.Show($"{btn11.Text}玩家獲勝");
                ClearAll();
            }
            else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && btn13.Enabled != true)
            {
                MessageBox.Show($"{btn13.Text}玩家獲勝");
                ClearAll();
            }
            else if (count == 9)
            {
                MessageBox.Show($"平手");
                ClearAll();
            }
        }

        void ClearAll()
        {
            btn11.Text = "";
            btn11.Enabled = true;
            btn12.Text = "";
            btn12.Enabled = true;
            btn13.Text = "";
            btn13.Enabled = true;
            btn21.Text = "";
            btn21.Enabled = true;
            btn22.Text = "";
            btn22.Enabled = true;
            btn23.Text = "";
            btn23.Enabled = true;
            btn31.Text = "";
            btn31.Enabled = true;
            btn32.Text = "";
            btn32.Enabled = true;
            btn33.Text = "";
            btn33.Enabled = true;
            count = 0;
        }

        
        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Text = flag;
            switchFlag();
            btn11.Enabled = false;
            checkWin();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.Text = flag;
            switchFlag();
            btn12.Enabled = false;
            checkWin();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            btn13.Text = flag;
            switchFlag();
            btn13.Enabled = false;
            checkWin();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            btn21.Text = flag;
            switchFlag();
            btn21.Enabled = false;
            checkWin();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            btn22.Text = flag;
            switchFlag();
            btn22.Enabled = false;
            checkWin();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            btn23.Text = flag;
            switchFlag();
            btn23.Enabled = false;
            checkWin();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            btn31.Text = flag;
            switchFlag();
            btn31.Enabled = false;
            checkWin();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            btn32.Text = flag;
            switchFlag();
            btn32.Enabled = false;
            checkWin();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            btn33.Text = flag;
            switchFlag();
            btn33.Enabled = false;
            checkWin();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
