using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        //2. feladat
        private static List<string> Adatsorok = new List<string>();
        private static char[,] Racs;
        private static int[,] Sorszamok;
        private static int oszlopokDb;
        private static int sorokDb;
        public int OszlopokDb
        {
            get { return oszlopokDb; }
        }
        public int SorokDb
        {
            get { return sorokDb; }
        }
        //3.feladat a.)
        private static void BeolvasAdatsorok(string forras)
        {
            StreamReader ir = new StreamReader(forras);
            while (!ir.EndOfStream)
            {
                Adatsorok.Add(ir.ReadLine().Trim());
            }

        }
        private static void FeltoltRacs()
        {
            for (int i = 0; i < Adatsorok.Count(); i++)
            {
                //Console.WriteLine(Adatsorok[i]);
                for (int k = 0; k < Adatsorok[i].Length; k++)
                {
                    //Console.WriteLine(Adatsorok[i][k]);
                    Racs[i, k] = Adatsorok[i][k];

                }
            }
        }
        //6. feladat
        public void KiRajzol()
        {
            for (int i = 0; i < Racs.GetLength(0); i++)
            {
                for (int k = 0; k < Racs.GetLength(1); k++)
                {
                    if (Racs[i, k] == '-')
                    {
                        Console.Write("[]");
                    }
                    else
                    {
                        Console.Write("##");
                    }
                }
                Console.WriteLine();
            }
        }
        //7. feladat
        public void Fuggoleges()
        {
            int maxFugg = 0;
            for (int i = 0; i < Racs.GetLength(0); i++)
            {
                for (int k = 0; k < Racs.GetLength(1); k++)
                {
                    if (Racs[i, k] == '-')
                    {

                    }
                }
            }
        }
        public KeresztrejtvenyRacs(string forras)
        {
            //3. feladat a.)
            BeolvasAdatsorok(forras);

            //3. feladat b.)
            sorokDb = Adatsorok.Count();
            oszlopokDb = Adatsorok[0].Length ;
            Racs = new char[sorokDb,oszlopokDb];
            Sorszamok = new int[sorokDb, oszlopokDb];

            //3. feladat c.)
            FeltoltRacs();

        }


    }
}
