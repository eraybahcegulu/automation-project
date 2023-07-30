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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();


        private void lnkKayitOl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelKayit fr = new PersonelKayit();
            fr.Show();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelTC=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Giriş Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu fr = new Menu();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
