namespace robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<Robot> robotok = new List<Robot>();

            StreamReader olvas = new StreamReader("progs.txt");
            while (!olvas.EndOfStream)
            {
                robotok.Add(new Robot(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine($"2. Feladat: Tanulók száma: {robotok.Count} fő");

            //3. feladat
            int rosszak = 0;
            for (int i = 0; i < robotok.Count; i++)
            {
                if (robotok[i].hibasKarakter)
                {
                    rosszak++;
                    robotok.Remove(robotok[i]);
                }
            }
            Console.WriteLine($"3. Feladat: Helytelen kódsorozatok száma: {rosszak}");

            //4. feladat
            StreamWriter ir = new StreamWriter("ivsz.txt");

            for (int i = 0; i < robotok.Count; i++)
            {
                if (!robotok[i].hibasKarakter){
                    ir.Write($"{robotok[i].nev} {robotok[i].lepesek}\n");
                }
            }


            ir.Close(); 
        }
    }
}
