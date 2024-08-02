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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yaricap;
            double pi = 3.14, alan, cevre;

            yaricap = Convert.ToInt16(textBox1.Text);

            alan = pi * (yaricap * yaricap);
            cevre = 2 * pi * yaricap;

            lblAlan.Text = alan.ToString();
            lblCevre.Text = cevre.ToString();
        }
    }
}
