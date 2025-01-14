using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class Robot
    {
        public string nev;
        public string kod;
        public bool hibasKarakter;
        public Robot(string sor)
        {
            string[] vag = sor.Split(" ");
            nev= vag[0];
            kod = vag[1];

            //3. feladat
            string kodcsere = kod.Replace("E", "");
            kodcsere = kodcsere.Replace("B", "");
            kodcsere = kodcsere.Replace("J", "");
            kodcsere = kodcsere.Replace("H", "");
            hibasKarakter = kodcsere != "";



        }



    }
}
