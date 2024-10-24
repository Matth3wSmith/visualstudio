namespace Random_10_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Számkitaláló játék:
            //                  - gép választ egy számot
            //                  - addig találgatunk amíg nincs kész
            //                  - gép segítséget ad hogy kisebb vagy nagyobb
            //                  - lépéseket is írja ki
            // v.2
            //játékos gondol egy számra
            //  - fordítottja mint az első

            Random random = new Random();
            int felsoHatar = 452;
            int alsoHatar = 0;
            int gondoltSzam = random.Next(alsoHatar, felsoHatar);
            int lepes = 0;
            Console.WriteLine("Gondoltam egy számra...");
            Console.WriteLine("Mire tippelsz?");
            int tipp = Convert.ToInt32(Console.ReadLine());
            if (tipp == gondoltSzam)
            {
                Console.WriteLine("Gratulálok eltaláltad!");
                Console.WriteLine("Tippeid száma:"+Convert.ToString(lepes));
            }
            else if (tipp > gondoltSzam)
            {
                Console.WriteLine("A tippelt szám kisebb!");
                lepes++;
            }
            else if (tipp < gondoltSzam) {
                Console.WriteLine("A tippelt szám nagyobb!");
                lepes++;
            }
        }
    }
}
