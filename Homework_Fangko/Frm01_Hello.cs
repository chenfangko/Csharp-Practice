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
    public partial class Frm01_Hello : Form
    {
        public Frm01_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            int age;
            bool isNum = int.TryParse(txtAge.Text, out age);
            if (isNum == false)
            {
                MessageBox.Show("Age: Please type in NUMBER");
                txtAge.Clear();
                txtAge.Focus();
                return;
            }

            string chinName = txtChinName.Text;
            string engName = txtEngName.Text;
            string gen = txtGen.Text;
            MessageBox.Show("Hello, My chinese name is " + chinName 
                + "\nMy English name is " + engName 
                + "\nI'm " + age + "years old\nMy Gender is " + gen
                + "\nNice to meet you!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave me alone.");
        }
    }
}
