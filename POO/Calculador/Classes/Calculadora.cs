
namespace Calculador.Classes
{
    public class Calculadora
    {
        public float Num1;
        public float Num2;
        public float Result;
    

    public void Somar(float Num1, float Num2)
    {
        Result = Num1 + Num2;
        Console.WriteLine($"O resultado é {Result}");
        
    }

    public void Subtrair (float Num1, float Num2)
    {
        Result = Num1 - Num2;
        Console.WriteLine($"O resultado é {Result}");
    }
    public void Multiplicar (float Num1, float Num2)
    {
        Result = Num1 * Num2;
        Console.WriteLine($"O resultado é {Result}");
    }
    public void Dividir (float Num1, float Num2)
    {
        Result = Num1 / Num2;
        Console.WriteLine($"O resultado é {Result}");
    }

    }
}