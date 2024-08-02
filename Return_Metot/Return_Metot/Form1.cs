using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        int carp(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = sayi1 * sayi2 * sayi3;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = topla(4, 6).ToString();
            //label2.Text = topla(2, 3).ToString();
            //label3.Text = topla(4, 8).ToString();

            //label1.Text = carp(4, 6, 2).ToString();
            //label2.Text = carp(2, 3, 5).ToString();
            //label3.Text = carp(4, 8, 1).ToString();
        }
    }
}
