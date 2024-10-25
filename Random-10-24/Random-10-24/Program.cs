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
            Console.WriteLine("Válassz egy játémódot:");
            Console.WriteLine("1: Gondoltam egy számra...");
            Console.WriteLine("2: Gondolj egy számra...");
            int jatekMod = Convert.ToInt32(Console.ReadLine());

            if (jatekMod==1) { 
                int felsoHatar = 452;
                int alsoHatar = 0;
                int gondoltSzam = random.Next(alsoHatar, felsoHatar);
                int lepes = 0;
                Console.WriteLine("Gondoltam egy számra...");
                Console.WriteLine("Mire tippelsz?");
                int tipp = Convert.ToInt32(Console.ReadLine());
                while (tipp != gondoltSzam) {
                    if (tipp > gondoltSzam)
                    {
                        Console.WriteLine("A tippelt szám kisebb!");
                        lepes++;
                    }
                    else if (tipp < gondoltSzam) {
                        Console.WriteLine("A tippelt szám nagyobb!");
                        lepes++;
                    }
                    Console.WriteLine("Mire tippelsz?");
                    tipp = Convert.ToInt32(Console.ReadLine());
                }

                if (tipp == gondoltSzam)
                {
                    Console.WriteLine("##############################################");
                    Console.WriteLine("Gratulálok eltaláltad!");
                    Console.WriteLine("Tippeid száma:" + Convert.ToString(lepes));
                }
            }
            else if (jatekMod == 2)
            {
                Console.WriteLine("Gondolj egy számra!");

                Console.WriteLine("Add meg a felső határt:");
                int felsoHatar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add meg az alsó határt:");
                int alsoHatar = Convert.ToInt32(Console.ReadLine());

                int lepes = 1;
                double ujAlsoHatar = alsoHatar;
                double ujFelsoHatar = felsoHatar;

                double tipp = (felsoHatar+alsoHatar)/2;
                Console.WriteLine("A gép tippe:"+Convert.ToString(tipp));
                Console.WriteLine("Helyes a tipp? Ha nem, akkor kisebb vagy nagyobb mint a gondolt szám? (igen/kisebb/nagyobb)");
                string valasz = Console.ReadLine();

                //Bináris kereséssel
                while (valasz != "igen")
                {
                    if (valasz == "nagyobb")
                    {
                        ujAlsoHatar = tipp;
                    }
                    else if (valasz == "kisebb")
                    {
                        ujFelsoHatar = tipp;
                    }
                    tipp = Math.Round((ujFelsoHatar+ujAlsoHatar)/2);
                    Console.WriteLine("Helyes a tipp? Ha nem, akkor kisebb vagy nagyobb mint a gondolt szám? (igen/kisebb/nagyobb)");
                    Console.WriteLine("A gép tippe:" + Convert.ToString(tipp));
                    valasz = Console.ReadLine();
                    lepes++;
                }
                if (valasz == "igen")
                {
                    Console.WriteLine("A gép sikeresen kitalálta!");
                    Console.WriteLine("Tippek száma:" + Convert.ToString(lepes));

                }
            }
        }
    }
}
