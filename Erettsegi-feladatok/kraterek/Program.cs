using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace kraterek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            string[] adatok = File.ReadAllLines("felszin_tvesszo.txt");

            List<Krater> kraterek = new List<Krater>();
            
            for (int i = 0; i < adatok.Length; i++)
            {
                kraterek.Add(new Krater(adatok[i]));
            }

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A kráterek száma: {kraterek.Count}");

            //3. feladat
            Console.WriteLine("3. feladat");
            Console.Write("Kérem egy kráter nevét: ");
            string bekertNev = Console.ReadLine();
            Krater talaltNevek = kraterek.Aggregate(0,(c, next) => next.nev == bekertNev ? next : c);

            Console.WriteLine($"A(z) {talaltNevek.nev} középpontja X={talaltNevek.x} Y={talaltNevek.y} sugara R={talaltNevek.r}.");
        }
    }
}
