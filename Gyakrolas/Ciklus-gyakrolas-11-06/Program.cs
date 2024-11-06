namespace Ciklus_gyakrolas_11_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] szamok = new int[3];

            Console.WriteLine("Adj meg egy számot, hogy mettől sorsoljon, hogy meddig sorsoljon és mennyit sorsoljon!");
            for (int i = 0; i < 3; i++) { 
                szamok[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Format("Megadott számaid:"));
            Console.WriteLine(string.Format("Mettől: {0} Meddig: {1} Mennyi: {2}", szamok[0], szamok[1], szamok[2]));
            int[] sorsolt=new int[szamok[2]];
            int szamlalo = 0;
            Console.WriteLine("Sorsolt számok:");
            while (szamlalo != szamok[2])
            {
                int akt = rand.Next(szamok[0], szamok[1]);
                if (!sorsolt.Contains(akt))
                {
                    sorsolt[szamlalo] = akt;
                    Console.WriteLine(string.Format("{0}. sorsolt szám: {1}",szamlalo+1,akt));
                }
                szamlalo++;
            }
        }
    }
}
