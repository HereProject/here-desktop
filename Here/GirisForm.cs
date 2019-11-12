using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Here.Formlar
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        bool durum = false;
        Point konum;
        private void ustPanel_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            konum = e.Location;
        }

        private void ustPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Location.X - (konum.X);
                this.Top = e.Y + this.Location.Y - (konum.Y);

            }
        }

        private void ustPanel_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Sınıflar.sayfaUret.sayfaEkle(new AnaPanel());
            Sınıflar.menuUret.menuEkle(new Menu());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
