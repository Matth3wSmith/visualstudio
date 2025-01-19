using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class Robot
    {
        public string nev;
        public string kod;
        public bool hibasKarakter;
        public int iranyvaltas = 0;
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
            lepesek();


        }

        private void lepesek()
        {
            char elozo = this.kod[0];
            for (int i = 1; i < this.kod.Length; i++)
            {
                if (this.kod[i] != elozo)
                {
                    this.iranyvaltas++;
                    elozo = this.kod[i];
                }
            }
        }
        public double tavolsag()
        {
            int y = 0;
            int x = 0;
            for (int i = 0; i < this.kod.Length; i++)
            {
                if (this.kod[i] == 'E'){
                    x++;
                }
                else if (this.kod[i] == 'H')
                {
                    x--;
                }
                else if (this.kod[i] == 'J')
                {
                    y++;
                }
                else if (this.kod[i] == 'B')
                {
                    y--;
                }
            }

            return Math.Sqrt(Math.Pow(-x, 2) + Math.Pow( -y,2));

        }




    }
}
