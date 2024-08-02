using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Switch_Case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            char isaret;
            double sonuc;

            sayi1 = Convert.ToInt16(txtSayi1.Text);
            sayi2 = Convert.ToInt16(txtSayi2.Text);
            isaret = Convert.ToChar(txtIsaret.Text);

            switch (isaret)
            {
                case '+': sonuc = sayi1 + sayi2; txtSonuc.Text = sonuc.ToString(); break;
                case '-': sonuc = sayi1 - sayi2; txtSonuc.Text = sonuc.ToString(); break;
                case '*': sonuc = sayi1 * sayi2; txtSonuc.Text = sonuc.ToString(); break;
                case '/': sonuc = sayi1 / sayi2; txtSonuc.Text = sonuc.ToString(); break;
                default: txtSonuc.Text = "Hatalı İşaret"; break;
            }
        }
    }
}
