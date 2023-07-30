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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }



        private void Siparisler_Load(object sender, EventArgs e)
        {
            

            baglanti.Open();
            SqlCommand komutKargo = new SqlCommand("select * from Kargo", baglanti);
            SqlDataReader readKargo = komutKargo.ExecuteReader();
            while (readKargo.Read())
            {
                cmbKargoID.Items.Add(readKargo["KargoID"]);
            }
            baglanti.Close();

            

            baglanti.Open();
            SqlCommand komutMusteri = new SqlCommand("select * from Musteriler", baglanti);
            SqlDataReader readMusteri = komutMusteri.ExecuteReader();
            while (readMusteri.Read())
            {
                txtMusteriID.Items.Add(readMusteri["MusteriID"]);
            }
            baglanti.Close();

            

            baglanti.Open();
            SqlCommand komutCiniID = new SqlCommand("select * from Ciniler", baglanti);
            SqlDataReader readCiniID = komutCiniID.ExecuteReader();
            while (readCiniID.Read())
            {
                cmbCiniID.Items.Add(readCiniID["CiniID"]);
            }
            baglanti.Close();


        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TOR5BH4;Initial Catalog=CiniDB;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        

        private void cmbKargoID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nKargo Ücretleri 10 TL\n\n\n\nUPS Kargo: 1\n\nYurtiçi Kargo: 2\n\nAras Kargo: 3\n\nMNG Kargo: 4\n\nPTT Kargo: 5", "Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!cmbKargoID.DroppedDown) cmbKargoID.DroppedDown = true;
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Siparisler");
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Siparisler (MusteriID,KargoID,KargoTarihi,SiparisTarihi,TeslimTarihi,CiniID,Miktar,Indirim,SiparisTutari) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtMusteriID.Text);
            komut.Parameters.AddWithValue("@p3", cmbKargoID.Text);
            komut.Parameters.AddWithValue("@p4", mskKargoTarihi.Text);
            komut.Parameters.AddWithValue("@p5", mskSiparisTarihi.Text);
            komut.Parameters.AddWithValue("@p6", mskTeslimTarihi.Text);
            komut.Parameters.AddWithValue("@p7", cmbCiniID.Text);
            komut.Parameters.AddWithValue("@p8", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p9", txtIndirim.Text);
            komut.Parameters.AddWithValue("@p10", txtSiparisTutari.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Siparisler");
            baglanti.Close();
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Siparisler where SiparisID=@SiparisID", baglanti);
            komut.Parameters.AddWithValue("@SiparisID", txtSilinecekSiparis.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Siparisler");
            baglanti.Close();
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string SiparisID = dataGridView1.Rows[secililalan].Cells[0].Value.ToString();
            SqlCommand komut = new SqlCommand("update Siparisler set MusteriID='" + txtMusteriID.Text + "',KargoID='" + cmbKargoID.Text + "',KargoTarihi='" + mskKargoTarihi.Text + "',SiparisTarihi='" + mskSiparisTarihi.Text + "',TeslimTarihi='" + mskTeslimTarihi.Text + "',CiniID='" + cmbCiniID.Text + "',Miktar='" + txtMiktar.Text + "',Indirim='" + txtIndirim.Text + "',SiparisTutari='" + txtSiparisTutari.Text + "' where SiparisID='" + SiparisID +  "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Siparisler");
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string MusteriID = dataGridView1.Rows[secililalan].Cells[1].Value.ToString();
            string KargoID = dataGridView1.Rows[secililalan].Cells[2].Value.ToString();
            string KargoTarihi = dataGridView1.Rows[secililalan].Cells[3].Value.ToString();
            string SiparisTarihi = dataGridView1.Rows[secililalan].Cells[4].Value.ToString();
            string TeslimTarihi = dataGridView1.Rows[secililalan].Cells[5].Value.ToString();
            string CiniID = dataGridView1.Rows[secililalan].Cells[6].Value.ToString();
            string Miktar = dataGridView1.Rows[secililalan].Cells[7].Value.ToString();
            string Indirim = dataGridView1.Rows[secililalan].Cells[8].Value.ToString();
            


            txtMusteriID.Text = MusteriID;
            cmbKargoID.Text = KargoID;
            mskKargoTarihi.Text = KargoTarihi;
            mskSiparisTarihi.Text = SiparisTarihi;
            mskTeslimTarihi.Text = TeslimTarihi;
            cmbCiniID.Text = CiniID;
            txtMiktar.Text = Miktar;
            txtIndirim.Text = Indirim;
            



        }

        private void cmbKargoID_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonelID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCiniID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ciniler where CiniID like '" + cmbCiniID.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtCiniBirimFiyat.Text = read["BirimFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnSiparisTutariniHesapla_Click(object sender, EventArgs e)
        {
            double BirimFiyat = Convert.ToDouble(txtCiniBirimFiyat.Text);
            double Miktar = Convert.ToDouble(txtMiktar.Text);
            double Indirim = Convert.ToDouble(txtIndirim.Text);

            txtSiparisTutari.Text = Convert.ToString((BirimFiyat * Miktar) + 10 - Indirim);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
