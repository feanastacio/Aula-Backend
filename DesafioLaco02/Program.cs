int homens = 0;
int mulheres = 0;
int idadeHomem = 0;
int idadeMulher = 0;

for(int i = 1; i <=4; i++)
{
    Console.WriteLine($"Você é homem ou mulher? m/f");
    string genero = Console.ReadLine();
    
    Console.WriteLine($"Qual sua idade?");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (genero == "m")
    {
        homens ++;
        idadeHomem+=idade;
    }
    else 
    {
        mulheres ++;
        idadeMulher+=idade;
    }
}
float mediaHomem = (idadeHomem / homens);
float mediaMulher = (idadeMulher / mulheres);


Console.WriteLine($"Total de homens {homens}");
Console.WriteLine($"Total de Mulheres {mulheres}");
Console.WriteLine($"Media de idade dos homens {mediaHomem}");
Console.WriteLine($"Media de idade das mulheres {mediaMulher}");
