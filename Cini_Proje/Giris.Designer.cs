
namespace Cini_Proje
{
    partial class Giris
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
            this.btnPersonelGirisi = new System.Windows.Forms.Button();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelGirisi
            // 
            this.btnPersonelGirisi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelGirisi.Location = new System.Drawing.Point(12, 12);
            this.btnPersonelGirisi.Name = "btnPersonelGirisi";
            this.btnPersonelGirisi.Size = new System.Drawing.Size(220, 73);
            this.btnPersonelGirisi.TabIndex = 0;
            this.btnPersonelGirisi.Text = "Personel Girişi";
            this.btnPersonelGirisi.UseVisualStyleBackColor = false;
            this.btnPersonelGirisi.Click += new System.EventHandler(this.btnPersonelGirisi_Click);
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMusteriGirisi.Location = new System.Drawing.Point(12, 91);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(220, 73);
            this.btnMusteriGirisi.TabIndex = 1;
            this.btnMusteriGirisi.Text = "Müşteri Girişi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = false;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 171);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Controls.Add(this.btnPersonelGirisi);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelGirisi;
        private System.Windows.Forms.Button btnMusteriGirisi;
    }
}