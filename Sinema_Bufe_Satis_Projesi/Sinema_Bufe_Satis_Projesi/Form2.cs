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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, cevre;
            double alan;

            kisakenar = Convert.ToInt16(txtKisaKenar.Text);
            uzunkenar = Convert.ToInt16(txtUzunKenar.Text);

            cevre = (2 * kisakenar) + (2 * uzunkenar);
            alan = kisakenar * uzunkenar;

            lblAlan.Text = alan.ToString();
            lblCevre.Text = cevre.ToString();
        }
    }
}
