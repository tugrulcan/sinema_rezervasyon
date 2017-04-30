using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkedListImplementation;

namespace sinema_rezervasyon.forms
{
    public partial class frm_MusteriBilgi : Form
    {
        public int koltukNo { get; set; }
        private frm_RezervasyonListe aktifPencere = null;

        public frm_MusteriBilgi(int koltukNo, frm_RezervasyonListe aktifPencere)
        {
            this.koltukNo = koltukNo;
            this.aktifPencere = aktifPencere;
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Koltuk k = new Koltuk()
            {
                Ad = txt_musteriAd.Text,
                Soyad = txt_soyad.Text,
                koltukNo = koltukNo,
                aktifMi = true
            };

            MessageBox.Show("Müşteri kaydedildi!");
            BL.koltukListesi.DeletePos(koltukNo);
            BL.koltukListesi.InsertPos(koltukNo, k);

            aktifPencere.koltuklariGuncelle();
            this.Close();
        }
    }
}
