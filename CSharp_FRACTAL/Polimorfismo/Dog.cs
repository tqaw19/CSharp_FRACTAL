namespace CSharp_FRACTAL;

public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Woof...");
    }
}