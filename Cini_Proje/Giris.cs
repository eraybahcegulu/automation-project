using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cini_Proje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            PersonelGiris prsnl = new PersonelGiris();
            prsnl.Show();
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            MusteriGiris mstr = new MusteriGiris();
            mstr.Show();
        }
    }
}
