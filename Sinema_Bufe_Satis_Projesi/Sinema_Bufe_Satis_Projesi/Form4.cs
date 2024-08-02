using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Projesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3;
            double ortalama;

            sinav1 = Convert.ToInt16(textBox1.Text);
            sinav2 = Convert.ToInt16(textBox2.Text);
            sinav3 = Convert.ToInt16(textBox3.Text);

            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            lblOrtalama.Text = ortalama.ToString();
        }
    }
}
