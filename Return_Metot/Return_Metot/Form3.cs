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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int topla(int sayi1, int sayi2)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            int sonuc = sayi1 + sayi2;

            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            label1.Text = topla(sayi1, sayi2).ToString();
        }
    }
}
