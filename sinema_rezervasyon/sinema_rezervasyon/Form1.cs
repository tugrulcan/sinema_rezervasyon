using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_rezervasyon
{
    public partial class frm_RezervasyonListe : Form
    {
        public frm_RezervasyonListe()
        {
            InitializeComponent();
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
                    int musteri_no = ((i * 12) + j+1);

                    Button b = new Button() {
                        Location = start_location,
                        Name = "btn_musteri_" + musteri_no.ToString(),
                        Text = musteri_no.ToString(),
                        Size = button_size,
                        BackColor = Color.Chartreuse
                    };
                    b.Click += new System.EventHandler(this.btn_musteri_n_Click);

                    this.Controls.Add(b);
                    start_location.X += 60;
                }
            }
        }

        private void btn_musteri_n_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            b.BackColor = Color.Red;

        }
    }
}
