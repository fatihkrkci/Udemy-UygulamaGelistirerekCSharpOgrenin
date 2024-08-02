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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int kupHesapla(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);

            label1.Text = kupHesapla(sayi).ToString();
        }
    }
}
