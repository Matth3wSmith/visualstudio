namespace _09_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("For ciklussal való kiíratás:");
            for (int i=1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

            int k = 1;
            Console.WriteLine("\nWhile ciklussal való kiíratás:");
            while (k<=10) {
                Console.WriteLine(k);
                k++;
            }

            for (int i = 10; i>0;i--)
            {
                Console.WriteLine(i);
            }
            
            for (int i=10;i>0;i--)
            {
                Console.WriteLine(11 - i);
            }

            for (int i =1; i<=10;i++)
            {
                Console.WriteLine(11-i);
            }*/

            //
            Console.WriteLine("Adj meg egy számot:");
            int prim = Convert.ToInt32(Console.ReadLine());
            int oszto = 2;
            Console.WriteLine("A szám prímtényezőkre bontva:");
            while (prim > 1)
            {
                if (prim % oszto == 0)
                {
                    Console.WriteLine(oszto);
                    prim /= oszto;
                }
                else 
                {
                    oszto++;
                }
            }

        }

    }
}
