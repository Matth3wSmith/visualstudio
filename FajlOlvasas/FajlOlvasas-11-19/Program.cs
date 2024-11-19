using System.Threading.Channels;

namespace FajlOlvasas_11_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FajlbaIr();
            KepernyoreIr();
            KepernyoreIr2();    
        }
        static Random random = new Random();
        static void FajlbaIr()
        {
            Console.WriteLine("Adj meg kettő számot!");
            Console.Write("Sorok száma: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oszlopok száma: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());

            StreamWriter ir = new StreamWriter("tablazat.csv");

            //Sorok fájlba írása
            for (int k = 0; k < sor; k++)
            {

                //Egy sor fájlba írása
                for (int i = 0; i < oszlop; i++)
                {
                    ir.Write(random.Next(100, 1000));
                    if (i != oszlop - 1)
                    {
                        ir.Write(";");
                    }
                }
                //Sor vége
                ir.WriteLine();
            }
            ir.Close();
        }
        static void KepernyoreIr()
        {
            StreamReader olvas = new StreamReader("tablazat.csv");
            Console.WriteLine("A táblázat tartalma:");
            Console.WriteLine(olvas.ReadToEnd());

            olvas.Close();
        }
        static void KepernyoreIr2()
        {
            StreamReader olvas = new StreamReader("tablazat.csv");
            Console.WriteLine("A táblázat tartalma:");
            string sor="";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                Console.WriteLine(sor);
            }

            olvas.Close();
        }
        //Hf: Kétféle képpen még kiíratni
        static void KepernyoreIr3()
        {
            StreamReader olvas = new StreamReader("tablazat.csv");
            Console.WriteLine("A táblázat tartalma:");
            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                Console.WriteLine(sor);
            }

            olvas.Close();
        }
    }

}
