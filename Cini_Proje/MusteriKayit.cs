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

namespace Cini_Proje
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Musteriler (Adi,Soyadi,MusteriEPosta,Telefon,Adres,CinsiyetID,SehirID,MusteriTipi,MusteriTC,MusteriSifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtEPosta.Text);
            komut.Parameters.AddWithValue("@p4", txtMusteriTelefonNO.Text);
            komut.Parameters.AddWithValue("@p5", txtMusteriAdres.Text);
            komut.Parameters.AddWithValue("@p6", cmbMusteriCinsiyet.Text);
            komut.Parameters.AddWithValue("@p7", cmbMusteriSehir.Text);
            komut.Parameters.AddWithValue("@p8", cmbMusteriTipi.Text);
            komut.Parameters.AddWithValue("@p9", mskMusteriTC.Text);
            komut.Parameters.AddWithValue("@p10", txtMusteriSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void cmbMusteriCinsiyet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erkek: 1\n\nKadın: 2", "Bilgilendirme");
            if (!cmbMusteriCinsiyet.DroppedDown) cmbMusteriCinsiyet.DroppedDown = true;
        }

        private void cmbMusteriTipi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bireysel Müşteri: 1\n\nKurumsal Müşteri: 2", "Bilgilendirme");
            if (!cmbMusteriTipi.DroppedDown) cmbMusteriTipi.DroppedDown = true;
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
