using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Here.Formlar
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_yoklama_Click(object sender, EventArgs e)
        {
            Sınıflar.sayfaUret.sayfaEkle(new Yoklama());
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {

            Sınıflar.sayfaUret.sayfaEkle(new Kullanici());
        }

        private void btn_dersler_Click(object sender, EventArgs e)
        {
            Sınıflar.sayfaUret.sayfaEkle(new Dersler());
        }
    }
}
