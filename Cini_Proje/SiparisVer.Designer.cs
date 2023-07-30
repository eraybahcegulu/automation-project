
namespace Cini_Proje
{
    partial class SiparisVer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCiniAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranacakCini = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSiparisTutariniHesapla = new System.Windows.Forms.Button();
            this.txtCiniID = new System.Windows.Forms.Label();
            this.txtSecilenCini = new System.Windows.Forms.Label();
            this.txtSecilenRenk = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.txtSiparisTutari = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUrunler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "CiniTipiID  ",
            "1: Tabak",
            "2: Vazo               ",
            "3: Saat",
            "4: Yıldız Takımı",
            "5: Kupa",
            "6: Nihale",
            "7: Bereket Nari",
            "8: Ayna",
            "9: Kahve Seti"});
            this.listBox1.Location = new System.Drawing.Point(775, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 194);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCiniAra
            // 
            this.btnCiniAra.Location = new System.Drawing.Point(570, 232);
            this.btnCiniAra.Name = "btnCiniAra";
            this.btnCiniAra.Size = new System.Drawing.Size(58, 26);
            this.btnCiniAra.TabIndex = 3;
            this.btnCiniAra.Text = "Ara";
            this.btnCiniAra.UseVisualStyleBackColor = true;
            this.btnCiniAra.Click += new System.EventHandler(this.btnCiniAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aranacak Çininin Tipi:";
            // 
            // txtAranacakCini
            // 
            this.txtAranacakCini.Location = new System.Drawing.Point(534, 232);
            this.txtAranacakCini.Name = "txtAranacakCini";
            this.txtAranacakCini.Size = new System.Drawing.Size(30, 26);
            this.txtAranacakCini.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 402);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seçilen Tip:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seçilen Renk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Miktar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kargo Firması:";
            // 
            // cmbKargo
            // 
            this.cmbKargo.FormattingEnabled = true;
            this.cmbKargo.Location = new System.Drawing.Point(152, 337);
            this.cmbKargo.Name = "cmbKargo";
            this.cmbKargo.Size = new System.Drawing.Size(65, 27);
            this.cmbKargo.TabIndex = 17;
            this.cmbKargo.SelectedIndexChanged += new System.EventHandler(this.cmbKargo_SelectedIndexChanged);
            this.cmbKargo.Click += new System.EventHandler(this.cmbKargo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Çini ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sipariş Tarihi";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sipariş Tutarı:";
            // 
            // btnSiparisTutariniHesapla
            // 
            this.btnSiparisTutariniHesapla.BackColor = System.Drawing.Color.IndianRed;
            this.btnSiparisTutariniHesapla.Location = new System.Drawing.Point(334, 313);
            this.btnSiparisTutariniHesapla.Name = "btnSiparisTutariniHesapla";
            this.btnSiparisTutariniHesapla.Size = new System.Drawing.Size(202, 46);
            this.btnSiparisTutariniHesapla.TabIndex = 41;
            this.btnSiparisTutariniHesapla.Text = "Sipariş Tutarını Hesapla";
            this.btnSiparisTutariniHesapla.UseVisualStyleBackColor = false;
            this.btnSiparisTutariniHesapla.Click += new System.EventHandler(this.btnSiparisTutariniHesapla_Click);
            // 
            // txtCiniID
            // 
            this.txtCiniID.AutoSize = true;
            this.txtCiniID.Location = new System.Drawing.Point(148, 186);
            this.txtCiniID.Name = "txtCiniID";
            this.txtCiniID.Size = new System.Drawing.Size(27, 19);
            this.txtCiniID.TabIndex = 42;
            this.txtCiniID.Text = "  ";
            this.txtCiniID.Click += new System.EventHandler(this.txtCiniID_Click);
            // 
            // txtSecilenCini
            // 
            this.txtSecilenCini.AutoSize = true;
            this.txtSecilenCini.Location = new System.Drawing.Point(148, 214);
            this.txtSecilenCini.Name = "txtSecilenCini";
            this.txtSecilenCini.Size = new System.Drawing.Size(27, 19);
            this.txtSecilenCini.TabIndex = 43;
            this.txtSecilenCini.Text = "  ";
            this.txtSecilenCini.Click += new System.EventHandler(this.txtSecilenCini_Click);
            // 
            // txtSecilenRenk
            // 
            this.txtSecilenRenk.AutoSize = true;
            this.txtSecilenRenk.Location = new System.Drawing.Point(148, 246);
            this.txtSecilenRenk.Name = "txtSecilenRenk";
            this.txtSecilenRenk.Size = new System.Drawing.Size(27, 19);
            this.txtSecilenRenk.TabIndex = 44;
            this.txtSecilenRenk.Text = "  ";
            this.txtSecilenRenk.Click += new System.EventHandler(this.txtSecilenRenk_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Location = new System.Drawing.Point(148, 276);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(27, 19);
            this.txtFiyat.TabIndex = 45;
            this.txtFiyat.Text = "  ";
            this.txtFiyat.Click += new System.EventHandler(this.txtFiyat_Click);
            // 
            // txtSiparisTutari
            // 
            this.txtSiparisTutari.AutoSize = true;
            this.txtSiparisTutari.Location = new System.Drawing.Point(683, 327);
            this.txtSiparisTutari.Name = "txtSiparisTutari";
            this.txtSiparisTutari.Size = new System.Drawing.Size(27, 19);
            this.txtSiparisTutari.TabIndex = 47;
            this.txtSiparisTutari.Text = "  ";
            this.txtSiparisTutari.Click += new System.EventHandler(this.txtSiparisTutari_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(152, 304);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(65, 26);
            this.txtMiktar.TabIndex = 48;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.Green;
            this.btnSiparisVer.Location = new System.Drawing.Point(749, 313);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(176, 46);
            this.btnSiparisVer.TabIndex = 49;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // TL
            // 
            this.TL.AutoSize = true;
            this.TL.Location = new System.Drawing.Point(716, 327);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(27, 19);
            this.TL.TabIndex = 50;
            this.TL.Text = "TL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMusteriSoyad);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblMusteriAd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblMusteriEPosta);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 165);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgisi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(65, 122);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(27, 19);
            this.lblMusteriSoyad.TabIndex = 7;
            this.lblMusteriSoyad.Text = "  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Soyad:";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(36, 93);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(27, 19);
            this.lblMusteriAd.TabIndex = 5;
            this.lblMusteriAd.Text = "  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "E-Posta:";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(83, 63);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(27, 19);
            this.lblMusteriEPosta.TabIndex = 3;
            this.lblMusteriEPosta.Text = "  ";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(36, 31);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(27, 19);
            this.lblMusteriID.TabIndex = 2;
            this.lblMusteriID.Text = "  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(680, 231);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(88, 26);
            this.btnUrunler.TabIndex = 52;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click_1);
            // 
            // SiparisVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(930, 432);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtSiparisTutari);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtSecilenRenk);
            this.Controls.Add(this.txtSecilenCini);
            this.Controls.Add(this.txtCiniID);
            this.Controls.Add(this.btnSiparisTutariniHesapla);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAranacakCini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCiniAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisVer";
            this.Text = "Sipariş Ver";
            this.Load += new System.EventHandler(this.SiparisVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCiniAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranacakCini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSiparisTutariniHesapla;
        private System.Windows.Forms.Label txtCiniID;
        private System.Windows.Forms.Label txtSecilenCini;
        private System.Windows.Forms.Label txtSecilenRenk;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.Label txtSiparisTutari;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUrunler;
    }
}