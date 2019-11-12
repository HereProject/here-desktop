using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Here

{

    static class Program
    {
        public static Formlar.GirisForm grs;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Baslat();
            Application.Run(grs);
        }

        public static void Baslat()
        {
            grs = new Formlar.GirisForm();
        }

    }
}
