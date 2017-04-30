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
using sinema_rezervasyon.forms;

namespace sinema_rezervasyon
{
    public partial class frm_RezervasyonListe : Form
    {
        public frm_RezervasyonListe()
        {
            InitializeComponent();
            BL.koltukListesi.InsertFirst(new Koltuk() { aktifMi = false }); //61 node, koltuk adlari karismasin diye.  
        }

        

        private void frm_RezervasyonListe_Load(object sender, EventArgs e)
        {
            butonlariYarat();
            
        }

        private void butonlariYarat()
        {
            Point start_location = new Point() { X = 10, Y = 40 };
            Size button_size = new Size(40, 40);

            for (int i = 0; i < 5; i++)
            {
                start_location.Y += 60;
                start_location.X = 10;
                for (int j = 0; j < 12; j++)
                {
                    int koltuk_no = ((i * 12) + j+1);
                    Button b = new Button() {
                        Location = start_location,
                        Name = "btn_musteri_" + koltuk_no.ToString(),
                        Text = koltuk_no.ToString(),
                        Size = button_size,
                        BackColor = Color.Chartreuse
                    };
                    b.Click += new System.EventHandler(this.btn_musteri_n_Click);

                    this.Controls.Add(b);
                    start_location.X += 60;

                    BL.koltukListesi.InsertLast(new Koltuk() { aktifMi = false, koltukNo = koltuk_no });
                }
            }
            this.txt_toplamMusteriSayisi.Text = BL.koltukListesi.getAvailableSeatCount().ToString();
        }

        public void koltuklariGuncelle()
        {
            Node h = BL.koltukListesi.Head;
            int koltukNo = 1;
            while (h.Next != null)
            {
                var  b = Controls.Find("btn_musteri_" + koltukNo.ToString(), true)[0];
                b = (Button)b; 

                if (h.Data.aktifMi)
                    b.BackColor = Color.Chartreuse;
                else
                    b.BackColor = Color.Red;

                h = h.Next;
            }
            this.txt_toplamMusteriSayisi.Text = BL.koltukListesi.getAvailableSeatCount().ToString();
        }

        private void btn_musteri_n_Click(object sender, EventArgs e)
        {
            
            Button b = (Button) sender;
            b.BackColor = Color.Red;

            int koltukNo = Convert.ToInt32(b.Text);
            frm_MusteriBilgi mbilgi = new frm_MusteriBilgi(koltukNo, this);

            Node tiklanan = BL.koltukListesi.GetElement(koltukNo);

            if (tiklanan.Data.aktifMi == false)
            {
                mbilgi.Show();
            }
            

        }
    }
}
