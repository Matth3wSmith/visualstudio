using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kerites
{
    internal class Telek
    {
        public bool paros;
        public int szelesseg;
        public string szin;
        public int hazszam;
        public Telek(string sor, int hazszam) {
            //"0 10 P"
            string[] vag = sor.Split(" ");

            paros = vag[0] == "1";
            szelesseg = Convert.ToInt32(vag[1]);
            szin = vag[2];
            this.hazszam = hazszam;




        }
    }
}
