namespace reklam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<Rendeles> rendelesek= new List<Rendeles>();
            StreamReader olvas = new StreamReader("rendel.txt");



            while (!olvas.EndOfStream)
            {
                rendelesek.Add(new Rendeles(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine("A rendelések száma: "+rendelesek.Count);

            //3. feladat
            Console.WriteLine("3. feladat"); 
            Console.Write("Kérem, adjon meg egy napot: ");
            int nap=int.Parse(Console.ReadLine());
            int rendelesAznap = rendelesek.Where(rendeles => rendeles.nap==nap).Count();
            Console.WriteLine("A rendelések száma az adott napon: "+rendelesAznap);

            //4. feladat
            Console.WriteLine("4. feladat");
            int nincsRendeles = 30-rendelesek.Where(rendeles => rendeles.varos == "NR").Select(rendeles => rendeles.nap).Distinct().Count();
            if (nincsRendeles == 0)
            {
                Console.WriteLine("Minden nap volt rendelés a reklámban nem érintett városból");
            }
            else
            {
                Console.WriteLine(nincsRendeles+" nap nem volt a reklámban nem érintett városból rendelés");
            }

            //5. feladat

        }
    }
}
