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
    public partial class Frm03_POS : Form
    {
        public Frm03_POS()
        {
            InitializeComponent();
        }

        

        private void btnBeer_Click(object sender, EventArgs e)
        {
            int countBeer = 0;
            clsMenu Beer = new clsMenu()
            {
                MenuName = "啤酒 Beer",
                MenuPrice = 120
            };
            countBeer++;
            labTotal.Text += $"NT$ {Beer.MenuPrice.ToString()}";
            labList.Text += $"{Beer.MenuName}*{countBeer}，共{Beer.MenuPrice}元";


        }

        //clsMember Marry = new clsMember()
        //{
        //    Name = "Marry",
        //    Age = 25
        //};
    }
}
