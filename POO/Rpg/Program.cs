
using Rpg.Classes;

Personagem personagem = new Personagem();

Console.WriteLine($"Qual o nome do seu personagem?");
personagem.Nome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"Qual a idade do seu personagem?");
personagem.Idade = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine($"Qual é a armadura do seu personagem?");
personagem.Aramdura = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"Qual a Inteligência Artificial do do seu personagem?");
personagem.Ia = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"O nome do(a) Personagem é {personagem.Nome}");
Console.WriteLine($"A idade do(a) {personagem.Nome} é {personagem.Idade}");
Console.WriteLine($"A armadura do(a) {personagem.Nome} é {personagem.Aramdura}");
Console.WriteLine($"A Intelegência Artificial do(a) {personagem.Nome} é {personagem.Ia}");
Console.WriteLine();

personagem.Atacar();
personagem.Defender();
personagem.Restaurar();
