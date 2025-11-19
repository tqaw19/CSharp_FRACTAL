namespace CSharp_FRACTAL;

public class Producto
{
    private static int _IdCounter = 0;
    public int Id { get; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }

    public Producto(string nombre, double precio, int stock)
    {
        Id = ++_IdCounter;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public void ActualizarStock(int cantidad)
    {
        if (Stock + cantidad < 0)
        {
            Stock = 0;
        }
        else
        {
            Stock += cantidad;
        }

        Console.WriteLine($"Stock para {Nombre} = {Stock}");
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto {Id}: \nNombre = {this.Nombre}, \nPrecio = {this.Precio}");
    }
}