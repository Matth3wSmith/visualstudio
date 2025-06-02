using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    internal class Idezet
    {
        public string szerzo;
        public string idezet;
        public int idezetHossz;
        public Idezet(string idezet)
        {
            string[] vag = idezet.Split(";");
            this.szerzo = vag[0];
            this.idezet = vag[1];
            this.idezetHossz = this.idezet.Split("   ").Length;

        }
     }
}
