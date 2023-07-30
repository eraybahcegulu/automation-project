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
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
           
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TOR5BH4;Initial Catalog=CiniDB;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Musteriler");
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteriler (Adi,Soyadi,MusteriEPosta,Telefon,Adres,CinsiyetID,SehirID,MusteriTipi,MusteriTC,MusteriSifre) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtMusteriAd.Text);
            komut.Parameters.AddWithValue("@p3", txtMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtMusteriEPosta.Text);
            komut.Parameters.AddWithValue("@p5", txtMusteriTelefonNO.Text);
            komut.Parameters.AddWithValue("@p6", txtMusteriAdres.Text);
            komut.Parameters.AddWithValue("@p7", cmbMusteriCinsiyet.Text);
            komut.Parameters.AddWithValue("@p8", cmbMusteriSehir.Text);
            komut.Parameters.AddWithValue("@p9", cmbMusteriTipi.Text);
            komut.Parameters.AddWithValue("@p10",mskMusteriTC.Text);
            komut.Parameters.AddWithValue("@p11", txtMusteriSifre.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Musteriler");
            baglanti.Close();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteriler where MusteriTC=@p10", baglanti);
            komut.Parameters.AddWithValue("@p10", mskSilinecekMusteri.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Musteriler");
            baglanti.Close();
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteriler where MusteriTC like '%" + mskAranacakMusteri.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteriler set Adi='" + txtMusteriAd.Text + "',Soyadi='" + txtMusteriSoyad.Text + "',MusteriEPosta='" + txtMusteriEPosta.Text + "',Telefon='" + txtMusteriTelefonNO.Text + "',Adres='" + txtMusteriAdres.Text + "',CinsiyetID='" + cmbMusteriCinsiyet.Text + "',SehirID='" + cmbMusteriSehir.Text + "',MusteriTipi='" + cmbMusteriTipi.Text + "',MusteriSifre='" + txtMusteriSifre.Text + "' where MusteriTC='" + mskMusteriTC.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Musteriler");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string Adi = dataGridView1.Rows[secililalan].Cells[1].Value.ToString();
            string Soyadi = dataGridView1.Rows[secililalan].Cells[2].Value.ToString();
            string MusteriEPosta = dataGridView1.Rows[secililalan].Cells[3].Value.ToString();
            string Telefon = dataGridView1.Rows[secililalan].Cells[4].Value.ToString();
            string Adres = dataGridView1.Rows[secililalan].Cells[5].Value.ToString();
            string CinsiyetID = dataGridView1.Rows[secililalan].Cells[6].Value.ToString();
            string SehirID = dataGridView1.Rows[secililalan].Cells[7].Value.ToString();
            string MusteriTipi = dataGridView1.Rows[secililalan].Cells[8].Value.ToString();
            string MusteriTC = dataGridView1.Rows[secililalan].Cells[9].Value.ToString();
            string MusteriSifre = dataGridView1.Rows[secililalan].Cells[10].Value.ToString();

            txtMusteriAd.Text = Adi;
            txtMusteriSoyad.Text = Soyadi;
            txtMusteriEPosta.Text = MusteriEPosta;
            txtMusteriTelefonNO.Text = Telefon;
            txtMusteriAdres.Text = Adres;
            cmbMusteriCinsiyet.Text = CinsiyetID;
            cmbMusteriSehir.Text = SehirID;
            cmbMusteriTipi.Text = MusteriTipi;
            mskMusteriTC.Text = MusteriTC;
            txtMusteriSifre.Text = MusteriSifre;
        }

        private void cmbMusteriCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
        }
    }
}
