// See https://aka.ms/new-console-template for more information

namespace CSharp_FRACTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}