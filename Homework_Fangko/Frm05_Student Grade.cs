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
    public partial class Frm05_Student_Grade : Form
    {
        public Frm05_Student_Grade()
        {
            InitializeComponent();
        }
        char pad = ' ';
        List<stcGrade> lsGrades = new List<stcGrade>();

        
        void ShowListBox()
        {
            //labShowGrade.Text = "";
            //foreach (var item in lsGrades)
            //{
            //    labShowGrade.Text += $"\r\n{.PadRight(4, pad)}{chin.ToString().PadLeft(6, pad)}" +
            //    $"{eng.ToString().PadLeft(6, pad)}{ma.ToString().PadLeft(6, pad)}" +
            //    $"{flTotal.ToString().PadLeft(7, pad)}{flAverage.ToString().PadLeft(10, pad)}" +
            //    $"{HighestGrade.ToString().PadLeft(7, pad)}{LowestGrade.ToString().PadLeft(7, pad)}";
            //}
            labShowGrade.Text += $"\r\n{txtName.Text.PadRight(8,pad)}{chin.ToString().PadLeft(6, pad)}" +
                $"{eng.ToString().PadLeft(6, pad)}{ma.ToString().PadLeft(6, pad)}" +
                $"{flTotal.ToString().PadLeft(7,pad)}{flAverage.ToString().PadLeft(12,pad)}" +
                $"{HighestGrade.ToString().PadLeft(7,pad)}{LowestGrade.ToString().PadLeft(8,pad)}";
        }

        float chin;
        float eng;
        float ma;
        float flTotal;
        float flAverage;
        float HighestGrade = 0;
        float LowestGrade = 0;
        string HighestSub;
        string LowestSub;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float.TryParse(txtChin.Text, out chin);
            float.TryParse(txtEng.Text, out eng);
            float.TryParse(txtMath.Text, out ma);

            flTotal = chin + eng + ma;
            flAverage = flTotal / 3;
            float[] arrGrade = { chin, eng, ma };
            for (int i = 0; i < arrGrade.Length; i++)
            {
                HighestGrade = arrGrade[0];
                if (arrGrade[i] >= HighestGrade)
                {
                    HighestGrade = arrGrade[i];
                }
            }
            for (int i = 0; i < arrGrade.Length; i++)
            {
                LowestGrade = arrGrade[0];
                if (arrGrade[i] <= LowestGrade)
                {
                    LowestGrade = arrGrade[i];
                }
            }

            ShowListBox();
           

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ShowListBox();
        }
    }
}
