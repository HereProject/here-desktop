using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Here.Sınıflar
{
    public class Login
    {
        internal bool success;
        internal string[] errors;
        public string email { get; set; }
        public string password { get; set; }
        public string token { get; set; }

    }
}
