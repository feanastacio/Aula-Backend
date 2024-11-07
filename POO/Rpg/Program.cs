
using Rpg.Classes;

Console.Clear();
Console.WriteLine($"*** Seja Bem vindo ao RPG ***");
Console.WriteLine();

Personagem personagem = new Personagem();

Console.Write($"Qual o nome do seu personagem? ");
personagem.Nome = Console.ReadLine()!;
Console.WriteLine();

Console.Write($"Qual a idade do seu personagem? ");
personagem.Idade = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write($"Qual é a armadura do seu personagem? ");
personagem.Aramdura = Console.ReadLine()!;
Console.WriteLine();

Console.Write($"Qual a Inteligência Artificial utilizada pelo seu personagem? ");
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
Console.WriteLine();
