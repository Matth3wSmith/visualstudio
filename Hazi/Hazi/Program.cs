namespace Hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Háromjegyű hárommal osztható számok:
            //1. megoldás
            Console.WriteLine("Háromjegyű hárommal osztható számok:");
            Console.WriteLine("1. megoldás:");
            for (int i = 100; i < 1000; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }

            //2. megoldás
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n2. megoldás:");
            for (int i = 102; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.ResetColor();

            //3. megoldás
            Console.WriteLine("\n3. megoldás:");
            for (int i = 100; i < 1000; i++)
            {
                int osszeg = 0;
                char[] characters = Convert.ToString(i).ToCharArray();
                foreach (char c in characters) 
                {
                    osszeg += Convert.ToInt32(c);
                }
                if (osszeg % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //ABC kiíratása 
            Console.WriteLine("\nABC kiíratása");
            char betu = 'a';
            while (betu != 'z')
            {
                Console.WriteLine(betu);
                betu++;
            }
            Console.WriteLine(betu);

        }
    }
}
