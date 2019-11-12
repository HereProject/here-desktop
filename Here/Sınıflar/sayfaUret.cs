using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Here.Formlar;

namespace Here.Sınıflar
{

    public class sayfaUret
    {
        public static void sayfaEkle(UserControl uc)

        {
            uc.Left = 0;
            uc.Top = 0;
            Program.grs.mainPanel.Controls.Clear();
            Program.grs.mainPanel.Controls.Add(uc);
        }

    }
}
