using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utemez
{
    internal class Tabor
    {
        /*Az első két számpár a tábor első és utolsó napjának
        dátuma.A számpárok első értéke a hónap, a második a nap sorszáma.*/
        public int kezdHonap;
        public int kezdNap;
        public int utolsoHonap;
        public int utolsoNap;
        public string diakok;
        public string tema;
        public int diakSzam;
        public string datum;

        public Tabor(string sor)
        {
            string[] vag = sor.Split('\t');

            kezdHonap = int.Parse(vag[0]);
            kezdNap = int.Parse(vag[1]);
            utolsoHonap = int.Parse(vag[2]);
            utolsoNap = int.Parse(vag[3]);
            diakok = vag[4];
            tema = vag[5];
            diakSzam = this.diakok.Length;
            datum = $"{this.kezdHonap}.{this.kezdNap}-{this.utolsoHonap}.{this.utolsoNap}.";

         }


    }
}
