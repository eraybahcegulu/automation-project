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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            PersonelIslemleri pi = new PersonelIslemleri();
            pi.Show();
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            MusteriIslemleri mi = new MusteriIslemleri();
            mi.Show();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            Siparisler spr = new Siparisler();
            spr.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Urunler urn = new Urunler();
            urn.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
