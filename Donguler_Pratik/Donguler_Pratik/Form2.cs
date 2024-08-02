using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Pratik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 1, sayi = Convert.ToInt16(textBox1.Text);

            for (int i = 2; i <= sayi; i++)
            {
                toplam = toplam * i;
            }

            label3.Text = toplam.ToString();
        }
    }
}
