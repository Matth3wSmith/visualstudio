using System.Runtime.CompilerServices;

namespace Valtozo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int egeszSzam = 3;
            float lebegoPontos;
            double d1, d2;
            
            Console.WriteLine(egeszSzam+10);
            egeszSzam += 10;
            egeszSzam /= 5;
            Console.WriteLine(egeszSzam);


            lebegoPontos = 12;
            lebegoPontos /= 5;
            Console.WriteLine("Lebegő "+lebegoPontos);

            d1 = 1;
            d2 = 2;
            d1 *= 1.1;
            Console.WriteLine(d1);

            decimal decimalis = 12;
            Console.WriteLine(decimalis);

            string szo = "Kekcske káposzta";
            Console.WriteLine(szo);
            char karakter = 'a';
            karakter++;
            Console.WriteLine(karakter);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("HELLO");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadKey();
        }
    }
}
