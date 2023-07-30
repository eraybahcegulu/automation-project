
namespace Cini_Proje
{
    partial class MusteriGiris
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
            this.lnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriEPosta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusteriIDGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkKayitOl
            // 
            this.lnkKayitOl.AutoSize = true;
            this.lnkKayitOl.Location = new System.Drawing.Point(303, 152);
            this.lnkKayitOl.Name = "lnkKayitOl";
            this.lnkKayitOl.Size = new System.Drawing.Size(81, 19);
            this.lnkKayitOl.TabIndex = 57;
            this.lnkKayitOl.TabStop = true;
            this.lnkKayitOl.Text = "Kayıt Ol";
            this.lnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayitOl_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Gray;
            this.btnGiris.Location = new System.Drawing.Point(174, 145);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(123, 32);
            this.btnGiris.TabIndex = 56;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(174, 103);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(123, 26);
            this.txtMusteriSifre.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Şifre:";
            // 
            // txtMusteriEPosta
            // 
            this.txtMusteriEPosta.Location = new System.Drawing.Point(174, 62);
            this.txtMusteriEPosta.Name = "txtMusteriEPosta";
            this.txtMusteriEPosta.Size = new System.Drawing.Size(123, 26);
            this.txtMusteriEPosta.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "E-Posta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 51;
            this.label1.Text = "Müşteri Giriş Paneli";
            // 
            // lblMusteriIDGiris
            // 
            this.lblMusteriIDGiris.AutoSize = true;
            this.lblMusteriIDGiris.Location = new System.Drawing.Point(12, 179);
            this.lblMusteriIDGiris.Name = "lblMusteriIDGiris";
            this.lblMusteriIDGiris.Size = new System.Drawing.Size(0, 19);
            this.lblMusteriIDGiris.TabIndex = 58;
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(425, 207);
            this.Controls.Add(this.lblMusteriIDGiris);
            this.Controls.Add(this.lnkKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtMusteriSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriEPosta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriGiris";
            this.Text = "Müşteri Girişi";
            this.Load += new System.EventHandler(this.MusteriGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriEPosta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusteriIDGiris;
    }
}