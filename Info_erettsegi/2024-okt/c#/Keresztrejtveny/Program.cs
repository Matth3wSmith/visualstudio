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


        }
    }
}
