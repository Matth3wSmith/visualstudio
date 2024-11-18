namespace FajlOlvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();   
            StreamWriter ir = new StreamWriter("proba.txt");
            for (int i = 0; i < 100; i++)
            {
                ir.Write(Convert.ToString(random.Next()) + "\t");
                if (i % 10 == 9)
                {
                    ir.Write("\n");
                }
            }

            ir.Close();

            //Házi feladat: "kérjetek be kettő számot, rátok van bízva hogy mekkorát és egy akkora táblázatszerű véletlen számokat tartalmazó dolgot, elválasztó karakter legyenek pontosvessző, fájl kiterjesztése pedig .csv, sor végén ne legyen felesleges pontosvessző"
        }
    }
}
