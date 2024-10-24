Console.WriteLine($"Qual seu salário?");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual foi seu gasto?");
float gasto = float.Parse(Console.ReadLine()!);

if (salario >= gasto) {
    Console.WriteLine($"Gasto dentro do orçamento");
} else {
    Console.WriteLine($"Orçamento estourado");
}
