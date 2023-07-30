
namespace Cini_Proje
{
    partial class MusteriIslemleri
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
            this.txtMusteriTelefonNO = new System.Windows.Forms.MaskedTextBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.mskAranacakMusteri = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskSilinecekMusteri = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.cmbMusteriTipi = new System.Windows.Forms.ComboBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.cmbMusteriSehir = new System.Windows.Forms.ComboBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.mskMusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriEPosta = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteriCinsiyet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriTelefonNO
            // 
            this.txtMusteriTelefonNO.Location = new System.Drawing.Point(133, 156);
            this.txtMusteriTelefonNO.Mask = "(999) 000-0000";
            this.txtMusteriTelefonNO.Name = "txtMusteriTelefonNO";
            this.txtMusteriTelefonNO.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriTelefonNO.TabIndex = 64;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(824, 446);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(92, 26);
            this.btnMusteriGuncelle.TabIndex = 63;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriAra.Location = new System.Drawing.Point(771, 446);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(47, 27);
            this.btnMusteriAra.TabIndex = 62;
            this.btnMusteriAra.Text = "Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = false;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // mskAranacakMusteri
            // 
            this.mskAranacakMusteri.Location = new System.Drawing.Point(658, 447);
            this.mskAranacakMusteri.Mask = "00000000000";
            this.mskAranacakMusteri.Name = "mskAranacakMusteri";
            this.mskAranacakMusteri.Size = new System.Drawing.Size(107, 26);
            this.mskAranacakMusteri.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(525, 455);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Aranacak Müşteri TC:";
            // 
            // mskSilinecekMusteri
            // 
            this.mskSilinecekMusteri.Location = new System.Drawing.Point(359, 447);
            this.mskSilinecekMusteri.Mask = "00000000000";
            this.mskSilinecekMusteri.Name = "mskSilinecekMusteri";
            this.mskSilinecekMusteri.Size = new System.Drawing.Size(106, 26);
            this.mskSilinecekMusteri.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(221, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Silinecek Müşteri TC:";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriler.Location = new System.Drawing.Point(95, 443);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(120, 33);
            this.btnMusteriler.TabIndex = 55;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriSil.Location = new System.Drawing.Point(471, 446);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(48, 27);
            this.btnMusteriSil.TabIndex = 54;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriEkle.Location = new System.Drawing.Point(6, 443);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(83, 33);
            this.btnMusteriEkle.TabIndex = 53;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // cmbMusteriTipi
            // 
            this.cmbMusteriTipi.FormattingEnabled = true;
            this.cmbMusteriTipi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbMusteriTipi.Location = new System.Drawing.Point(133, 321);
            this.cmbMusteriTipi.Name = "cmbMusteriTipi";
            this.cmbMusteriTipi.Size = new System.Drawing.Size(111, 27);
            this.cmbMusteriTipi.TabIndex = 52;
            this.cmbMusteriTipi.Click += new System.EventHandler(this.cmbMusteriTipi_Click);
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(133, 198);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriAdres.TabIndex = 50;
            // 
            // cmbMusteriSehir
            // 
            this.cmbMusteriSehir.FormattingEnabled = true;
            this.cmbMusteriSehir.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81"});
            this.cmbMusteriSehir.Location = new System.Drawing.Point(133, 282);
            this.cmbMusteriSehir.Name = "cmbMusteriSehir";
            this.cmbMusteriSehir.Size = new System.Drawing.Size(111, 27);
            this.cmbMusteriSehir.TabIndex = 48;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(133, 32);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriAd.TabIndex = 47;
            // 
            // mskMusteriTC
            // 
            this.mskMusteriTC.Location = new System.Drawing.Point(133, 364);
            this.mskMusteriTC.Mask = "00000000000";
            this.mskMusteriTC.Name = "mskMusteriTC";
            this.mskMusteriTC.Size = new System.Drawing.Size(111, 26);
            this.mskMusteriTC.TabIndex = 46;
            // 
            // txtMusteriEPosta
            // 
            this.txtMusteriEPosta.Location = new System.Drawing.Point(133, 114);
            this.txtMusteriEPosta.Name = "txtMusteriEPosta";
            this.txtMusteriEPosta.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriEPosta.TabIndex = 45;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(133, 73);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriSoyad.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Şehir:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Müşteri Tipi:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Telefon NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ad:";
            // 
            // cmbMusteriCinsiyet
            // 
            this.cmbMusteriCinsiyet.FormattingEnabled = true;
            this.cmbMusteriCinsiyet.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbMusteriCinsiyet.Location = new System.Drawing.Point(133, 238);
            this.cmbMusteriCinsiyet.Name = "cmbMusteriCinsiyet";
            this.cmbMusteriCinsiyet.Size = new System.Drawing.Size(111, 27);
            this.cmbMusteriCinsiyet.TabIndex = 65;
            this.cmbMusteriCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriCinsiyet_SelectedIndexChanged);
            this.cmbMusteriCinsiyet.Click += new System.EventHandler(this.cmbMusteriCinsiyet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 399);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(133, 405);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(111, 26);
            this.txtMusteriSifre.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 70;
            this.label7.Text = "Şifre:";
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(929, 479);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMusteriSifre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMusteriCinsiyet);
            this.Controls.Add(this.txtMusteriTelefonNO);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.mskAranacakMusteri);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mskSilinecekMusteri);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.cmbMusteriTipi);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.cmbMusteriSehir);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.mskMusteriTC);
            this.Controls.Add(this.txtMusteriEPosta);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriIslemleri";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtMusteriTelefonNO;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.MaskedTextBox mskAranacakMusteri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskSilinecekMusteri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ComboBox cmbMusteriTipi;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.ComboBox cmbMusteriSehir;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.MaskedTextBox mskMusteriTC;
        private System.Windows.Forms.TextBox txtMusteriEPosta;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteriCinsiyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.Label label7;
    }
}