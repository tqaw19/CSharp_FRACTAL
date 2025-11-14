namespace CSharp_FRACTAL;

public class Funciones
{
    public int Cuadrado(int numbero)
    {
        return numbero * numbero;
    }

    public void Intercambio(ref int a, ref int b)
    {
        int Temp = a;
        a = b;
        b = Temp;
    }

    public int Sumar(int x, int y)
    {
        return x + y;
    }

    public void GreaterNumber(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine($"{a} is greater than {b}");
        }

        if (b > a)
        {
            Console.WriteLine($"{b} is greater than {a}");
        }

        if (a == b)
            Console.WriteLine($"{a} and {b} are equals");
    }

    public void CalculateSalary(double salary)
    {
        var newSalary = salary + (salary * 0.1);
        Console.WriteLine($"Your salary is {newSalary}");
    }
}