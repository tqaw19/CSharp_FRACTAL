// See https://aka.ms/new-console-template for more information

namespace CSharp_FRACTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var g = new Gerente("Luis", 5000, 1500);
            g.MostrarInfo();*/

            Console.WriteLine("------Animals------");
            var animals = new List<Animal>
            {
                new Cat(),
                new Dog(),
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}