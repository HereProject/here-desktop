using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using System.IO;
using System.Net.Http.Headers;
using Here.Sınıflar;

namespace Here.Formlar
{
    public partial class Yoklama : UserControl
    {
        public Yoklama()
        {
            InitializeComponent();
        }

        private void Yoklama_Load(object sender, EventArgs e)
        {

        }

        private async void Btn_yGetir_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://3.15.201.22/ders/yoklama/gelenler");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string content = new StreamReader(response.GetResponseStream()).ReadToEnd();

                dgv_yoklama.DataSource = content;

            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }



        }
        class Product
        {
            public int DersId { get; set; }

            public DateTime SonGecerlilik { get; set; }

            public string Key { get; set; }

        }
        public void HttpGet()
        {
           
        }



    }
}
