using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] adatok = File.ReadAllLines("cb.txt");

            //[[ora,perc],[ora,perc]...]
            int[,] idok = new int[adatok.Length-1, 2];
            int[] adasok = new int[adatok.Length-1];
            string[] nevek = new string[adatok.Length-1];

            //2. feladat
            for (int i = 0; i < adatok.Length-1; i++)
            {
                string[] vag = adatok[i+1].Split(";");
                idok[i,0] = int.Parse(vag[0]);
                idok[i,1] = int.Parse(vag[1]);
                adasok[i] = int.Parse(vag[2]);
                nevek[i] = vag[3];

            }

            //3. feladat
            Console.WriteLine($"3. feladat: Bejegyzések száma: {adatok.Length} db");

            //4. feladat
            Console.Write("4. feladat: ");
            bool adas4DB = false;
            for (int i = 0; i < adasok.Length; i++)
            {
                if (adasok[i] == 4)
                {
                    adas4DB = true;
                    break;
                }
            }
            //Másik megoldás
            adas4DB=false;
            for (int i = 0; i < adasok.Length && !adas4DB; i++)
            {
                //Ha egyszer igaz lesz akkor igaz marad mindvégig
                adas4DB |= adasok[i]==4;
            }

            if (adas4DB)
            {
                Console.WriteLine("Volt négy adást indító sofőr.");
            }
            else
            {
                Console.WriteLine("Nem volt négy adást indító sofőr.");
            }

            //5. feladat
            Console.Write("5. feladat: Kérek egy nevet: ");
            string sofor = Console.ReadLine();
            int soforHivasa = 0;
            if (!nevek.Contains(sofor))
            {
                Console.WriteLine("\tNincs ilyen nevű sofőr!");
            }
            else
            {
                for (int i = 0; i < adasok.Length; i++)
                {
                    if (nevek[i] == sofor)
                    {
                        soforHivasa += adasok[i];
                    }
                }
                Console.WriteLine($"\t{sofor} {soforHivasa}x használta a CB-rádiót.");
            }

            //7.feladat
            StreamWriter ir = new StreamWriter("cb2.txt");
            ir.WriteLine("Kezdes;Nev;AdasDb");

            for (int i = 0; i < nevek.Length; i++)
            {
                int ido = AtszamloPercre(idok[i, 0], idok[i, 1]);
                ir.WriteLine($"{ido};{nevek[i]};{adasok[i]}");
            }


            ir.Close();

            //8. feladat
            string becenev= nevek[0];
            for (int i = 0; i < nevek.Length; i++)
            {
                if (!becenev.Contains(nevek[i]))
                {
                    becenev += ","+nevek[i];
                }
            }
            string[] becenevek = becenev.Split(",");
            Console.WriteLine($"8. feladat: Sofőrök száma: {becenevek.Length} fő");

            //9. feladat
            int[] maxAdasok = new int[becenevek.Length];

            for (int i = 0; i < becenevek.Length; i++)
            {
                maxAdasok[i] = 0;
                for (int j = 0; j < nevek.Length; j++)
                {
                    if (nevek[j] == becenevek[i])
                    {
                        maxAdasok[i] += adasok[j];
                    }
                }
            }
            int legtobbAdas=0;
            string legtobbAdasNev="";

            for (int i = 0; i < maxAdasok.Length; i++)
            {
                if (legtobbAdas < maxAdasok[i])
                {
                    legtobbAdas = maxAdasok[i];
                    legtobbAdasNev = becenevek[i];
                }
            }
            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            Console.WriteLine($"\tNév: {legtobbAdasNev}");
            Console.WriteLine($"\tAdások száma: {legtobbAdas} alkalom");
        }

        //6. feladat
        static int AtszamloPercre(int ora, int perc)
        {
            return ora * 60 + perc;
        }
    }
}
