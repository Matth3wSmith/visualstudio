using System.Text.RegularExpressions;

namespace ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("1. feladat");
            List<string> konyv = new List<string>();

            StreamReader olvas = new StreamReader("konyv.txt");

            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                konyv.Add(sor);
                Console.WriteLine(sor);
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.Write("Kérem adja meg az ismétlések számát: ");
            int ismetles = int.Parse(Console.ReadLine());

            for (int i = 0; i < konyv.Count; i++)
            {
                for (int k = 0; k < ismetles; k++)
                {
                    Console.Write(konyv[i] + "\t|");

                }
                Console.WriteLine();
            }
            //4. feladat
            Console.WriteLine("4. feladat");

            StreamReader olvas2 = new StreamReader("szg_t.txt");
            StreamWriter ir = new StreamWriter("szg.txt");
            while (!olvas2.EndOfStream)
            {
                string alakit = atalakit(olvas2.ReadLine());
                ir.WriteLine(alakit);
                Console.WriteLine(alakit);

            }
            ir.Close();
            olvas2.Close();

            //5. feladat
            Console.WriteLine("5. feladat");
            Console.Write("Kérem adja meg a tömörített ábra fájlnevét: ");
            string tomorNev = Console.ReadLine();
            Console.Write("Kérem adja meg a tömörítetlen ábra fájlnevét: ");
            string simaNev = Console.ReadLine();

            string[] tomor = File.ReadAllLines(tomorNev);
            string[] sima= File.ReadAllLines(simaNev);
            int tomorszam = tomor.Select(x => x.Length).Sum();
            int simaSzam = sima.Select(x => x.Length).Sum();
            Console.WriteLine("A karakterek száma a tömörített állományban: "+ tomorszam);
            Console.WriteLine("A karakterek száma a tömörített állományban: "+ simaSzam);
            Console.WriteLine("A tömörítési arány: " + Math.Round(tomorszam / (double)simaSzam,2));

            //6. feladat
            Console.WriteLine("6. feladat");
            Console.WriteLine("az ábra magassága sorokban: "+tomor.Length);

            var maxhossz = tomor
                .Select(delegate(string sor)
                {
                    int hossz = 0;
                    for (int i = 0; i < sor.Length; i += 2)
                    {
                        hossz += int.Parse(sor[i]+"");
                    }
                    return hossz;
                })
                .Max();
            Console.WriteLine("Az ábra szélessége karakterekben: "+ maxhossz);
            Console.WriteLine("A blokkok száma: " + tomor.Select(x => x.Length/2).Sum());






        }

        //3. feladat
        static string atalakit(string sor)
        {
            string kesz = "";
            for (int i = 0; i < sor.Length; i+=2)
            {
                kesz += new string(sor[i + 1], int.Parse(sor[i]+""));
            }
            return kesz;
        }
    }
}
