namespace Functions_10_15
{
    internal class Program
    {
        static int osszeadas(int szam1, int szam2)
        {
            return szam1 + szam2;
        }
        static double osszeadas(double szam1, double szam2)
        {
            return szam1 + szam2;
        }

        static double osztas(int szam1, int szam2)
        {
            return szam1 / (double)szam2;
        }
        static double osztas(double szam1, double szam2)
        {
            return szam1 / szam2;
        }
        //a paraméterként kapott egész számokat összeadja és kiírja a végeredményt
        static void osszeadasKiiras(int[] szamok)
        {
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }
            Console.WriteLine(osszeg);
        }

        //10-16
        static string szamNev(int szam)
        {
            string[] nevek = ["nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc"];
            if (szam < 0)
            {
                return "Túl kicsi a szám";
            }
            else if (szam > 9)
            {
                return "Túl nagy a szám";
            }
            else
            {
                return nevek[szam];
            }
        }
        static void szamNevKiir(int szam)
        {
            string[] nevek = ["nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc"];
            if (szam < 0)
            {
                Console.WriteLine("Túl kicsi a szám");
            }
            else if (szam > 9)
            {
                Console.WriteLine("Túl nagy a szám");
            }
            else
            {
                Console.WriteLine(nevek[szam]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(osszeadas(10,56));
            Console.WriteLine(osszeadas(10, 56.66));
            Console.WriteLine("----OSZTÁS---");
            Console.WriteLine(osztas(2,1));
            Console.WriteLine(osztas(2, 2));
            Console.WriteLine(osztas(2, 4));
            Console.WriteLine(osztas(2.5, 1.2));

            //10-16
            //Függvény ami kap egy egyjegyű pozitív számot és visszaadja szövegesen annak a számnak a nevét ha negatív a szám akkor adja vissza hogy túl kicsi ha nagyobb mint 9 akkor túl nagy
            Console.WriteLine(szamNev(5));
            Console.WriteLine(szamNev(-1));
            Console.WriteLine(szamNev(10));

            //Függvény ami a parameterkent kapott egyjegyű pozítiv egész számot kiírja a konzolba
            szamNevKiir(5);
            szamNevKiir(-1);
            szamNevKiir(10);
        }
    }
}
