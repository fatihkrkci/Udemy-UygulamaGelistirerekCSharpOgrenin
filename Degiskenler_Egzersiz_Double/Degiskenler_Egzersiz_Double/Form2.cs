using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Egzersiz_Double
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunadi;
            double urunfiyati, kdv8, kdv18;

            urunadi = textBox1.Text;
            urunfiyati = Convert.ToDouble(textBox2.Text);

            kdv8 = urunfiyati * 0.08;
            kdv18 = urunfiyati * 0.18;

            listBox1.Items.Add("Ürün Adı: " + urunadi + "   Ürün Fiyatı: " + urunfiyati + "   %8 KDV: " + kdv8 + "   %18 KDV: " + kdv18);
        }
    }
}
