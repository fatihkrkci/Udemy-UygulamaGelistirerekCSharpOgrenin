using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BonusOkul
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True;TrustServerCertificate=True");
        public string numara;
        public string ogrenciAdSoyad;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd, Sinav1, Sinav2, Sinav3, Proje, Ortalama, Durum From Tbl_Notlar INNER JOIN Tbl_Dersler on Tbl_Notlar.DersID=Tbl_Dersler.DersID Where OgrenciID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Öğrenci Ad Soyadını Çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OgrenciAd, OgrenciSoyad From Tbl_Ogrenciler Where OgrenciID=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p2", numara);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                ogrenciAdSoyad = dr[0].ToString() + " " + dr[1].ToString();
                this.Text = ogrenciAdSoyad + " - Notlar Ekranı";
            }
            baglanti.Close();
        }
    }
}
