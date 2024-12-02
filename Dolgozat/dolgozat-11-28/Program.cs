namespace dolgozat_11_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kódszavak
            StreamReader olvasSzo = new StreamReader("kodszavak_A.txt");
            string[] szavak = olvasSzo.ReadToEnd().Trim().Split("\n");
            for (int i = 0; i < szavak.Length; i++)
            {
                szavak[i]=szavak[i].Trim();
            }
            olvasSzo.Close();

            //Kódszavak kulcsai
            StreamReader olvasKulcs = new StreamReader("kod_A.txt");
            string[] kulcsok = olvasKulcs.ReadToEnd().Trim().Split("\n");
            olvasKulcs.Close();

            string[] szavakSorba = new string[kulcsok.Length];
            string megoldas = "";
            for (int i = 0; i< kulcsok.Length;i++)
            {
                //Console.Write("Index:"+Convert.ToString(i)+" ");
                //Console.Write(Convert.ToString(kulcsok[i])+"\n");
                //Console.WriteLine(szavak[int.Parse(kulcsok[i])]);
                szavakSorba[i]=szavak[int.Parse(kulcsok[i])];
            }
            for (int i = 0; i<szavakSorba.Length; i++)
            {
                if (szavakSorba[i]=="81")
                {
                    szavakSorba[i] = "\n";
                }
                else if (szavakSorba[i] == "42")
                {
                    szavakSorba[i] = ",";
                }
                else if (szavakSorba[i] == "66")
                {
                    szavakSorba[i] = "!";
                }
                megoldas += szavakSorba[i] + " ";
                
            }
            megoldas=megoldas.Replace(" !", "!");
            megoldas = megoldas.Replace(" ,", ",");
            megoldas = megoldas.Replace("\n ", "\n");


            Console.WriteLine(megoldas);
            StreamWriter ir = new StreamWriter("megoldas.txt");
            ir.Write(megoldas);
            ir.Close();
        }
    }
}
