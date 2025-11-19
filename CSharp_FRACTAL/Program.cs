// See https://aka.ms/new-console-template for more information

namespace CSharp_FRACTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            /*Funciones funciones = new Funciones();
            funciones.GreaterNumber(4, 10);
            funciones.GreaterNumber(10, 10);
            funciones.CalculateSalary(5000);

            Producto producto = new Producto("Papas", 5000);
            Producto producto2 = new Producto("Cebolla", 8000);
            List<Producto> products = new List<Producto>
            {
                new Producto("Papas", 5000),
                new Producto("Cebolla", 5000)
            };
            foreach (var item in products)
            {
                item.MostrarInfo();
            }

            producto.MostrarInfo();
            producto2.MostrarInfo();*/

            /*Cliente cliente = new Cliente("Randall", "randal.p@gmail.com", "987234456");
            cliente.MostrarInfo();*/

            /*Empleado empleado = new Empleado("Randall Jr", "Project Manager", 6000);
            Console.WriteLine(empleado.Sueldo);
            empleado.CalcularBono(0.2);*/

            /*Producto producto3 = new Producto("papas", 5, 100);
            producto3.MostrarInfo();
            producto3.ActualizarStock(-2);*/

            List<Producto> productList = new List<Producto>
            {
                new("papas", 5 , 100),
                new("arroz", 10 , 80),
                new("cebolla", 4 , 50),
            };

            foreach (Producto producto in productList)
            {
                producto.MostrarInfo();
            }
        }
    }
}