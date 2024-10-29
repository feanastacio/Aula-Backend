
int [] numeros = new int [6];
int par = 0;
int impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
   Console.WriteLine($"Digite um {i + 1} número:");
   int numeroDigitado = int.Parse(Console.ReadLine()!);

    if (numeroDigitado %2 == 0)
    {
        par++;
    } else {
        impar++;
    }
}

Console.WriteLine($"Quantidades de números pares: {par}");
Console.WriteLine($"Quantidades de números ímpares: {impar}");
