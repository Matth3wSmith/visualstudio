using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    internal class Virag
    {
        public int kezdo;
        public int veg;
        public char szin;
        public int beultetni;
        public bool kapu;

        public Virag(string sor) {

            string[] vag = sor.Split();

            kezdo = int.Parse(vag[0]);
            veg = int.Parse(vag[1]);
            szin = Convert.ToChar(vag[2]);
            beultetni = Math.Abs(veg - kezdo + 1);
            kapu = this.kezdo > this.veg;


        }
    }
}
