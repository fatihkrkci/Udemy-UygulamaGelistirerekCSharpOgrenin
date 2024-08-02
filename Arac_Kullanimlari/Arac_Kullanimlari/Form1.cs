using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AŞKIMI ÇOK SEVİYOOOOOM İHİHİHİHİHİHHİİ KİKUKİKUKİUKKİUKİKUKUU");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Fatih";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Fatih";
            label7.Text = "Kürekçi";
            label6.Text = "Öğrenci";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım Mühendisliği";
            label9.Text = textBox1.Text;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label13.Text = textBox2.Text;
            label14.Text = textBox3.Text;
            label15.Text = textBox4.Text;
        }
    }
}
