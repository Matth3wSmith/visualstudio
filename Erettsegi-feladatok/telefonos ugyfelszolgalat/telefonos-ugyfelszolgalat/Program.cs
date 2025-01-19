using System.Globalization;

namespace telefonos_ugyfelszolgalat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 .feladat
            StreamReader olvas = new StreamReader("hivas.txt");

            List<Hivas> hivasok = new List<Hivas>();
            while(!olvas.EndOfStream)
            {

                hivasok.Add(new Hivas(olvas.ReadLine()));
            }
            
            olvas.Close();

            //3. feladat
            Dictionary<int,int> oraHivasok = new Dictionary<int,int>();
            for (int i = 0; i < hivasok.Count; i++)
            {
                Hivas egyHivas = hivasok[i];
                if (oraHivasok.ContainsKey(egyHivas.kezdIdo[0]))
                {
                    oraHivasok[egyHivas.kezdIdo[0]]++;
                }
                else
                {
                    oraHivasok[egyHivas.kezdIdo[0]] = 1;
                }
            }
            Console.WriteLine("3. feladat");
            foreach (KeyValuePair<int, int> par in oraHivasok)
            {
                // do something with entry.Value or entry.Key
                
                Console.WriteLine($"{par.Key} ora {par.Value} hivas");
                
            }

            //4. feladat



        }
    }
}
