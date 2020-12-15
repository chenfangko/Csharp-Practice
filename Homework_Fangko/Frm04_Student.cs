using System;
using System.Collections;
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
    public partial class Frm04_Student : Form
    {
        public Frm04_Student()
        {
            InitializeComponent();
        }

        int chinese;
        int english;
        int math;





        private void btnSave_Click(object sender, EventArgs e)
        {
            
            bool ChinIsNum = int.TryParse(txtChin.Text, out chinese);
            if(ChinIsNum == false)
            {
                txtChin.Clear();
                txtChin.Focus();
            }

            bool EngIsNum = int.TryParse(txtEng.Text, out english);
            if (EngIsNum == false)
            {
                txtEng.Clear();
                txtEng.Focus();
            }

            bool MathIsNum = int.TryParse(txtMath.Text, out math);
            if (MathIsNum == false)
            {
                txtMath.Clear();
                txtMath.Focus();
            }

            labGrade.Text = $"姓名：{txtName.Text}\n國文：{chinese}\n英文：{english}\n數學：{math}";

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            labGrade.Text = "";
            labEst.Text = "";
        }

        private void btnShowEst_Click(object sender, EventArgs e)
        {
            int[] arrGrade = { chinese, english, math };

            //Find Highest & Lowest
            int HighestGrade = 0;
            int LowestGrade = 0;
            for (int i = 0; i < arrGrade.Length; i++)
            {
                HighestGrade = arrGrade[0];
                if (arrGrade[i] > HighestGrade)
                {
                    HighestGrade = arrGrade[i];
                }
            }
            for (int i = 0; i < arrGrade.Length; i++)
            {
                LowestGrade = arrGrade[0];
                if (arrGrade[i] < LowestGrade)
                {
                    LowestGrade = arrGrade[i];
                }
            }

            //Print all 
            Dictionary<string, int> dicGrade = new Dictionary<string, int>()
            {
                {"國文", chinese },
                {"英文", english },
                {"數學", math }

            };
            string printHighest = "";
            foreach(var grade in dicGrade)
            {
                if(grade.Value == HighestGrade)
                {
                    printHighest += grade.Key + " ";
                }
            }
            string printLowest = "";
            foreach (var grade in dicGrade)
            {
                if (grade.Value == LowestGrade)
                {
                    printLowest += grade.Key + " ";
                }
            }
            labEst.Text = $"最高分科目：{printHighest}，分數：{HighestGrade}分\n最低分科目：{printLowest}，分數：{LowestGrade}分";


        }
    }
}
