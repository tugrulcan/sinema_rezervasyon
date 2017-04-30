namespace sinema_rezervasyon
{
    partial class frm_RezervasyonListe
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
            this.txt_toplamMusteriSayisi = new System.Windows.Forms.TextBox();
            this.btn_koltukIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam müşteri sayısı";
            // 
            // txt_toplamMusteriSayisi
            // 
            this.txt_toplamMusteriSayisi.Enabled = false;
            this.txt_toplamMusteriSayisi.Location = new System.Drawing.Point(562, 6);
            this.txt_toplamMusteriSayisi.Name = "txt_toplamMusteriSayisi";
            this.txt_toplamMusteriSayisi.Size = new System.Drawing.Size(49, 20);
            this.txt_toplamMusteriSayisi.TabIndex = 1;
            // 
            // btn_koltukIptal
            // 
            this.btn_koltukIptal.Location = new System.Drawing.Point(297, 9);
            this.btn_koltukIptal.Name = "btn_koltukIptal";
            this.btn_koltukIptal.Size = new System.Drawing.Size(75, 23);
            this.btn_koltukIptal.TabIndex = 2;
            this.btn_koltukIptal.Text = "Koltuk İptali";
            this.btn_koltukIptal.UseVisualStyleBackColor = true;
            this.btn_koltukIptal.Click += new System.EventHandler(this.btn_koltukIptal_Click);
            // 
            // frm_RezervasyonListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 480);
            this.Controls.Add(this.btn_koltukIptal);
            this.Controls.Add(this.txt_toplamMusteriSayisi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_RezervasyonListe";
            this.Text = "Rezervasyonlar";
            this.Load += new System.EventHandler(this.frm_RezervasyonListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_toplamMusteriSayisi;
        private System.Windows.Forms.Button btn_koltukIptal;
    }
}

