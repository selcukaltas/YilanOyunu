using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class SkorlarForm : MetroForm
    {
        public SkorlarForm()
        {
            InitializeComponent();
            SkorlariOku();
            //ListViewItem lvi = new ListViewItem("1");
            //lvi.SubItems.Add("Selçuk");
            //lvi.SubItems.Add("999");
            //lvwSkorlar.Items.Add(lvi);
        }

        private void SkorlariOku()
        {
            try
            {
                string[] satirlar = File.ReadAllLines("skorlar.txt");
                var sira = 1;
                foreach (var satir in satirlar)
                {
                    string[] hucreler = satir.Split(';');
                    string puan = hucreler[0];
                    DateTime tarih = DateTime.Parse(hucreler[1]);
                    string ad = hucreler[2];
                    SkorTablosunaEkle(sira, ad, puan, tarih);
                    sira++;
                }
            }
            catch (Exception)
            {

                
            }

        }

        private void SkorTablosunaEkle(int sira, string ad, string puan, DateTime zaman)
        {
            ListViewItem lvi = new ListViewItem(sira + ". " + ad);
            lvi.SubItems.Add(puan);
            lvi.SubItems.Add(zaman.ToString("s"));
            lvwSkorlar.Items.Add(lvi);
        }
    }
}
