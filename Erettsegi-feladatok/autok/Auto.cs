using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Auto
    {
        public string rendszam;
        public int ora;
        public int perc;
        public int sebesseg;
        public string ido;
        public int percben;
        public Auto(string sor)
        {
            string[] adatok = sor.Split();
            this.rendszam = adatok[0];
            this.ora = int.Parse(adatok[1]);
            this.perc = int.Parse(adatok[2]);
            this.sebesseg = int.Parse(adatok[3]);
            this.ido = $"{this.ora}:{this.perc}";
            this.percben = this.ora * 60 + perc;
            
        }

    }
}
