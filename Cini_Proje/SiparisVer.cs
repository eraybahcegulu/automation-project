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
    public partial class SiparisVer : Form
    {
        public SiparisVer()
        {
            InitializeComponent();
        }

        

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TOR5BH4;Initial Catalog=CiniDB;Integrated Security=True");

        public string MusteriEPosta;
        
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SiparisVer_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komutKargo = new SqlCommand("select * from Kargo", baglanti);
            SqlDataReader readKargo = komutKargo.ExecuteReader();
            while (readKargo.Read())
            {
                cmbKargo.Items.Add(readKargo["KargoID"]);
            }
            baglanti.Close();

            verilerigoster("Select * From Ciniler");



            lblMusteriEPosta.Text = MusteriEPosta;



            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Adi from Musteriler where MusteriEPosta=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", lblMusteriEPosta.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lblMusteriAd.Text = dr1[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Soyadi from Musteriler where MusteriEPosta=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", lblMusteriEPosta.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblMusteriSoyad.Text = dr2[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select MusteriID from Musteriler where MusteriEPosta=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", lblMusteriEPosta.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblMusteriID.Text = dr3[0].ToString();

            }
            baglanti.Close();

        }


        private void btnUrunler_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCiniAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ciniler where CiniTipiID like '%" + txtAranacakCini.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbKargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKargo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nKargo Ücretleri 10 TL\n\n\n\nUPS: 1\n\nYurtiçi: 2\n\nAras: 3\n\nMNG: 4\n\nPTT: 5", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!cmbKargo.DroppedDown) cmbKargo.DroppedDown = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string CiniID = dataGridView1.Rows[secililalan].Cells[0].Value.ToString();
            string CiniTipiID = dataGridView1.Rows[secililalan].Cells[1].Value.ToString();
            string CiniRengi = dataGridView1.Rows[secililalan].Cells[2].Value.ToString();
            string BirimFiyati = dataGridView1.Rows[secililalan].Cells[3].Value.ToString();



            txtCiniID.Text = CiniID;
            txtSecilenCini.Text = CiniTipiID;
            txtSecilenRenk.Text = CiniRengi;
            txtFiyat.Text = BirimFiyati;

        }

        

        private void btnSiparisTutariniHesapla_Click(object sender, EventArgs e)
        {
            double BirimFiyat = Convert.ToDouble(txtFiyat.Text);
            double Miktar = Convert.ToDouble(txtMiktar.Text);

            txtSiparisTutari.Text = Convert.ToString((BirimFiyat * Miktar) + 10);
        }

        private void txtCiniID_Click(object sender, EventArgs e)
        {

        }

        private void txtFiyat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSecilenRenk_Click(object sender, EventArgs e)
        {

        }

        private void txtSecilenCini_Click(object sender, EventArgs e)
        {

        }

        private void txtSiparisTutari_Click(object sender, EventArgs e)
        {

        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Siparisler (MusteriID,KargoID,SiparisTarihi,CiniID,Miktar,SiparisTutari) values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut2.Parameters.AddWithValue("@p2", lblMusteriID.Text);
            komut2.Parameters.AddWithValue("@p3", cmbKargo.Text);
            komut2.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
            komut2.Parameters.AddWithValue("@p5", txtCiniID.Text);
            komut2.Parameters.AddWithValue("@p6", txtMiktar.Text);
            komut2.Parameters.AddWithValue("@p7", txtSiparisTutari.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Siparişiniz alındı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnUrunler_Click_1(object sender, EventArgs e)
        {
            verilerigoster("Select * From Ciniler");
        }
    }
}
