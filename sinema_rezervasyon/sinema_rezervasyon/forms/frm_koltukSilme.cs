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
    public partial class frm_koltukSilme : Form
    {
        public frm_RezervasyonListe f = null;

        public frm_koltukSilme(frm_RezervasyonListe f)
        {
            this.f = f;
            InitializeComponent();
        }
        public Node silinecek = null;

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAd.Text)== false && String.IsNullOrEmpty(txtSoyad.Text) == false)
            {
                var ad = txtAd.Text;
                var soyad = txtSoyad.Text;

                Node n = BL.koltukListesi.Head;
                while (n.Next != null)
                {
                    if (n.Data.Ad == ad && n.Data.Soyad ==soyad)
                    {
                        silinecek = n;
                        this.btnSil.Enabled = true;
                        break;
                    }
                    n = n.Next;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string s = BL.koltukListesi.DisplayElements();

            BL.koltukListesi.DeletePos(silinecek.Data.koltukNo);
            BL.koltukListesi.InsertPos(silinecek.Data.koltukNo, new Koltuk() { aktifMi = true, koltukNo = silinecek.Data.koltukNo });
            f.koltuklariGuncelle();
            this.Hide();
        }
    }
}
