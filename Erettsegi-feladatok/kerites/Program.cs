namespace kerites
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //1. feladat
            StreamReader olvas = new StreamReader("kerites.txt");
            List<Telek> telkek = new List<Telek>();
            int paratlan = 0;
            int paros = 1;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                Console.WriteLine(sor[0]);
                if (sor[0] == '0')
                {
                    paros++;
                    telkek.Add(new Telek(sor, paros));
                }
                else { 
                    paratlan++;
                    telkek.Add(new Telek(sor, paratlan));

                }
            }


            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az eladott telkek száma: {telkek.Count}");


            //3 .feladat
            Console.WriteLine("3. feladat");
            string oldal = telkek[telkek.Count - 1].paros ? "páros" : "páratlan";
            Console.WriteLine($"A {oldal} oldalon adták el az utolsó telket.");
            Console.WriteLine($"Az utolső telek házszáma: {telkek[telkek.Count-1].hazszam}");
        }
    }
}
