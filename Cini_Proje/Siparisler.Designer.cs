
namespace Cini_Proje
{
    partial class Siparisler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKargoID = new System.Windows.Forms.ComboBox();
            this.mskSiparisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mskTeslimTarihi = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.txtSilinecekSiparis = new System.Windows.Forms.TextBox();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.txtMusteriID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCiniID = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSiparisTutariniHesapla = new System.Windows.Forms.Button();
            this.mskKargoTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtCiniBirimFiyat = new System.Windows.Forms.Label();
            this.txtSiparisTutari = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kargo ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kargo Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sipariş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teslim Tarihi:";
            // 
            // cmbKargoID
            // 
            this.cmbKargoID.FormattingEnabled = true;
            this.cmbKargoID.Location = new System.Drawing.Point(155, 54);
            this.cmbKargoID.Name = "cmbKargoID";
            this.cmbKargoID.Size = new System.Drawing.Size(99, 27);
            this.cmbKargoID.TabIndex = 9;
            this.cmbKargoID.SelectedIndexChanged += new System.EventHandler(this.cmbKargoID_SelectedIndexChanged);
            this.cmbKargoID.Click += new System.EventHandler(this.cmbKargoID_Click);
            // 
            // mskSiparisTarihi
            // 
            this.mskSiparisTarihi.Location = new System.Drawing.Point(155, 136);
            this.mskSiparisTarihi.Mask = "00/00/0000";
            this.mskSiparisTarihi.Name = "mskSiparisTarihi";
            this.mskSiparisTarihi.Size = new System.Drawing.Size(99, 26);
            this.mskSiparisTarihi.TabIndex = 13;
            this.mskSiparisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mskTeslimTarihi
            // 
            this.mskTeslimTarihi.Location = new System.Drawing.Point(155, 175);
            this.mskTeslimTarihi.Mask = "00/00/0000";
            this.mskTeslimTarihi.Name = "mskTeslimTarihi";
            this.mskTeslimTarihi.Size = new System.Drawing.Size(99, 26);
            this.mskTeslimTarihi.TabIndex = 14;
            this.mskTeslimTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 385);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.BackColor = System.Drawing.Color.Gray;
            this.btnSiparisSil.Location = new System.Drawing.Point(653, 409);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(45, 26);
            this.btnSiparisSil.TabIndex = 24;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = false;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // txtSilinecekSiparis
            // 
            this.txtSilinecekSiparis.Location = new System.Drawing.Point(600, 409);
            this.txtSilinecekSiparis.Name = "txtSilinecekSiparis";
            this.txtSilinecekSiparis.Size = new System.Drawing.Size(47, 26);
            this.txtSilinecekSiparis.TabIndex = 23;
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.Gray;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(704, 409);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(92, 26);
            this.btnSiparisGuncelle.TabIndex = 21;
            this.btnSiparisGuncelle.Text = "Güncelle";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = false;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.Gray;
            this.btnSiparisEkle.Location = new System.Drawing.Point(387, 406);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(57, 31);
            this.btnSiparisEkle.TabIndex = 20;
            this.btnSiparisEkle.Text = "Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.BackColor = System.Drawing.Color.Gray;
            this.btnSiparisler.Location = new System.Drawing.Point(271, 405);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(110, 32);
            this.btnSiparisler.TabIndex = 19;
            this.btnSiparisler.Text = "Siparişler";
            this.btnSiparisler.UseVisualStyleBackColor = false;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.FormattingEnabled = true;
            this.txtMusteriID.Location = new System.Drawing.Point(155, 14);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(99, 27);
            this.txtMusteriID.TabIndex = 25;
            this.txtMusteriID.SelectedIndexChanged += new System.EventHandler(this.txtMusteriID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "CiniID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Miktar:";
            // 
            // cmbCiniID
            // 
            this.cmbCiniID.FormattingEnabled = true;
            this.cmbCiniID.Location = new System.Drawing.Point(155, 215);
            this.cmbCiniID.Name = "cmbCiniID";
            this.cmbCiniID.Size = new System.Drawing.Size(99, 27);
            this.cmbCiniID.TabIndex = 30;
            this.cmbCiniID.SelectedIndexChanged += new System.EventHandler(this.cmbCiniID_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(155, 295);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(99, 26);
            this.txtMiktar.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "İndirim:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(155, 336);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(98, 26);
            this.txtIndirim.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Sipariş Tutarı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(450, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Silinecek Sipariş ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Seçilen Çininin Birim Fiyatı:";
            // 
            // btnSiparisTutariniHesapla
            // 
            this.btnSiparisTutariniHesapla.BackColor = System.Drawing.Color.IndianRed;
            this.btnSiparisTutariniHesapla.Location = new System.Drawing.Point(9, 405);
            this.btnSiparisTutariniHesapla.Name = "btnSiparisTutariniHesapla";
            this.btnSiparisTutariniHesapla.Size = new System.Drawing.Size(247, 32);
            this.btnSiparisTutariniHesapla.TabIndex = 40;
            this.btnSiparisTutariniHesapla.Text = "Sipariş Tutarını Hesapla";
            this.btnSiparisTutariniHesapla.UseVisualStyleBackColor = false;
            this.btnSiparisTutariniHesapla.Click += new System.EventHandler(this.btnSiparisTutariniHesapla_Click);
            // 
            // mskKargoTarihi
            // 
            this.mskKargoTarihi.Location = new System.Drawing.Point(155, 94);
            this.mskKargoTarihi.Mask = "00/00/0000";
            this.mskKargoTarihi.Name = "mskKargoTarihi";
            this.mskKargoTarihi.Size = new System.Drawing.Size(99, 26);
            this.mskKargoTarihi.TabIndex = 12;
            this.mskKargoTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtCiniBirimFiyat
            // 
            this.txtCiniBirimFiyat.AutoSize = true;
            this.txtCiniBirimFiyat.Location = new System.Drawing.Point(188, 256);
            this.txtCiniBirimFiyat.Name = "txtCiniBirimFiyat";
            this.txtCiniBirimFiyat.Size = new System.Drawing.Size(27, 19);
            this.txtCiniBirimFiyat.TabIndex = 41;
            this.txtCiniBirimFiyat.Text = "  ";
            // 
            // txtSiparisTutari
            // 
            this.txtSiparisTutari.AutoSize = true;
            this.txtSiparisTutari.Location = new System.Drawing.Point(162, 380);
            this.txtSiparisTutari.Name = "txtSiparisTutari";
            this.txtSiparisTutari.Size = new System.Drawing.Size(27, 19);
            this.txtSiparisTutari.TabIndex = 42;
            this.txtSiparisTutari.Text = "  ";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Location = new System.Drawing.Point(195, 380);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(27, 19);
            this.lblTL.TabIndex = 43;
            this.lblTL.Text = "TL";
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.txtSiparisTutari);
            this.Controls.Add(this.txtCiniBirimFiyat);
            this.Controls.Add(this.btnSiparisTutariniHesapla);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cmbCiniID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.txtSilinecekSiparis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSiparisGuncelle);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskTeslimTarihi);
            this.Controls.Add(this.mskSiparisTarihi);
            this.Controls.Add(this.mskKargoTarihi);
            this.Controls.Add(this.cmbKargoID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Siparisler";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKargoID;
        private System.Windows.Forms.MaskedTextBox mskSiparisTarihi;
        private System.Windows.Forms.MaskedTextBox mskTeslimTarihi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.TextBox txtSilinecekSiparis;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.ComboBox txtMusteriID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCiniID;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSiparisTutariniHesapla;
        private System.Windows.Forms.MaskedTextBox mskKargoTarihi;
        private System.Windows.Forms.Label txtCiniBirimFiyat;
        private System.Windows.Forms.Label txtSiparisTutari;
        private System.Windows.Forms.Label lblTL;
    }
}