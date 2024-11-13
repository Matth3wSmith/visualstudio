namespace SzamSorozat_11_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-10-ig számok kiírása

            //1. megoldás
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            //2. megoldás
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine(j);
                j++;
            }

            //4. megoldás
            int k = 1;
            Console.WriteLine("4. megoldás");
            Console.WriteLine(negyedikMegoldas(k));

            //5. megoldás
            Console.WriteLine("5. megoldás");
            int[] novekvo= new int[10];
            novekvo[0] = 1;
            int szamlalo = 0;
            while (novekvo[9]!=10)
            {
                int szam=rand.Next(11);
                if (szam - 1 == novekvo[szamlalo])
                {
                    Console.WriteLine(novekvo[szamlalo]);
                    szamlalo++;
                    novekvo[szamlalo]=szam;
                }
            }
            Console.WriteLine(novekvo[9]);
        }
        //4.megoldás
        static Random rand = new Random();
        static int negyedikMegoldas(int k)
        {
            if (k < 10)
            {
                Console.WriteLine(k);
                return negyedikMegoldas(++k);
            }
            else
            {
                return k;
            }
        }
    }
}
