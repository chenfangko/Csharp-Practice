using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Fangko
{
    public partial class Frm09_For_Dor_While : Form
    {
        public Frm09_For_Dor_While()
        {
            InitializeComponent();
        }

        //int Arr運算
        int[] Arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnSum_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            txtResult.Text = $"int陣列 Arr 加總為 {sum}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int Max = 0;
            Max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
            }
            txtResult.Text = $"int陣列 Arr 最大值為 {Max}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int Min = 0;
            Min = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                {
                    Min = Arr[i];
                }
            }
            txtResult.Text = $"int陣列 Arr 最小值為 {Min}";
        }

        private void btnCountEven_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int Even = 0;
            int Odd = 0;
            foreach (int item in Arr)
            {
                if (item % 2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }
            txtResult.Text = $"int陣列 Arr 有{Even}個偶數，{Odd}個奇數";
        }

        //陣列
        private void btnOut1_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int row;
            int column;
            string result = "";
            txtResult.Text = "";
            for(row = 0; row < 10; row++)
            {
                int i = 0;
                for (column = 0; column < 10; column++)
                {
                    if (row == 0 || row == 9 || column == 0 || column == 9)
                    {
                        i = 1;
                        result += i;
                    }
                    else
                    {
                        i = 0;
                        result += i;
                    }

                }
                result += "\r\n";
            }
            txtResult.Text += result;
        }

        private void btnOut2_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int row;
            int column;
            string result = "";
            txtResult.Text = "";
            for (row = 0; row < 10; row++)
            {
                int i = 0;
                for (column = 0; column < 10; column++)
                {
                    if (row == 0 || row == 9 || column == 0 || column == 9)
                    {
                        i = 0;
                        result += i;
                    }
                    else
                    {
                        i = 1;
                        result += i;
                    }

                }
                result += "\r\n";
            }
            txtResult.Text += result;
        }

        private void btnOut10_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Text = "";
            string square = "";
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x++;
                    int temp;
                    if(x % 2 == 1)
                    {
                        temp = x;
                        x = 1;
                        square += x;
                        x = temp;
                    }
                    else
                    {
                        temp = x;
                        x = 0;
                        square += x;
                        x = temp;
                    }   
                }
                square += "\r\n";
            }
            txtResult.Text += square;
        }

        int[] arr = new int[2] { 100, 200 };
        private void btnSwap_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            int temp;
            temp = arr[0];
            arr[0] = arr[1];
            arr[1] = temp;
            //txtResult.Text = $"原本Arr[100 , 200]\r\nSwap後Arr[{arr[0]} , {arr[1]}]";
            txtResult.Text = $"Swap：{arr[0]} , {arr[1]}";

        }

        //Question
        private void btnLotery_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            Random rdm = new Random();
            HashSet<int> setLottery = new HashSet<int>();
            while (setLottery.Count < 6)
            {
                int MinValue = 1;
                int MaxValue = 80;
                int intRdm = rdm.Next(MinValue, MaxValue);
                setLottery.Add(intRdm);
            }

            //int[] Arr = new int[5];
            //Arr = setLottery.ToArray();

            string result = "";
            foreach (var item in setLottery)
            {
                result += $"{item}|";
            }
            txtResult.Text = $"樂透號碼：{result}";
        }

        private void btnTimeList_Click(object sender, EventArgs e)
        {
            string result ="";
            for (int i = 1; i < 10; i++)
            {
                int j;
                for (j = 2; j < 10; j++)
                {
                    result += $" {j} * {i} ={string.Format("{0,3}", j * i)} |";
                }
                result += "\r\n";
            }
            txtResult.Font = new Font("細明體", 12, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Text = "九九乘法表\r\n\r\n" + result;
        }

        //str Arr運算
        private void btnCountChar_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            string[] strArr = { "John", "Eric", "Cindy", "Mandy", "Ana", "Jana", "Francesca", "Daphne", "Christina" };
            int count = 0;
            foreach (var name in strArr)
            {
                foreach (var alphabet in name)
                {
                    if (alphabet == 'a' || alphabet == 'A')
                    {
                        count += 1;
                    }
                }
            }
            txtResult.Text = $"string陣列Arr中，共有{count}個'A'或'a'";

        }

        private void btnNameWithA_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            string[] strArr = { "John", "Eric", "Cindy", "Mandy", "Ana", "Jana", "Francesca", "Daphne", "Christina" };
            int count = 0;
            foreach (var name in strArr)
            {
                int temp = 0;
                foreach (var alphabet in name)
                {
                    if (alphabet == 'a' || alphabet == 'A')
                    {
                        temp = 1;
                    }
                }
                if(temp == 1)
                {
                    count++;
                }
            }
            txtResult.Text = $"string陣列Arr中，有'A'或'a'的名字共有{count}個";
        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            string[] strArr = { "John", "Eric", "Cindy", "Mandy", "Ana", "Jana", "Francesca", "Daphne", "Christina" };
            string longestName = strArr[0];
            int longest = 0;
            foreach (var name in strArr)
            {
                if(name.ToString().Length > longest)
                {
                    longest = name.ToString().Length;
                    longestName = name;
                }
            }
            txtResult.Text = $"string陣列Arr中，最長的名字是：{longestName}，有{longest}字元";
        }


        //Type in
        int Num;
        void CheckNum()
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            bool isNum = false;
            isNum = int.TryParse(txtNum.Text, out Num);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
        }

        private void btnCheckEven_Click(object sender, EventArgs e)
        {          
            CheckNum();
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            if (Num % 2 == 0)
            {
                txtResult.Text = $"{Num}是偶數";
            }
            else
            {
                txtResult.Text = $"{Num}是奇數";
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            CheckNum();
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            string result = Convert.ToString(Num, 2);
            txtResult.Text = $"{Num}的二進位是：{result}";

        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            CheckNum();
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            string strTree = "";
            for(int i = 1; i < Num+1; i++)
            {
                int j = i;
                for (j = 0; j < i; j++)
                {
                    strTree += "*";
                }
                strTree += "\r\n";
            }
            txtResult.Text = strTree; 
        }


        int n1;
        int n2;
        int n3;
        void CheckNums()
        {
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            bool isNum = false;

            isNum = int.TryParse(txtFrom.Text, out n1);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtFrom.Clear();
                txtFrom.Focus();
                return;
            }

            isNum = int.TryParse(txtTo.Text, out n2);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtTo.Clear();
                txtTo.Focus();
                return;
            }

            isNum = int.TryParse(txtStep.Text, out n3);
            if (isNum == false)
            {
                MessageBox.Show("請輸入數字");
                txtStep.Clear();
                txtStep.Focus();
                return;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            
            CheckNums();
            int sum = 0;
            for(int i = n1; i <= n2; i += n3)
            {
                sum += i;
            }
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Text = $"For迴圈：從{n1}，相隔{n3}，加到{n2}，總數為{sum}";
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            
            CheckNums();
            int i = n1;
            int sum = 0;
            while(i < n2)
            {
                i += n3;
                sum += i;
            }
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Text = $"While迴圈：從{n1}，相隔{n3}，加到{n2}，總數為{sum}";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            
            CheckNums();
            int i = n1;
            int sum = 0;
            do
            {
                i += n3;
                sum += i;
            } while (i < n2);
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Text = $"Do迴圈：從{n1}，相隔{n3}，加到{n2}，總數為{sum}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num;
            int n1;
            int n2;
            int n3;
            txtNum.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            txtStep.Clear();
            txtResult.Text = "Result";
            txtResult.Font = new Font("微軟正黑體", 12, FontStyle.Bold, GraphicsUnit.Point);
        }
    }
}
