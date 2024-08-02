using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mesut", "Pınar", "Berna" };
            //foreach (string kisi in kisiler)
            //{
            //    listBox1.Items.Add(kisi);
            //}


            //int toplam = 0;

            //int[] sinavlar = { 70, 65, 85, 100, 90 };
            //foreach (int sinav in sinavlar)
            //{
            //    listBox1.Items.Add(sinav);
            //    toplam = toplam + sinav;
            //}
            //label1.Text = toplam.ToString();

            //int ortalama = toplam / sinavlar.Length;
            //label2.Text = ortalama.ToString();


            int toplam = 0, sayac = 0;

            int[] sayilar = { 1, 3, 17, 46, 24, 17, 81, 90, 4, 8 };
            foreach (var sayi in sayilar)
            {
                if (sayi % 4 == 0)
                {
                    listBox1.Items.Add(sayi);
                    toplam = toplam + sayi;
                    sayac++;
                }
            }

            label1.Text = "Toplam: " + toplam;
            label2.Text = "Sayı Adedi: " + sayac;
        }
    }
}
