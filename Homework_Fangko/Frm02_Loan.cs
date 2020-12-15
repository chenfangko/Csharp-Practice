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
    public partial class Frm02_Loan : Form
    {
        public Frm02_Loan()
        {
            InitializeComponent();
        }

        int loan = 0;
        float mInterest = 0f;
        int period;
        float mLoop = 1f;
        float totalPay = 1f;
        float mPay = 0f;
        int Convert;
        void cal()
        {
            mInterest = float.Parse(txtYearInterest.Text) / 100 / 12;
            period = int.Parse(txtPeriodMonth.Text);
            loan = int.Parse(txtLoan.Text);
            //算出mLoop
            //mLoop = 1 + mInterest;
            mLoop = 1;
            for (int i = 0; i < period; i++)
            {
                mLoop = (1 + mInterest)* mLoop;
            }
            //月付額
            mPay = loan * (mInterest * mLoop) / (mLoop - 1);
            //總額
            totalPay = mPay * period;

            //Convert = Convert
        }



        private void btnMothPay_Click(object sender, EventArgs e)
        {
            cal();
            MessageBox.Show("月付額：" + mPay);
        }

        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            cal();
            MessageBox.Show("總付額：" + totalPay);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            cal();
            MessageBox.Show($"貸款金額：{loan}\n年利率：{txtYearInterest.Text}" +
                $"\n貸款期數：{txtPeriodMonth.Text}\n月付額：{totalPay / period}\n總付額：{totalPay}\n利息總額：{totalPay - loan}", "貸款報告書");
        }
    }
}
