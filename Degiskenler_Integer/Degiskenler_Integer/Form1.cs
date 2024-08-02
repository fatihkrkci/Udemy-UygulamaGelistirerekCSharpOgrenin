using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, alan, cevre;

            kisakenar = 10;
            uzunkenar = 20;

            alan = kisakenar * uzunkenar;
            cevre = (2 * kisakenar) + (2 * uzunkenar);

            label1.Text = "Alan: " + alan + "   Çevre: " + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ortalama;

            not1 = 90;
            not2 = 58;
            not3 = 57;

            ortalama = (not1 + not2 + not3) / 3;

            label2.Text = "Öğrencinin ortalaması: " + ortalama;
        }
    }
}
