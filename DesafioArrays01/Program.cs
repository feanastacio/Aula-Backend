
int[] numeros = new int[6];
int par = 0;
int impar = 0;
int NumeroDigitado;

for (int i = 0; i < numeros.Length; i++)
{

    Console.WriteLine($"Digite o {i + 1}ª número:");
    NumeroDigitado = int.Parse(Console.ReadLine()!);
    numeros[i] = NumeroDigitado;

    if (NumeroDigitado % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
}

Console.Clear();
Console.WriteLine($" {par} número (s) par(es)");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros [i] % 2 == 0)
    {
        Console.Write($"{numeros [i]} ");
    }
}

Console.WriteLine($"");

Console.WriteLine($" {impar} número (s) impar(es)");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 1)
    {
         Console.Write($"{numeros [i]} ");
    }
}
