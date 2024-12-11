using System.Runtime.InteropServices;

namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. feladat
            KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");
            //5. feladat
            Console.WriteLine("5. feladat: A keresztrejtvény mérete");
            Console.WriteLine($"\tSorok száma: {racs.SorokDb}");
            Console.WriteLine($"\tOszlopok száma: {racs.OszlopokDb}");
            //6. feladat
            Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
            racs.KiRajzol();
            //7. feladat
            int fugg = racs.Fuggoleges();
            Console.WriteLine($"7. feladat: A leghosszabb függ.: {fugg} karakter");

            //8. feladat
            Console.WriteLine("8. feladat: Vízszintes szavak statisztikája");
            Dictionary<int,int> vizszintes = racs.Vizszint();
            foreach (KeyValuePair<int, int> par in vizszintes)
            {
                if (par.Value != 0) { 
                    Console.WriteLine($"{par.Key} betűs: {par.Value} darab");
                }
            }
            //9. feladat
            racs.Sorszamozas();
            racs.SorszamKiir();

            Console.ReadKey();

        }
    }
}
