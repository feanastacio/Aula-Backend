
using Calculador.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo a Calculadora");
Console.WriteLine();

Calculadora calcular = new Calculadora();

Console.WriteLine($"Digite um número:");
float Num1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite um número:");
float Num2 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"");

Console.WriteLine(@$"Qual operação você gostaria de realizar?
1- Adição
2- Subtração
3- Multiplicação
4- Divisão");
int operacao = int.Parse(Console.ReadLine()!);
Console.WriteLine($"");

if (operacao == 1) {
calcular.Somar(Num1, Num2);
} else if (operacao == 2) {
calcular.Subtrair(Num1, Num2);
} else if (operacao == 3) {
calcular.Multiplicar(Num1, Num2);
} else {
calcular.Dividir(Num1, Num2);
}