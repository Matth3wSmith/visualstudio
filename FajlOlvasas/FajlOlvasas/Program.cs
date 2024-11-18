namespace FajlOlvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //StreamWriter ir = new StreamWriter("proba.txt");
            /*for (int i = 0; i < 100; i++)
            {
                ir.Write(Convert.ToString(random.Next()) + "\t");
                if (i % 10 == 9)
                {
                    ir.Write("\n");
                }
            }

            ir.Close();*/

            //Házi feladat: "kérjetek be kettő számot, rátok van bízva hogy mekkorát és egy akkora táblázatszerű véletlen számokat tartalmazó dolgot, elválasztó karakter legyenek pontosvessző, fájl kiterjesztése pedig .csv, sor végén ne legyen felesleges pontosvessző"
 

            StreamWriter ir = new StreamWriter("hazi.csv");
            Console.WriteLine("Add meg a táblázat sorainak és oszlopainak számát!");
            int sor = Convert.ToInt32(Console.ReadLine());
            int oszlop = Convert.ToInt32(Console.ReadLine());
            int[] sorokHossza = new int[sor];
            int[,] szamok = new int[sor, oszlop];
            ir.Write("+");
            for (int k = 0; k< oszlop; k++)
            {
                ir.Write("-");
            }
            ir.Write("+\n");
            for (int i = 0; i < sor; i++)
            {
                sorokHossza[i] = oszlop-1;
                for (int j = 0; j < oszlop; j++)
                {
                    szamok[i, j] = random.Next(10, 200);
                    sorokHossza[i] += Convert.ToString(szamok[i, j]).Length;
                    Console.WriteLine(szamok[i, j]);
                    ir.Write(Convert.ToString(szamok[i, j]));
                    if (j % oszlop != 9)
                    {
                        ir.Write(';');
                    }

                }
                ir.Write("\n");

            }
            ir.Close();
            Console.ReadKey();
        }
    }
}
