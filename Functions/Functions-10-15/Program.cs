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
        static void Main(string[] args)
        {
            Console.WriteLine(osszeadas(10,56));
            Console.WriteLine(osszeadas(10, 56.66));
            Console.WriteLine("----OSZTÁS---");
            Console.WriteLine(osztas(2,1));
            Console.WriteLine(osztas(2, 2));
            Console.WriteLine(osztas(2, 4));
            Console.WriteLine(osztas(2.5, 1.2));


        }
    }
}
