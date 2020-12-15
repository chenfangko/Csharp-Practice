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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn01_Hello_Click(object sender, EventArgs e)
        {
            Frm01_Hello popup = new Frm01_Hello();
            popup.Show();
        }

        private void btn02_Loan_Click(object sender, EventArgs e)
        {
            Frm02_Loan popup = new Frm02_Loan();
            popup.Show();
        }

        private void btn_03POS_Click(object sender, EventArgs e)
        {
            Frm03_Menu popup = new Frm03_Menu();
            popup.Show();
        }

        private void btn_04Student_Click(object sender, EventArgs e)
        {
            Frm04_Student popup = new Frm04_Student();
            popup.Show();
        }

        private void Btn_05StudentGrade(object sender, EventArgs e)
        {
            Frm05_Student_Grade popup = new Frm05_Student_Grade();
            popup.Show();
        }

        private void btn_08Calc_Click(object sender, EventArgs e)
        {
            Frm08_Calculation popup = new Frm08_Calculation();
            popup.Show();
        }

        private void btn_09ForDoWhile_Click(object sender, EventArgs e)
        {
            Frm09_For_Dor_While popup = new Frm09_For_Dor_While();
            popup.Show();
        }
        private void btn_10XO_Click(object sender, EventArgs e)
        {
            Frm10_XoGame popup = new Frm10_XoGame();
            popup.Show();
        }

        private void btn_13Paint_Click(object sender, EventArgs e)
        {
            Frm13_Paint popup = new Frm13_Paint();
            popup.Show();
        }

        private void btn_15Guess_Click(object sender, EventArgs e)
        {
            Frm15_Guess popup = new Frm15_Guess();
            popup.Show();
        }

        
    }
}
