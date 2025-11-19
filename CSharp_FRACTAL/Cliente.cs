namespace CSharp_FRACTAL;

public class Cliente
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string email, string telefono)
    {
        Nombre = nombre;
        Email = email;
        Telefono = telefono;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Cliente \n Nombre: {Nombre},\n Correo: {Email},\n Teléfono: {Telefono}");
    }
}