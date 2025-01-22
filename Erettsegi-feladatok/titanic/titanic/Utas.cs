using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace titanic
{
    internal class Utas
    {
        public string kategoria;
        public int tulelo;
        public int eltunt;
        public int arany;

        public Utas(string sor)
        {
            //"ferfiak-masodosztaly;14;154" 
            string[] vag = sor.Split(";");

            kategoria= vag[0];
            tulelo = int.Parse(vag[1]);
            eltunt = int.Parse(vag[2]);
            arany = eltunt/tulelo*100;
            
        }

    }
}
