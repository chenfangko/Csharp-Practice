using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Fangko
{
    class clsUtility
    {
        
    }


    internal class clsMenu
    {
        internal string MenuName;
        internal int MenuPrice;
    }

    internal struct stcGrade
    {
        internal string strName;
        internal float flChinese;
        internal float flEnglish;
        internal float flMath;
        internal float flTotal;
        internal float flAverage;
        internal string strHighest;
        internal string strLowest;

        internal stcGrade(string name, float chinese, float english, float math)
        {
            strName = name;
            flChinese = chinese;
            flEnglish = english;
            flMath = math;
            flTotal = chinese + english + math;
            flAverage = flTotal / 3;

            float[] arrGrade = { chinese, english, math };
            float HighestGrade = 0;
            float LowestGrade = 0;
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

            strHighest = HighestGrade.ToString();
            strLowest = LowestGrade.ToString();

        }
    }


}
