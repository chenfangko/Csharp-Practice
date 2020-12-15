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
    public partial class Frm08_Calculation : Form
    {
        public Frm08_Calculation()
        {
            InitializeComponent();
        }

        int n1;
        int n2;

        void CheckNums()
        {
            bool isNum = false;
            
            isNum = int.TryParse(txtN1.Text, out n1);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtN1.Clear();
                txtAns.Clear();
                txtN1.Focus();
                return;
            }

            isNum = int.TryParse(txtN2.Text, out n2);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtN2.Clear();
                txtAns.Clear();
                txtN2.Focus();
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckNums();
            int Add;
            Add = n1 + n2;
            txtAns.Text = Add.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CheckNums();
            int Minus;
            Minus = n1 - n2;
            txtAns.Text = Minus.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            CheckNums();
            int Times;
            Times = n1 * n2;
            txtAns.Text = Times.ToString();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            CheckNums();
            if (int.Parse(txtN2.Text) == 0)
            {
                MessageBox.Show("除數不可為0");
                return;
            }
            int Times;
            Times = n1 / n2;
            txtAns.Text = Times.ToString();
        }
    }
}
