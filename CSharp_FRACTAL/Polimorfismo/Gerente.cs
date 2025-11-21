namespace CSharp_FRACTAL;

public class Gerente : Empleado
{
    public double Bono { get; set; }

    public Gerente(string nombre, double salario, double bono) : base(nombre, salario)
    {
        Bono = bono;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Gerente: {Nombre}, Salario: {Sueldo}, Bono: {Bono}");
    }
}