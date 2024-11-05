
using Calculador.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo a Calculadora");
Console.WriteLine();

Calculadora calcular = new Calculadora();

Console.WriteLine($"Digite um número:");
calcular.Num1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite um número:");
calcular.Num2 = float.Parse(Console.ReadLine()!);

Calculadora.Somar(Num1, Num2);