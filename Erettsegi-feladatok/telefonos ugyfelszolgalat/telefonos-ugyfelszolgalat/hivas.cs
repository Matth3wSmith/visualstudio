using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonos_ugyfelszolgalat
{
    internal class Hivas
    {
        public int[] kezdIdo = new int[3];
        public int[] vegIdo = new int[3];

        public Hivas(string sor) {
            //sor értéke: "7 57 36 7 59 59"

            string[] vag = sor.Split(" ");

            kezdIdo[0]=int.Parse(vag[0]);
            kezdIdo[1] = int.Parse(vag[1]);
            kezdIdo[2] = int.Parse(vag[2]);
            vegIdo[0] = int.Parse(vag[3]);
            vegIdo[1] = int.Parse(vag[4]);
            vegIdo[2] = int.Parse(vag[5]);
        }
        //1. feladat
        public int mpbe(int o, int p, int mp)
        {
            return o * 60 * 60 + p * 60 + mp;
        }
    }
}