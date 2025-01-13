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
            Console.WriteLine("\n6. feladat");
            Console.Write("Kérem, adja meg a rendszámot: ");
            string rendszam = Console.ReadLine();
            double ut = 0.0;
            int elozoIdo = 0;
            bool elso = true;
            int elozoSebesseg = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].rendszam == rendszam)
                {
                        
                    //Console.WriteLine("elozo {0} mostani {1} eltelt {2} sebesseg {3}", elozoIdo, autok[i].percben, (autok[i].percben - elozoIdo), autok[i].sebesseg);
                    if (elso)
                    {
                        Console.WriteLine($"{autok[i].ido} {ut} km");
                        elozoIdo = autok[i].percben;
                        elozoSebesseg = autok[i].sebesseg;
                        elso = false;
                    }
                    else
                    {
                        ut += ((autok[i].percben - elozoIdo) / 60.0 * elozoSebesseg);
                        elozoSebesseg = autok[i].sebesseg;
                        elozoIdo = autok[i].percben;
                        Console.WriteLine($"{autok[i].ido} {Math.Round(ut,1)} km");
                    }


                }
            }

            //7. feladat
            Dictionary<string,List<string>> rendszamSzerint = new Dictionary<string,List<string>>();

            for (int i = 0; i < autok.Count; i++)
            {
                if (rendszamSzerint.ContainsKey(autok[i].rendszam))
                {
                    rendszamSzerint[autok[i].rendszam].Add($"{autok[i].ora} {autok[i].perc}");
                }
                else
                {
                    rendszamSzerint.Add(autok[i].rendszam, new List<string>{$"{autok[i].ora} {autok[i].perc}"});
                }
            }
            StreamWriter ir = new StreamWriter("ido.txt");
            foreach (KeyValuePair<string, List<string>> entry in rendszamSzerint)
            {
                ir.WriteLine($"{entry.Key} {entry.Value[0]} {entry.Value[entry.Value.Count-1]}");
            }
            ir.Close();

        }
    }
}
