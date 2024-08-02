using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, proje, sonuc;
            string durum;

            sinav1 = Convert.ToDouble(txtSinav1.Text);
            sinav2 = Convert.ToDouble(txtSinav2.Text);
            proje = Convert.ToDouble(txtProje.Text);

            sonuc = (sinav1 + sinav2 + proje) / 3;

            if (sonuc >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }

            txtSonuc.Text = sonuc.ToString("0.00") + " / " + durum;
        }
    }
}
