
int qntdmulher = 0;
int qntdhomem = 0;
int gostamdeesportes = 0;
int naogostamdeesporte = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qntddeentrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qntddeentrevistados; i++) 
{
 Console.WriteLine($"Qual seu genêro f/m ?");
 string sexo = Console.ReadLine()!;

 if (sexo == "f") {
    qntdmulher++;
 }else {
    qntdhomem++;
 }
}

for (int i = 1; i <= qntddeentrevistados; i++) {

 Console.WriteLine($"Você gosta de esportes sim/não ?");
 string esportes = Console.ReadLine()!;

 if (esportes == "sim") {
    gostamdeesportes++;
 } else {
    naogostamdeesporte++;
 }
}

float percentual = (100/ qntddeentrevistados) * gostamdeesportes;

Console.WriteLine($"Quantidade de Mulheres: {qntdmulher}");
Console.WriteLine($"Quantidade de Homens: {qntdhomem}");
Console.WriteLine($"QUantidade de pessoas que gostam de esportes: {gostamdeesportes}");
Console.WriteLine($"QUantidade de pessoas que não gostam de esportes: {naogostamdeesporte}");
Console.WriteLine($"Total de entrevistados: {qntddeentrevistados}");
