namespace List_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            Console.WriteLine(lista.Capacity);
            Console.WriteLine(lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
            lista.Insert(3,111);
            
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("\n"+lista.IndexOf(111));
        }
    }
}
