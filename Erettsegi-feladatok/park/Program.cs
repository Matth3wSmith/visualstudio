using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace park
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            StreamReader olvas = new StreamReader("felajanlas.txt");
            int viragAgyasSzam = int.Parse(olvas.ReadLine());
            List<Virag> viragok = new List<Virag>();    
            while (!olvas.EndOfStream)
            {
                viragok.Add(new Virag(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine("A felajánlások száma: "+viragok.Count);
            Console.WriteLine();
            //3. feladat
            List<int> ketoldalt = new List<int>();

            for (int i = 0; i < viragok.Count; i++)
            {
                if (viragok[i].kezdo > viragok[i].veg)
                {
                    ketoldalt.Add(i+1);
                }
            }

            Console.WriteLine("3. feladat");
            Console.WriteLine("A bejárat mindkét oldalán ültetők: "+ String.Join(" ", ketoldalt.Select(x => x.ToString()).ToArray()));
            Console.WriteLine();

            //4. feladat
            Console.WriteLine("4. feladat");
            Console.Write("Adja meg az ágyás sorszámát! ");
            int agyasSzam = int.Parse(Console.ReadLine());
            List<char> agyasUltetesek = new List<char>();
            for (int i = 0; i < viragok.Count; i++)
            {
                if (viragok[i].kezdo<=agyasSzam && viragok[i].veg >= agyasSzam)
                {
                    agyasUltetesek.Add(viragok[i].szin);
                }
            }

            List<char> szinek =  agyasUltetesek.Distinct().ToList();

            if (agyasUltetesek.Count == 0)
            {
                Console.WriteLine("Ezt az ágyást nem ültetik be.");
            }
            else
            {
                Console.WriteLine("A felajánlók száma: "+agyasUltetesek.Count);
                Console.WriteLine("A virágágyás színe, ha csak az első ültet: " + agyasUltetesek[0]);
                Console.WriteLine("A virágágyás színei: "+ String.Join(" ", szinek));

            }
            Console.WriteLine();

            //5. feladat
            int beultetniAgyas = 0;
            List<int> agyasok= new List<int>();
            for (int i = 0; i < viragAgyasSzam; i++)
            {
                agyasok.Add(0);
            }
            for (int i = 0; i < viragok.Count; i++)
            {
                if (viragok[i].kezdo < viragok[i].veg)
                {
                    for (int k = viragok[i].kezdo-1; k < viragok[i].veg-1; k++)
                    {
                        agyasok[k] = 1;
                    }
                    beultetniAgyas += viragok[i].beultetni;
                }
                else
                {
                    for (int k = viragok[i].kezdo - 1; k < viragAgyasSzam-1; k++)
                    {
                        agyasok[k] = 1;
                    }
                    for (int k = 0; k < viragok[i].veg - 1; k++)
                    {
                        agyasok[k] = 1;
                    }

                    beultetniAgyas += viragok[i].beultetni;

                }
            }
            Console.WriteLine("5. feladat");
            if (String.Join("", agyasok).Replace("0","").Length == viragAgyasSzam)
            {
                Console.WriteLine("Minden ágyás beültetésére van jelentkező.");
            }
            else if (beultetniAgyas>=viragAgyasSzam)
            {
                Console.WriteLine("Átszervezéssel megoldható a beültetés.");
            }
            else
            {
                Console.WriteLine("A beültetés nem oldható meg.");
            }
            Console.WriteLine();

            //6. feladat
            Dictionary < int,List<string>> ultetesek = new Dictionary<int,List<string>>();
            for (int i = 1; i < viragAgyasSzam + 1; i++)
            {
                ultetesek.Add(i, new List<string>());
            }


            for (int i = 0; i < viragok.Count; i++)
            {
                if (!viragok[i].kapu)
                {
                    for (int k = viragok[i].kezdo; k < viragok[i].veg+1; k++)
                    {
                        ultetesek[k].Add(viragok[i].szin+"");
                        ultetesek[k].Add(i+1 + "");

                    }
                }
                else
                {

                    for (int k = viragok[i].kezdo; k < viragAgyasSzam+1; k++)
                    {
                        ultetesek[k].Add(viragok[i].szin + "");
                        ultetesek[k].Add(i+1 + ""); ;
                    }
                    for (int t = 1; t < viragok[i].veg+1; t++)
                    {
                        ultetesek[t].Add(viragok[i].szin + "");
                        ultetesek[t].Add(i+1 + "");
                    }
                }
            }
            //szinek.txt-be írás
            StreamWriter ir = new StreamWriter("szinek.txt");

            foreach (KeyValuePair<int,List<string>> entry in ultetesek)
            {
                if (entry.Value.Count == 0)
                {
                    ir.WriteLine("# 0");
                }
                else
                {
                    ir.WriteLine(entry.Value[0] + " " + entry.Value[1]);
                }
            }

            ir.Close();

        }
    }
}
