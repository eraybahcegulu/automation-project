
namespace Cini_Proje
{
    partial class PersonelIslemleri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.mskPersonelTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelEPosta = new System.Windows.Forms.TextBox();
            this.cmbPersonelCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelMaas = new System.Windows.Forms.TextBox();
            this.txtPersonelHesapNO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.mskSilinecekPersonel = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskAranacakPersonel = new System.Windows.Forms.MaskedTextBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtPersonelTelefonNO = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon NO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Maaş:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hesap NO:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(120, 22);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelAd.TabIndex = 10;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(120, 58);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelSoyad.TabIndex = 11;
            // 
            // mskPersonelTC
            // 
            this.mskPersonelTC.Location = new System.Drawing.Point(120, 96);
            this.mskPersonelTC.Mask = "00000000000";
            this.mskPersonelTC.Name = "mskPersonelTC";
            this.mskPersonelTC.Size = new System.Drawing.Size(111, 26);
            this.mskPersonelTC.TabIndex = 12;
            // 
            // txtPersonelEPosta
            // 
            this.txtPersonelEPosta.Location = new System.Drawing.Point(120, 131);
            this.txtPersonelEPosta.Name = "txtPersonelEPosta";
            this.txtPersonelEPosta.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelEPosta.TabIndex = 13;
            // 
            // cmbPersonelCinsiyet
            // 
            this.cmbPersonelCinsiyet.FormattingEnabled = true;
            this.cmbPersonelCinsiyet.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPersonelCinsiyet.Location = new System.Drawing.Point(120, 168);
            this.cmbPersonelCinsiyet.Name = "cmbPersonelCinsiyet";
            this.cmbPersonelCinsiyet.Size = new System.Drawing.Size(111, 27);
            this.cmbPersonelCinsiyet.TabIndex = 14;
            this.cmbPersonelCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelCinsiyet_SelectedIndexChanged);
            this.cmbPersonelCinsiyet.Click += new System.EventHandler(this.cmbPersonelCinsiyet_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(120, 242);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelSifre.TabIndex = 16;
            // 
            // txtPersonelMaas
            // 
            this.txtPersonelMaas.Location = new System.Drawing.Point(120, 282);
            this.txtPersonelMaas.Name = "txtPersonelMaas";
            this.txtPersonelMaas.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelMaas.TabIndex = 17;
            // 
            // txtPersonelHesapNO
            // 
            this.txtPersonelHesapNO.Location = new System.Drawing.Point(120, 318);
            this.txtPersonelHesapNO.Name = "txtPersonelHesapNO";
            this.txtPersonelHesapNO.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelHesapNO.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 322);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.Gray;
            this.btnPersonelEkle.Location = new System.Drawing.Point(153, 354);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(78, 33);
            this.btnPersonelEkle.TabIndex = 21;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.Gray;
            this.btnPersonelSil.Location = new System.Drawing.Point(484, 357);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(48, 27);
            this.btnPersonelSil.TabIndex = 22;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.Gray;
            this.btnPersoneller.Location = new System.Drawing.Point(28, 354);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(119, 33);
            this.btnPersoneller.TabIndex = 23;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(235, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Silinecek Personel TC:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // mskSilinecekPersonel
            // 
            this.mskSilinecekPersonel.Location = new System.Drawing.Point(370, 358);
            this.mskSilinecekPersonel.Mask = "00000000000";
            this.mskSilinecekPersonel.Name = "mskSilinecekPersonel";
            this.mskSilinecekPersonel.Size = new System.Drawing.Size(108, 26);
            this.mskSilinecekPersonel.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(538, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Aranacak Personel TC:";
            // 
            // mskAranacakPersonel
            // 
            this.mskAranacakPersonel.Location = new System.Drawing.Point(667, 358);
            this.mskAranacakPersonel.Mask = "00000000000";
            this.mskAranacakPersonel.Name = "mskAranacakPersonel";
            this.mskAranacakPersonel.Size = new System.Drawing.Size(107, 26);
            this.mskAranacakPersonel.TabIndex = 30;
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.BackColor = System.Drawing.Color.Gray;
            this.btnPersonelAra.Location = new System.Drawing.Point(780, 358);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(47, 26);
            this.btnPersonelAra.TabIndex = 31;
            this.btnPersonelAra.Text = "Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = false;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gray;
            this.btnGuncelle.Location = new System.Drawing.Point(833, 357);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 27);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtPersonelTelefonNO
            // 
            this.txtPersonelTelefonNO.Location = new System.Drawing.Point(120, 206);
            this.txtPersonelTelefonNO.Mask = "(999) 000-0000";
            this.txtPersonelTelefonNO.Name = "txtPersonelTelefonNO";
            this.txtPersonelTelefonNO.Size = new System.Drawing.Size(111, 26);
            this.txtPersonelTelefonNO.TabIndex = 33;
            this.txtPersonelTelefonNO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPersonelTelefonNO_MaskInputRejected);
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(933, 390);
            this.Controls.Add(this.txtPersonelTelefonNO);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnPersonelAra);
            this.Controls.Add(this.mskAranacakPersonel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mskSilinecekPersonel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPersonelHesapNO);
            this.Controls.Add(this.txtPersonelMaas);
            this.Controls.Add(this.txtPersonelSifre);
            this.Controls.Add(this.cmbPersonelCinsiyet);
            this.Controls.Add(this.txtPersonelEPosta);
            this.Controls.Add(this.mskPersonelTC);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelIslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.MaskedTextBox mskPersonelTC;
        private System.Windows.Forms.TextBox txtPersonelEPosta;
        private System.Windows.Forms.ComboBox cmbPersonelCinsiyet;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelMaas;
        private System.Windows.Forms.TextBox txtPersonelHesapNO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskSilinecekPersonel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskAranacakPersonel;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox txtPersonelTelefonNO;
    }
}