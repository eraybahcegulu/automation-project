
namespace Cini_Proje
{
    partial class Urunler
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCiniTipi = new System.Windows.Forms.ComboBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtCiniRengi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnCiniEkle = new System.Windows.Forms.Button();
            this.btnCiniGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSilinecekCini = new System.Windows.Forms.TextBox();
            this.btnCiniSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birim Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çini Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Çini Rengi:";
            // 
            // cmbCiniTipi
            // 
            this.cmbCiniTipi.FormattingEnabled = true;
            this.cmbCiniTipi.Location = new System.Drawing.Point(152, 350);
            this.cmbCiniTipi.Name = "cmbCiniTipi";
            this.cmbCiniTipi.Size = new System.Drawing.Size(59, 27);
            this.cmbCiniTipi.TabIndex = 6;
            this.cmbCiniTipi.DropDown += new System.EventHandler(this.cmbCiniTipi_DropDown);
            this.cmbCiniTipi.SelectedIndexChanged += new System.EventHandler(this.cmbCiniTipi_SelectedIndexChanged);
            this.cmbCiniTipi.Click += new System.EventHandler(this.cmbCiniTipi_Click);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(152, 431);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(59, 26);
            this.txtBirimFiyat.TabIndex = 8;
            // 
            // txtCiniRengi
            // 
            this.txtCiniRengi.Location = new System.Drawing.Point(152, 391);
            this.txtCiniRengi.Name = "txtCiniRengi";
            this.txtCiniRengi.Size = new System.Drawing.Size(59, 26);
            this.txtCiniRengi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 320);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Gray;
            this.btnUrunler.Location = new System.Drawing.Point(318, 354);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(90, 27);
            this.btnUrunler.TabIndex = 13;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnCiniEkle
            // 
            this.btnCiniEkle.BackColor = System.Drawing.Color.Gray;
            this.btnCiniEkle.Location = new System.Drawing.Point(318, 475);
            this.btnCiniEkle.Name = "btnCiniEkle";
            this.btnCiniEkle.Size = new System.Drawing.Size(90, 27);
            this.btnCiniEkle.TabIndex = 14;
            this.btnCiniEkle.Text = "Ekle";
            this.btnCiniEkle.UseVisualStyleBackColor = false;
            this.btnCiniEkle.Click += new System.EventHandler(this.btnCiniEkle_Click);
            // 
            // btnCiniGuncelle
            // 
            this.btnCiniGuncelle.BackColor = System.Drawing.Color.Gray;
            this.btnCiniGuncelle.Location = new System.Drawing.Point(318, 416);
            this.btnCiniGuncelle.Name = "btnCiniGuncelle";
            this.btnCiniGuncelle.Size = new System.Drawing.Size(90, 27);
            this.btnCiniGuncelle.TabIndex = 15;
            this.btnCiniGuncelle.Text = "Güncelle";
            this.btnCiniGuncelle.UseVisualStyleBackColor = false;
            this.btnCiniGuncelle.Click += new System.EventHandler(this.btnCiniGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Silinecek Çini ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSilinecekCini
            // 
            this.txtSilinecekCini.Location = new System.Drawing.Point(152, 476);
            this.txtSilinecekCini.Name = "txtSilinecekCini";
            this.txtSilinecekCini.Size = new System.Drawing.Size(59, 26);
            this.txtSilinecekCini.TabIndex = 17;
            this.txtSilinecekCini.TextChanged += new System.EventHandler(this.txtSilinecekCini_TextChanged);
            // 
            // btnCiniSil
            // 
            this.btnCiniSil.BackColor = System.Drawing.Color.Gray;
            this.btnCiniSil.Location = new System.Drawing.Point(217, 477);
            this.btnCiniSil.Name = "btnCiniSil";
            this.btnCiniSil.Size = new System.Drawing.Size(46, 25);
            this.btnCiniSil.TabIndex = 18;
            this.btnCiniSil.Text = "Sil";
            this.btnCiniSil.UseVisualStyleBackColor = false;
            this.btnCiniSil.Click += new System.EventHandler(this.btnCiniSil_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(466, 514);
            this.Controls.Add(this.btnCiniSil);
            this.Controls.Add(this.txtSilinecekCini);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCiniGuncelle);
            this.Controls.Add(this.btnCiniEkle);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCiniRengi);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.cmbCiniTipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Urunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCiniTipi;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtCiniRengi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnCiniEkle;
        private System.Windows.Forms.Button btnCiniGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSilinecekCini;
        private System.Windows.Forms.Button btnCiniSil;
    }
}