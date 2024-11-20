namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("cb.txt");

            int[,] idok = new int[adatok.Length-1,2];
            int[] adasok = new int[adatok.Length-1];
            string[] nevek = new string[adatok.Length-1];

            for (int i = 1; i < adatok.Length; i++)
            {
                string[] vag = adatok[i].Split(";");
                idok[i-1,0]=int.Parse(vag[0]);
                idok[i,1]=int.Parse(vag[1]);


            }

        }
    }
}
