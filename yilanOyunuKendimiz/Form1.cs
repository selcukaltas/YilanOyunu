using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yilanOyunuKendimiz
{
    public partial class Form1 : Form
    {
        int satırSayısı = 20;
        int sutunSayısı = 20;
        int bogumSayısı;
        List<Point> yilan;
        Point bas;
        int xYon = 1, yYon = 0;
        bool yonDegisti = false;
        Point yem;

        public Form1()
        {
            InitializeComponent();
            bogumSayısı = pnlTahta.Height / satırSayısı;
            YılanUret();
            YemUret();
        }
        Random rnd = new Random();

        private void YemUret() // SOR
        {
            int x, y;
            do
            {
                x = rnd.Next(0, sutunSayısı);
                y = rnd.Next(0, satırSayısı);

            } while (yilaninUzerindeMi(x, y));
            yem = new Point(x, y);


        }

        private bool yilaninUzerindeMi(int x, int y)// SOR
        {
            foreach (Point nokta in yilan)
            {
                if (nokta.X == x && nokta.Y == y)
                {
                    return true;
                }
            }
            return false;

        }




        private void YılanUret()
        {
            bas = new Point(sutunSayısı / 2, satırSayısı / 2);
            yilan = new List<Point>
            {
                bas,
                new Point(sutunSayısı/2-1,satırSayısı/2),
                new Point(sutunSayısı/2-2,satırSayısı/2)
            };

        }

        private void pnlTahta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            YilanCiz(g);
            YemCiz(g);

        }

        private void YemCiz(Graphics g)
        {
            int x = yem.X * bogumSayısı;
            int y = yem.Y * bogumSayısı;
            g.FillRectangle(Brushes.Red, x, y, bogumSayısı, bogumSayısı);
            g.DrawRectangle(Pens.Black, x, y, bogumSayısı - 1, bogumSayısı - 1);
            //g.FillRectangle()


        }

        private void YilanCiz(Graphics g)
        {
            g.FillRectangle(Brushes.Red, yilan[0].X * bogumSayısı, yilan[0].Y * bogumSayısı, bogumSayısı, bogumSayısı);
            g.DrawRectangle(Pens.Black, yilan[0].X * bogumSayısı, yilan[0].Y * bogumSayısı, bogumSayısı - 1, bogumSayısı - 1);
            for (int i = 1; i < yilan.Count; i++)
            {
                g.FillRectangle(Brushes.Gray, yilan[i].X * bogumSayısı, yilan[i].Y * bogumSayısı, bogumSayısı, bogumSayısı);
                g.DrawRectangle(Pens.Black, yilan[i].X * bogumSayısı, yilan[i].Y * bogumSayısı, bogumSayısı - 1, bogumSayısı - 1);

            }


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)  //SORULACAK
        {
            int xYeniYon = 0;
            int yYeniYon = 0;

            if (keyData == Keys.F2 && timer1.Enabled == true)
            {
                lblOyunBitti.Show();
                timer1.Enabled = false;
                return base.ProcessCmdKey(ref msg, keyData);

            }

            if (keyData == Keys.F2 && timer1.Enabled == false)
            {
                lblOyunBitti.Hide();
                lblAciklama.Hide();
                timer1.Enabled = true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
            if (yonDegisti || !timer1.Enabled)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Up:
                    xYeniYon = 0; yYeniYon = -1;
                    break;
                case Keys.Down:
                    xYeniYon = 0; yYeniYon = 1;
                    break;
                case Keys.Right:
                    xYeniYon = 1; yYeniYon = 0;
                    break;
                case Keys.Left:
                    xYeniYon = -1; yYeniYon = 0;
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);

            }

            if (xYon * xYeniYon != -1 && yYon * yYeniYon != -1)
            {
                xYon = xYeniYon;
                yYon = yYeniYon;
                yonDegisti = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            bas = yilan[0];
            Point yeniBas = new Point(bas.X +  xYon, bas.Y + yYon);
            if (yilaninUzerindeMi(yeniBas.X, yeniBas.Y) || yeniBas.X < 0 || yeniBas.X >= sutunSayısı
                || yeniBas.Y < 0 || yeniBas.Y >= satırSayısı)
            {
                timer1.Stop();
                return;
            }



            yilan.Insert(0, yeniBas);
            if (yeniBas == yem)
            {
                YemUret();
                if (timer1.Interval > 50) ;
                timer1.Interval -= 10;

            }
            else
            {
                yilan.RemoveAt(yilan.Count - 1);
            }



            //yilan.RemoveAt(yilan.Count - 1);


            pnlTahta.Refresh();
            yonDegisti = false;

        }
    }
}
