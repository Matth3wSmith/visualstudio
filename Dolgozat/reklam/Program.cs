using System.Collections.Generic;

namespace reklam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<Rendeles> rendelesek= new List<Rendeles>();
            StreamReader olvas = new StreamReader("rendel.txt");



            while (!olvas.EndOfStream)
            {
                rendelesek.Add(new Rendeles(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine("A rendelések száma: "+rendelesek.Count);

            //3. feladat
            Console.WriteLine("3. feladat"); 
            Console.Write("Kérem, adjon meg egy napot: ");
            int nap=int.Parse(Console.ReadLine());
            int rendelesAznap = rendelesek.Where(rendeles => rendeles.nap==nap).Count();
            Console.WriteLine("A rendelések száma az adott napon: "+rendelesAznap);

            //4. feladat
            Console.WriteLine("4. feladat");
            int nincsRendeles = 30-rendelesek.Where(rendeles => rendeles.varos == "NR").Select(rendeles => rendeles.nap).Distinct().Count();
            if (nincsRendeles == 0)
            {
                Console.WriteLine("Minden nap volt rendelés a reklámban nem érintett városból");
            }
            else
            {
                Console.WriteLine(nincsRendeles+" nap nem volt a reklámban nem érintett városból rendelés");
            }

            //5. feladat
            Console.WriteLine("5. feladat");
            IEnumerable<int> darabok = rendelesek.Select(rendeles => rendeles.darab);
            int maxDarab = darabok.Max();
            int maxNap = rendelesek.Where(rendeles => rendeles.darab==maxDarab).Select(rendeles => rendeles.nap).First();

            Console.WriteLine("A legnagyobb darabszám: "+maxDarab+", a rendelés napja: "+maxNap);

            //7. feladat
            Console.WriteLine("7. feladat");
            IEnumerable<string> varosok = rendelesek.Select(rendeles => rendeles.varos).Distinct();

            IEnumerable<string> rendeles21 = varosok.Select(varos => varos+": "+(osszes(varos, 21, rendelesek)));
            Console.WriteLine("A rendelt termékek darabszáma a 21. napon "+String.Join(" ",rendeles21));

            //8. feladat
            Dictionary<string, int[]> osszesites = new Dictionary<string, int[]>();
            foreach (string varos in varosok)
            {
                osszesites.Add(varos, [0,0,0]);
            }
            for (int i = 0; i < rendelesek.Count(); i++)
            {
                if (rendelesek[i].nap >= 1 && rendelesek[i].nap <= 10)
                {
                    osszesites[rendelesek[i].varos][0]++;
                }
                else if (rendelesek[i].nap >= 11 && rendelesek[i].nap <= 20)
                {
                    osszesites[rendelesek[i].varos][1]++;

                }
                else if (rendelesek[i].nap >= 21 && rendelesek[i].nap <= 30)
                {
                    osszesites[rendelesek[i].varos][2]++;

                }

            }

            StreamWriter ir = new StreamWriter("kampany.txt");
            ir.WriteLine("Napok\t1..10\t11..20\t21..30");
            Console.WriteLine("Napok\t1..10\t11..20\t21..30");
            foreach (KeyValuePair<string, int[]> entry in osszesites)
            {
                string sor = entry.Key + "\t" + String.Join("\t", entry.Value);
                ir.WriteLine(sor);
                Console.WriteLine(sor);
            }

            ir.Close();
        }

        //6. feladat
        static int osszes(string varos, int nap, List<Rendeles> rendelesek)
        {
            return rendelesek.Where(rendeles => rendeles.varos == varos && rendeles.nap == nap).Select(rendeles => rendeles.darab).Sum();
        }
    }
}


