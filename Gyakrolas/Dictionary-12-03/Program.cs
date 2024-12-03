namespace Dictionary_12_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dict = new Dictionary<string,string>();

            dict.Add("Ádám","Cigány");
            dict.Add("Zolika","Vroom-Vroom");
            dict.Add("Bazsi", "PHP SQL kiráj!");

            Console.WriteLine(dict["Ádám"]);
        }
    }
}
