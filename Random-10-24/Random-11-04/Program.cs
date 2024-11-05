namespace Random_11_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //függvény ami valamennyi 3 jegyű páros számot generál

            double kiirni=randomMegadottSzam(5,6);
            Console.WriteLine(kiirni);
            Console.ReadKey();
            
        }
        static Random rand = new Random();

        //1db háromjegyű páros számot generál
        static int randomHaromjegyu()
        {

            return rand.Next(50, 500)*2; 
        }

        //Megadott számú háromjegyű páros számot generál
        static int[] randomSzamok(int db)
        {
            int[] szamok = new int[db];

            for (int i = 0; i<db; i++)
            {
                szamok[i] = randomHaromjegyu();
            }

            return szamok;
        }

        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++) {
                Console.WriteLine(tomb[i]);
            }
        }

        //adott számjegyű számokat és adott számmla soztható számot generál
        static int randomMegadottSzam(int szamjegy, int oszthato)
        {
            return rand.Next(((int)Math.Pow(10,(szamjegy-1)))/oszthato, ((int)Math.Pow(10,szamjegy))/oszthato) * oszthato;
        }
    }
}
