using System.ComponentModel.Design;

namespace Elagazasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Blue;
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            if (szam>10)
            {
                Console.WriteLine("A szám tíznél nagyobb!");
            }
            else if (szam<10)
            { 
                Console.WriteLine("A szám tíznél kisebb!");

            }

            if (szam%2==0)
            {
                Console.WriteLine("Páros.");
            }
            else
            {
                Console.WriteLine("Páratlan.");

            }
            //4,5,6 vagy 4,6 vagy 4 oszthatóság
            //Egyik megoldás
            /*if (szam % 4 == 0)
            {
                if (szam % 6 == 0)
                {
                    if (szam % 5 == 0)
                    {
                        Console.WriteLine("Osztható 4-gyel, 5-tel 6-tal is.");
                    }
                    else
                    {
                        Console.WriteLine("Csak 4-gyel, 6-tal osztható.");
                    }
                }
                else
                {
                    Console.WriteLine("Csak 4-gyel osztható.");
                }
            }
            else if (szam % 5 == 0)
            {
                if (szam % 6 == 0) 
                {
                    Console.WriteLine("Csak 5-tel és 6-tal osztható.");
                }
                else
                {
                    Console.WriteLine("Csak 5-tel osztható.");
                }
            }
            else if (szam%6==0)
            {
                Console.WriteLine("Csak 6-tel osztható.");
            */

            //Másik megoldás
            if (szam%4==0 && szam%6==0 && szam % 5 == 0)
            {
                Console.WriteLine("Osztható 4-gyel, 5-tel, 6-tal is.");
            }
        }  
    }
}
