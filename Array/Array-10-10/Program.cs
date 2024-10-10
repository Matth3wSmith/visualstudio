namespace Array_10_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bekért számokkal tömb feltöltés
            int tombHossz = 6;
            int[] tomb1 = new int[tombHossz];
            for (int i = 0; i < tombHossz; i++)
            {
                Console.Write("Kérek egy számot:");
                tomb1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Sorszámot is jelenítse meg a tomb kiirasnal
            for (int i=0;i<tomb1.Length;i++)
            {
                Console.Write(Convert.ToString(i) +" "+ Convert.ToString(tomb1[i])+" ");
            }
            //

            Console.WriteLine("\nAdj meg kettő számot!");
            int[] dimenziok= new int[2];
            for (int i = 0; i <2; i++) {
                dimenziok[i]=Convert.ToInt32(Console.ReadLine());
            }
            int szamlalo = 1;
            int[,] dimenzio = new int[dimenziok[0],dimenziok[1]];
            for (int i = 0; i < dimenzio.GetLength(0); i++)
            {
                for(int j = 0; j < dimenzio.GetLength(1); j++)
                {
                    dimenzio[i, j] = szamlalo;
                    szamlalo++;
                    Console.WriteLine(dimenzio[i, j]);
                }

            }
            Console.ReadKey();
        }
    }
}
