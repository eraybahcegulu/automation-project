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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Musteriler Where MusteriEPosta=@p1 and MusteriSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtMusteriEPosta.Text);
            komut.Parameters.AddWithValue("@p2", txtMusteriSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Giriş Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SiparisVer fr = new SiparisVer();
                fr.MusteriEPosta = txtMusteriEPosta.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı E-Posta veya Şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriKayit mstrkyt = new MusteriKayit();
            mstrkyt.Show();
        }
    }
}
