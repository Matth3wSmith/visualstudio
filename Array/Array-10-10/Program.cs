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

            for (int i=0;i<tomb1.Length;i++)
            {
                Console.WriteLine(tomb1[i]);
            }

            //Sorszámot is jelenítse meg a tomb kiirasnal
        }
    }
}
