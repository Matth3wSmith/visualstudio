using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace kraterek
{
    internal class Krater
    {
        public double x;
        public double y;
        public double r;
        public string nev;

        public Krater(string sor)
        {
            string[] vag = sor.Split('\t');

            x = double.Parse(vag[0]);
            y = double.Parse(vag[1]);
            r = double.Parse(vag[2]);
            nev = vag[3];

        }

    }
}
