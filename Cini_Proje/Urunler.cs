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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutCiniTipi = new SqlCommand("select * from CiniTipi", baglanti);
            SqlDataReader readCiniTipi = komutCiniTipi.ExecuteReader();
            while (readCiniTipi.Read())
            {
                cmbCiniTipi.Items.Add(readCiniTipi["CiniTipiID"]);
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

        private void cmbCiniTipi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabak: 1\n\nVazo: 2\n\nSaat: 3\n\nYıldız Takımı: 4\n\nKupa: 5\n\nNihale: 6\n\nBereket Narı: 7\n\nAyna: 8\n\nKahve Seti: 9", "Bilgilendirme");
            if (!cmbCiniTipi.DroppedDown) cmbCiniTipi.DroppedDown = true;

        }

        private void cmbCiniTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void cmbCiniTipi_DropDown(object sender, EventArgs e)
        {

        }

        private void cmbCiniTeknigi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCiniTeknigi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Ciniler");
        }

        private void btnCiniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ciniler (BirimFiyati,CiniTipiID,CiniRengi) values (@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtBirimFiyat.Text);
            komut.Parameters.AddWithValue("@p3", cmbCiniTipi.Text);
            komut.Parameters.AddWithValue("@p4", txtCiniRengi.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Ciniler");
            baglanti.Close();
        }

        private void btnCiniSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ciniler where CiniID=@CiniID", baglanti);
            komut.Parameters.AddWithValue("@CiniID", txtSilinecekCini.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Ciniler");
            baglanti.Close();
        }

        private void btnCiniGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string CiniID = dataGridView1.Rows[secililalan].Cells[0].Value.ToString();
            SqlCommand komut = new SqlCommand("update Ciniler set BirimFiyati='" + txtBirimFiyat.Text + "',CiniTipiID='" + cmbCiniTipi.Text + "',CiniRengi='" + txtCiniRengi.Text +"' where CiniID='" + CiniID + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Ciniler");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secililalan = dataGridView1.SelectedCells[0].RowIndex;
            string CiniTipiID = dataGridView1.Rows[secililalan].Cells[1].Value.ToString();
            string CiniRengi = dataGridView1.Rows[secililalan].Cells[2].Value.ToString();
            string BirimFiyati = dataGridView1.Rows[secililalan].Cells[3].Value.ToString();




            txtBirimFiyat.Text = BirimFiyati;
            cmbCiniTipi.Text = CiniTipiID;
            txtCiniRengi.Text = CiniRengi;

        }

        private void txtSilinecekCini_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
