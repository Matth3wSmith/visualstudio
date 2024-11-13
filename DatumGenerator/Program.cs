namespace DatumGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2. feladat
            string[] honapok = ["január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"];
            //3.feladat
            int[] honapokNapja = [31,28,31,30,31,30,31,31,30,31,30,31];

            //Console.WriteLine(Evszam()+" "+DatumGeneralas(honapok,honapokNapja));

            //6.feladat
            Console.WriteLine("Adj meg egy számot 10 és 100 között! ([10,100])");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());
            while (bekertSzam < 10 || bekertSzam > 100)
            {
                Console.WriteLine("A megadott szám nem 10 és 100 között van. Adj meg másikat!");
                bekertSzam = Convert.ToInt32(Console.ReadLine());
            }

            //7.feladat
            string[] generaltDatumok=new string[bekertSzam];
            for (int i = 0; i < bekertSzam; i++)
            {
                generaltDatumok[i] = Evszam() + " " + DatumGeneralas(honapok,honapokNapja);
                Console.WriteLine(generaltDatumok[i]);
            }
            //Console.WriteLine(generaltDatumok.Length);
        }
        static Random random = new Random();
        //4.feladat
        static string DatumGeneralas(string[] honapok, int[] napok)
        {
            int honapIndex = random.Next(0, 12);
            string honap = honapok[honapIndex];
            int nap= random.Next(1,napok[honapIndex] +1);
            string datum= String.Format("{0} {1}.",honap,nap);
            return datum;
        }
        //5.feladat
        static string Evszam()
        {
            return Convert.ToString(random.Next(1924,2025))+".";
        }
    }
}
