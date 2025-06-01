using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek_wpf
{
    internal class Konyv
    {
        public int ev;
        public int negyedEv;
        public string eredet;
        public string leiras;
        public int peldany;
        public Konyv(int ev, int negyedEv, string eredet, string leiras, int peldany) 
        { 
            this.ev = ev;
            this.negyedEv = negyedEv;
            this.eredet = eredet;
            this.leiras = leiras;
            this.peldany = peldany;

        
        }
    }
}
