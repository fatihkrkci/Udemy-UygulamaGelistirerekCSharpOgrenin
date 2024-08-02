using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUrun
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamKategoriSayisi.Text = db.Tbl_Kategori.Count().ToString();
            lblToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lblAktifMusteriSayisi.Text = db.Tbl_Musteri.Count(x => x.Durum == true).ToString();
            lblPasifMusteriSayisi.Text = db.Tbl_Musteri.Count(x => x.Durum == false).ToString();
            lblBeyazEsyaSayisi.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString();
            lblToplamStok.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            lblEnYuksekFiyatliUrun.Text = (from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            lblSehirSayisi.Text = (from x in db.Tbl_Musteri select x.Sehir).Distinct().Count().ToString();
            lblKasadakiTutar.Text = db.Tbl_Satis.Sum(x => x.Fiyat) + "₺";
            lblEnFazlaOlanMarka.Text = db.MARKAGETIR().FirstOrDefault();
            lblToplamBuzdolabiSayisi.Text = db.Tbl_Urun.Count(x => x.UrunAd == "Buzdolabı").ToString();
        }
    }
}
