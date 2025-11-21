namespace CSharp_FRACTAL;

public class Empleado
{
    // Nombre, Cargo, Sueldo, CalcularBono(double porcentaje)
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public double Sueldo { get; private set; }

    public Empleado(string nombre, double sueldo)
    {
        Nombre = nombre;
        //  Cargo = cargo;
        Sueldo = sueldo;
    }

    public void CalcularBono(double porcentaje)
    {
        var bono = Sueldo * porcentaje;
        Console.WriteLine($"Su bono es de {bono}");
        Console.WriteLine($"Sueldo Final {Sueldo + bono}");
    }
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Empleado: {Nombre}, Sueldo: {Sueldo}");
    }
}