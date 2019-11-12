using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Here.Sınıflar
{
    public class menuUret
    {
        public static void menuEkle(UserControl uc)

        {
            uc.Left = 0;
            uc.Top = 0;
            Program.grs.menuPanel.Controls.Clear();
            Program.grs.menuPanel.Controls.Add(uc);
        }

    }
}
