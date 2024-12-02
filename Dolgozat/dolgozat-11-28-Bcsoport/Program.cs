namespace dolgozat_11_28_Bcsoport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = File.ReadAllLines("kod_B.txt");
            string kulcsSzo = szavak[0] + "\n\r";
            StreamWriter ir = new StreamWriter("megoldas.txt");
            for (int i = 1; i < szavak.Length; i++)
            {
                ir.Write(kulcsSzo[Convert.ToInt32(szavak[i])]);
            }
            ir.Close();

            szavak = File.ReadAllLines("kodszavak_A.txt");.
            string[] kodok = File.ReadAllLines("kod_A.txt");
            string megoldas = "";

            for (int i = 0; i < kodok.Length; i++)
            {
                megoldas += (szavak[Convert.ToInt32(kodok[i])] + " ");
            }
            megoldas = megoldas.Replace(" 66", "!").Replace(" 81 ", "\n").Replace(" 42", ",");
            Console.WriteLine(megoldas);
            ir = new StreamWriter("megoldasA.txt");
            ir.Write(megoldas);
            ir.Close();

        }

    }
}
