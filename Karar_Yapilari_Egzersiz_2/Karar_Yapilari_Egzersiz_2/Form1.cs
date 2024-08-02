using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Egzersiz_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kitapAdedi, indirimsizToplam, indirimOrani, odenecekTutar, kitapUcreti = 8;

            kitapAdedi = Convert.ToInt16(txtKitapAdedi.Text);

            if (kitapAdedi <=  20)
            {
                indirimsizToplam = kitapAdedi * kitapUcreti;
                indirimOrani = 20;
                odenecekTutar = indirimsizToplam - (indirimsizToplam * indirimOrani) / 100;

                lblIndirimsizToplam.Text = "İndirimsiz Toplam: " + indirimsizToplam.ToString() + "₺";
                lblIndirimOrani.Text = "İndirim Oranı: %" + indirimOrani.ToString();
                lblOdenecekTutar.Text = "Uygulanan İndirim Sonrası Ödenecek Tutar: " + odenecekTutar.ToString() + "₺";
            }
            else if (21 <= kitapAdedi && kitapAdedi <= 40)
            {
                indirimsizToplam = kitapAdedi * kitapUcreti;
                indirimOrani = 40;
                odenecekTutar = indirimsizToplam - (indirimsizToplam * indirimOrani) / 100;

                lblIndirimsizToplam.Text = "İndirimsiz Toplam: " + indirimsizToplam.ToString() + "₺";
                lblIndirimOrani.Text = "İndirim Oranı: %" + indirimOrani.ToString();
                lblOdenecekTutar.Text = "Uygulanan İndirim Sonrası Ödenecek Tutar: " + odenecekTutar.ToString() + "₺";
            }
            else if (41 <= kitapAdedi)
            {
                indirimsizToplam = kitapAdedi * kitapUcreti;
                indirimOrani = 50;
                odenecekTutar = indirimsizToplam - (indirimsizToplam * indirimOrani) / 100;

                lblIndirimsizToplam.Text = "İndirimsiz Toplam: " + indirimsizToplam.ToString() + "₺";
                lblIndirimOrani.Text = "İndirim Oranı: %" + indirimOrani.ToString();
                lblOdenecekTutar.Text = "Uygulanan İndirim Sonrası Ödenecek Tutar: " + odenecekTutar.ToString() + "₺";
            }

            
        }
    }
}
