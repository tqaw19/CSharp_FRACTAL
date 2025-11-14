namespace CSharp_FRACTAL;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto {this.Nombre},  Precio {this.Precio}");
    }
}