// See https://aka.ms/new-console-template for more information

namespace CSharp_FRACTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = new string[3];
            frutas[0] = "Manzana";
            frutas[1] = "Banana";
            frutas[2] = "Naranja";

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            var frutasList = new List<string> { "Manzana", "Banana", "Naranja" };
            foreach (string fruta in frutasList)
            {
                Console.WriteLine(fruta);
            }

            Dictionary<string, int> frutasDict = new Dictionary<string, int>();
            frutasDict.Add("Manzana", 1);
            frutasDict.Add("Banana", 2);
            frutasDict.Add("Naranja", 3);
            frutasDict.Add("Pina", 3);

            foreach (var fruta in frutasDict)
            {
                Console.WriteLine($"Fruta: {fruta.Key} - {fruta.Value}");
            }
        }
    }
}