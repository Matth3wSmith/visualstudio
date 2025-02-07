using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reklam
{
    internal class Rendeles
    {
        public int nap;
        public string varos;
        public int darab;
        public Rendeles(string sor)
        {
            string[] vag = sor.Split();

            nap = int.Parse(vag[0]);
            varos = vag[1];
            darab = int.Parse(vag[2]);
        }
    }
}
