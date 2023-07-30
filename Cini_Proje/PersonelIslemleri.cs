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
    public partial class PersonelIslemleri : Form
    {

        

        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
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

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Personel");
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdi,PersonelSoyadi,PersonelTC,PersonelEPosta,CinsiyetID,TelefonNO,PersonelSifre,Maas,HesapNO) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p4", mskPersonelTC.Text);
            komut.Parameters.AddWithValue("@p5", txtPersonelEPosta.Text);
            komut.Parameters.AddWithValue("@p6", cmbPersonelCinsiyet.Text);
            komut.Parameters.AddWithValue("@p7", txtPersonelTelefonNO.Text);
            komut.Parameters.AddWithValue("@p8", txtPersonelSifre.Text);
            komut.Parameters.AddWithValue("@p9", txtPersonelMaas.Text);
            komut.Parameters.AddWithValue("@p10", txtPersonelHesapNO.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Personel");
            baglanti.Close();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelTC=@p4", baglanti);
            komut.Parameters.AddWithValue("@p4", mskSilinecekPersonel.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Personel");
            baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbPersonelSube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Personel where PersonelTC like '%" + mskAranacakPersonel.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdi='" + txtPersonelAd.Text + "',PersonelSoyadi='" + txtPersonelSoyad.Text + "',PersonelEPosta='" + txtPersonelEPosta.Text + "',CinsiyetID='" + cmbPersonelCinsiyet.Text + "',TelefonNO='" + txtPersonelTelefonNO.Text + "',PersonelSifre='" + txtPersonelSifre.Text + "',Maas='" + txtPersonelMaas.Text + "',HesapNO='" + txtPersonelHesapNO.Text + "' where PersonelTC='" + mskPersonelTC.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Personel");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string PersonelAdi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string PersonelSoyadi = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string PersonelTC = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string PersonelEPosta = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string CinsiyetID = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string TelefonNO = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string PersonelSifre = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string Maas = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string HesapNO = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();

            txtPersonelAd.Text = PersonelAdi;
            txtPersonelSoyad.Text = PersonelSoyadi;
            mskPersonelTC.Text = PersonelTC;
            txtPersonelEPosta.Text = PersonelEPosta;
            cmbPersonelCinsiyet.Text = CinsiyetID;
            txtPersonelTelefonNO.Text = TelefonNO;
            txtPersonelSifre.Text = PersonelSifre;
            txtPersonelMaas.Text = Maas;
            txtPersonelHesapNO.Text = HesapNO;         
        }

        private void txtPersonelTelefonNO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbPersonelCinsiyet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erkek: 1\n\nKadın: 2", "Bilgilendirme");
            if (!cmbPersonelCinsiyet.DroppedDown) cmbPersonelCinsiyet.DroppedDown = true;
        }

        private void cmbPersonelCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
