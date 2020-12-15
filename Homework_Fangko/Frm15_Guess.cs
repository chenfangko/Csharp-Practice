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
    public partial class Frm15_Guess : Form
    {
        public Frm15_Guess()
        {
            InitializeComponent();
        }

        Random rdm = new Random();
        int Max = 99;
        int Min = 1;
        int intRdm;

        void CreateRdm()
        {
            intRdm = rdm.Next(Min, Max);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreateRdm();
            txtGuess.Enabled = true;
            btnAns.Enabled = true;
            btnGuess.Enabled = true;
            btnStart.Enabled = true;
            labHint.Text = "Hint: ";
            txtGuess.Clear();
            txtGuess.Focus();
            input = 0;
            Bigger = 100;
            Smaller = 0;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer is: " + intRdm);
        }

        int input;
        int Bigger = 100;
        int Smaller = 0;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            bool isNum = int.TryParse(txtGuess.Text, out input);
            if(isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtGuess.Clear();
                txtGuess.Focus();
            }

            if(input >= Bigger || input <= Smaller)
            {
                MessageBox.Show($"請輸入{Smaller + 1}~{Bigger - 1}的數字");
                txtGuess.Clear();
                txtGuess.Focus();
            }else if(input > intRdm)
            {
                Bigger = input;
                labHint.Text = $"Hint: Too Big!\r\nBetween {Smaller} ~ {input}";

            } else if(input < intRdm)
            {
                Smaller = input;
                labHint.Text = $"Hint: Too Small!\r\nBetween {input} ~ {Bigger}";

            } else if(input == intRdm)
            {
                labHint.Text = $"{input} is Correct!!";
                txtGuess.Enabled = false;
                btnAns.Enabled = false;
                btnGuess.Enabled = false;
                btnStart.Enabled = true;
                txtGuess.Clear();
            }
        }

        
    }
}
