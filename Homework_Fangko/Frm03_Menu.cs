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
    public partial class Frm03_Menu : Form
    {
        public Frm03_Menu()
        {
            InitializeComponent();
        }

        protected void MakeList()
        {
            labList.Text = "";
            labList.Text += ListBeer + ListWhisky + ListGin + ListWine;
        }

        int TotalPrice = 0;

        int countBeer = 0;
        string ListBeer;
        private void btnBeer_Click(object sender, EventArgs e)
        {
            clsMenu B = new clsMenu()
            {
                MenuName = "啤酒 Beer",
                MenuPrice = 120
            };
            countBeer++;
            TotalPrice += B.MenuPrice * countBeer;
            labTotal.Text = $"NT$ {TotalPrice}";
            ListBeer = $"{B.MenuName}*{countBeer}，NT${B.MenuPrice * countBeer}\n";
            MakeList();
        }

        int countWhisky = 0;
        string ListWhisky;
        private void btnWhisky_Click(object sender, EventArgs e)
        {
            clsMenu Wh = new clsMenu()
            {
                MenuName = "威士忌 Whisky",
                MenuPrice = 250
            };
            countWhisky++;
            TotalPrice += Wh.MenuPrice * countWhisky;
            labTotal.Text = $"NT$ {TotalPrice}";
            ListWhisky = $"{Wh.MenuName}*{countWhisky}，NT${Wh.MenuPrice * countWhisky}\n";
            MakeList();
        }

        int countGin = 0;
        string ListGin;
        private void btnGin_Click(object sender, EventArgs e)
        {
            clsMenu G = new clsMenu()
            {
                MenuName = "琴酒 Gin",
                MenuPrice = 220
            };
            countGin++;
            TotalPrice += G.MenuPrice * countGin;
            labTotal.Text = $"NT$ {TotalPrice}";
            ListGin = $"{G.MenuName}*{countGin}，NT${G.MenuPrice * countGin}\n";
            MakeList();
        }

        int countWine = 0;
        string ListWine;
        private void btnWine_Click(object sender, EventArgs e)
        {
            clsMenu W = new clsMenu()
            {
                MenuName = "紅酒 Wine",
                MenuPrice = 180
            };
            countWine++;
            TotalPrice += W.MenuPrice * countWine;
            labTotal.Text = $"NT$ {TotalPrice}";
            ListWine = $"{W.MenuName}*{countWine}，NT${W.MenuPrice * countWine}\n";
            MakeList();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額：NT$ {TotalPrice}", "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額：NT$ {TotalPrice}\n折扣價：NT$ {TotalPrice * 0.8}", "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            TotalPrice = 0;
            countBeer = 0;
            countWhisky = 0;
            countGin = 0;
            countWine = 0;
            ListBeer = "";
            ListWhisky = "";
            ListGin = "";
            ListWine = "";
            labTotal.Text = $"NT$ {TotalPrice}";
            labList.Text = "尚未點餐";
        }
    }
}
