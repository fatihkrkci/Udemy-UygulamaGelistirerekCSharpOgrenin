﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString();   //Mutlak
            //label2.Text = Math.Ceiling(sayi).ToString();   //Üste Yuvarlama
            //label2.Text = Math.Floor(sayi).ToString();   //Alta Yuvarlama
            //label2.Text = Math.Pow(sayi, 3).ToString();   //Üs
            //label2.Text = Math.Sqrt(sayi).ToString();   //Karekök
            //label2.Text = Math.PI.ToString();   //Pi Sayısı
            label2.Text = Math.Cos(sayi).ToString();   //Kosinüs Alma
        }
    }
}
