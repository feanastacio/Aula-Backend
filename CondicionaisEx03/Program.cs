// int lados;

// Console.WriteLine($"Quantos lados iguais tem o triângulo (2, 3 ou 0)?");
// lados = int.Parse(Console.ReadLine()!);

// if(lados == 3) {
//     Console.WriteLine($"Ele é um triângulo Equilátero");
// }else if (lados == 2){
//     Console.WriteLine($"Ele é um triângulo Isócele");
// }else{
//     Console.WriteLine($"Ele é umm  triângulo Escaleno");
// }

Console.WriteLine($"Medida do Primeiro Lado: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Medida do Segundo Lado: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Medida do Terceiro Lado: ");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3) 
{
    Console.WriteLine($"Triângulo Equilátero: possui os 3 lados iguais.");
} 
else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3) 
{
    Console.WriteLine($"Triângulo Escaleno: possui 3 lados diferentes.");
} 
else 
{
    Console.WriteLine($"Triângulo Isóscele: possui 2 lados iguais. ");
}