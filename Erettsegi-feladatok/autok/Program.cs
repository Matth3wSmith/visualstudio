using System.Runtime.InteropServices;

namespace autok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            StreamReader olvas = new StreamReader("jeladas.txt");
            List<Auto> autok = new List<Auto>();

            while (!olvas.EndOfStream)
            {
                autok.Add(new Auto(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az utolsó jeladás időpontja {autok[autok.Count-1].ido}, a jármű rendszáma {autok[autok.Count - 1].rendszam} ");

            //3. feladat
            Auto elsoJarmu = autok[0];
            Console.WriteLine("3. feladat");
            Console.WriteLine($"Az első jármű: {elsoJarmu.rendszam}");
            Console.Write("Jeladásainak időpontjai: ");
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].rendszam == elsoJarmu.rendszam){
                    Console.Write($"{autok[i].ido} ");
                }
            }
            Console.WriteLine();

            //4. feladat
            Console.WriteLine("4. feladat");
            Console.Write("Kérem adja meg az órát: ");
            int ora = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a percet: ");
            int perc = int.Parse(Console.ReadLine());
            string ido = $"{ora}:{perc}";
            int adasokSzama = 0;

            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].ido == ido)
                {
                    adasokSzama++;
                }
            }
            Console.WriteLine($"A jeladások száma: {adasokSzama}");

            //5. feladat

            int maxSebesseg = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].sebesseg>maxSebesseg)
                {
                    maxSebesseg=autok[i].sebesseg;
                }
                
            }
            Console.WriteLine($"A legnagyobb sebesség km/h: {maxSebesseg}");
            Console.Write("A járművek: ");
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].sebesseg==maxSebesseg)
                {
                    Console.Write(autok[i].rendszam+" ");
                }
            }

            //6. feladat
            Console.WriteLine("6. feladat");
            Console.Write("Kérem, adja meg a rendszámot: ");
            string rendszam = Console.ReadLine();
            for (int i = 0; i < autok.Count; i++)
            {

            }


        }
    }
}
