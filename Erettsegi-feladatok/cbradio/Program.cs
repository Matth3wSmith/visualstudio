namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] adatok = File.ReadAllLines("cb.txt");

            //[[ora,perc],[ora,perc]...]
            int[,] idok = new int[adatok.Length-1, 2];
            int[] adasok = new int[adatok.Length-1];
            string[] nevek = new string[adatok.Length-1];

            //2. feladat
            for (int i = 0; i < adatok.Length-1; i++)
            {
                string[] vag = adatok[i+1].Split(";");
                idok[i,0] = int.Parse(vag[0]);
                idok[i,1] = int.Parse(vag[1]);
                adasok[i] = int.Parse(vag[2]);
                nevek[i] = vag[3];

                Console.WriteLine(nevek[i]);
            }

            //3. feladat
            Console.WriteLine($"3. feladat: Bejegyzések száma: {adatok.Length} db");

            //4. feladat
            Console.Write("4. feladat: ");
            bool adas4DB = false;
            for (int i = 0; i < adasok.Length; i++)
            {
                if (adasok[i] == 4)
                {
                    adas4DB = true;
                    break;
                }
            }
            if (adas4DB)
            {
                Console.WriteLine("Volt négy adást indító sofőr.");
            }
            else
            {
                Console.WriteLine("Nem volt négy adást indító sofőr.");
            }

            //5. feladat
            Console.Write("5. feladat: Kérek egy nevet: ");
            string sofor = Convert.ToString(Console.ReadLine());
            int soforHivasa = 0;
            if (!nevek.Contains(sofor))
            {
                Console.WriteLine("\tNincs ilyen nevű sofőr!");
            }
            else
            {
                for (int i = 0; i < adasok.Length; i++)
                {
                    if (nevek[i] == sofor)
                    {
                        soforHivasa += adasok[i];
                    }
                }
                Console.WriteLine($"\t{sofor} {soforHivasa}x használta a CB-rádiót.");
            }

            //7.feladat
            StreamWriter ir = new StreamWriter("cb2.txt");
            ir.WriteLine("Kezdes;Nev;AdasDb");

            for (int i = 0; i < nevek.Length; i++)
            {
                int ido = AtszamloPercre(idok[i, 0], idok[i, 1]);
                ir.WriteLine($"{ido};{nevek[i]};{adasok[i]}");
            }


            ir.Close();

            //8. feladat

            Console.ReadKey();
        }

        //6. feladat
        static int AtszamloPercre(int ora, int perc)
        {
            return ora * 60 + perc;
        }
    }
}
