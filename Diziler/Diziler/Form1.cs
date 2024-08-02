using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Ayşe", "Demet" };
            //label1.Text = kisiler[7];

            //int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = sayilar[5].ToString();

            //double[] ondalikliSayilar = { 4.5, 7.3, 5.7, 6.9, 9.2, 8.4, 2.1, 3.3 };
            //label1.Text = ondalikliSayilar[5].ToString();

            char[] harfler = { 'a', 'b', 'c' , 'd', 'e', 'f' };
            label1.Text = harfler[5].ToString();
        }
    }
}
