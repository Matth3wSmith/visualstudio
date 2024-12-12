using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonos_ugyfelszolgalat
{
    internal class hivas
    {
        public int[] kezdIdo = new int[3];
        public int[] vegIdo = new int[3];

        public hivas(string sor) {
            //sor értéke: "7 57 36 7 59 59"

            string[] vag = sor.Split(" ");

            for (int i = 0; i < vag.Length; i++)
            {
                if (i < 3)
                {
                    kezdIdo[i] = Convert.ToInt32(vag[i]);
                }
                else
                {
                    vegIdo[3 - i] = Convert.ToInt32(vag[i]);
                }
            }
        }
        public int idoSecKezd()
        {
            return kezdIdo[0] * 60 * 60 + kezdIdo[1] * 60 + kezdIdo[2];
        }
        public int idoSecVeg()
        {
            return vegIdo[0] * 60 * 60 + vegIdo[1] * 60 + vegIdo[2];
        }
    }
}