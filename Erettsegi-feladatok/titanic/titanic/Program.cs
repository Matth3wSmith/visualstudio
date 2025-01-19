using System.ComponentModel.Design;

namespace titanic
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1. feladat
            StreamReader olvas = new StreamReader("titanic.txt");
            string[] adatok = olvas.ReadToEnd().Trim().Split("\n");
            Utas[] utasok = new Utas[adatok.Length];
            for (int i = 0; i < utasok.Length; i++)
            {
                utasok[i] = new Utas(adatok[i]);
            }

            olvas.Close();

            //2 .feladat
            Console.WriteLine($"2. feladat: {utasok.Length} db");

            //3. feladat
            int osszUtas = 0;
            for (int i = 0; i < utasok.Length; i++)
            {
                osszUtas += utasok[i].eltunt + utasok[i].tulelo;  
            }
            Console.WriteLine($"3. feladat: {osszUtas} fő");

            //4. feladat
            Console.Write("4. feladat: Kulcsszó: ");
            string kulcsszo = Console.ReadLine();
            string talalatI = "";
            bool vanTalalat = false;
            for (int i = 0; i < utasok.Length; i++) { 

                if (utasok[i].kategoria.Contains(kulcsszo))
                {
                    //Console.WriteLine(utasok[i].kategoria);
                    talalatI += i+" ";
                    vanTalalat = true;
                }
            }
            if (!vanTalalat)
            {
                Console.WriteLine("\tNincs találat!");
            }
            else { 
                Console.WriteLine("\tVan találat!");
            }

            //5.feladat
            Console.WriteLine("5. feladat:");
            if (vanTalalat) 
            {
                string[] talalatokI = talalatI.Split(" ");
                for (int i = 0; i < talalatokI.Length - 1; i++)
                {
                    int m = Convert.ToInt32(talalatokI[i]);
                    Console.WriteLine($"\t{utasok[m].kategoria} {utasok[m].eltunt + utasok[m].tulelo} fő");
                }
            }

            //6. feladat
            Console.WriteLine("6. feladat:");
            for (int i = 0; i < utasok.Length; i++)
            {
                if (utasok[i].arany > 60)
                {
                    Console.WriteLine("\t"+utasok[i].kategoria);
                }
            }


            //7. feladat
            int maxTulelo = 0;
            string maxKategoria = "";
            for (int i = 0; i < utasok.Length; i++)
            {
                if (utasok[i].tulelo > maxTulelo)
                {
                    maxKategoria = utasok[i].kategoria;
                    maxTulelo=utasok[i].tulelo;
                }
            }
            Console.WriteLine("7. feladat: "+ maxKategoria);



            Console.ReadKey();
        }
    }
}
