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
    public partial class Frm13_Paint : Form
    {
        public Frm13_Paint()
        {
            InitializeComponent();
            g = panelDraw.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;

        private void Frm13_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panelDraw.Cursor = Cursors.Cross;
        }

        private void Frm13_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving = true && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panelDraw.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox Pic = (PictureBox)sender;
            pen.Color = button1.BackColor;
        }
    }
}
