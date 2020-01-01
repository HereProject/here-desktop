using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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

        private async void Btn_giris_Click(object sender, EventArgs e)
        {
            Sınıflar.sayfaUret.sayfaEkle(new AnaPanel());
            Sınıflar.menuUret.menuEkle(new Menu());

            HttpPost();


        }

        public void HttpGet() 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://3.15.201.22/api/v1/identity/login");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //Console.WriteLine(content);
        }

        public void HttpPost()
        {
            try
            {
                
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://3.15.201.22/api/v1/identity/login");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"email\":\"" + txt_id.Text+ "\",\"password\":\"" + txt_sifre.Text + "\"}";

                    streamWriter.Write(json);
                }
                Sınıflar.Login log = new Sınıflar.Login();
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JObject json = JObject.Parse(result);
                    log.token = json["token"].ToString();

                    MessageBox.Show(log.token);


                }
                /* using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                 {
                     var result = JsonConvert.DeserializeObject<Sınıflar.Login>(streamReader.ReadToEnd());
                     if (!result.success)
                     {
                         MessageBox.Show(string.Join("\n", result.errors));
                     }
                     else
                     {
                         MessageBox.Show("ok");
                     }

            }*/
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
            


        }


    }
}
