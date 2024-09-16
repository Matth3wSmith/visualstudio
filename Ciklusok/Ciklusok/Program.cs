namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Házi feladat -- 09.16");
            Console.ResetColor();
            Console.WriteLine("\n#########################");
            Console.WriteLine("\n1. feladat");
            for (int i = 1; i<=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n#########################");
            Console.WriteLine("\n2.feladat");
            for (int i = 99; i > 9; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n#########################");
            Console.WriteLine("\n3.feladat");
            Console.WriteLine("Adj meg számokat, amik kisebbek mint 10");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());
            while (bekertSzam < 10)
            {
                bekertSzam = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
