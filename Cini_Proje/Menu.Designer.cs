
namespace Cini_Proje
{
    partial class Menu
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
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(11, 10);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(205, 76);
            this.btnPersonelIslemleri.TabIndex = 0;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = false;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMusteriIslemleri.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(222, 9);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(205, 76);
            this.btnMusteriIslemleri.TabIndex = 1;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = false;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSiparisler.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisler.Location = new System.Drawing.Point(11, 92);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(205, 76);
            this.btnSiparisler.TabIndex = 2;
            this.btnSiparisler.Text = "Siparişler";
            this.btnSiparisler.UseVisualStyleBackColor = false;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUrunler.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(222, 92);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(205, 76);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 173);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnUrunler;
    }
}