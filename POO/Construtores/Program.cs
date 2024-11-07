
using Construtores.Classes;

Console.WriteLine($"*** Bem Vindo ao Programa de Jogos ***");

int opcao;
string gamelist;

do
{
Console.WriteLine(@$"
----- Menu de Opções -----

  1 - Cadastras Jogos
  2 - Listar Jogos
  3 - Sair
--------------------------
");

Console.WriteLine($"Qual opção você gostaria?");
opcao = int.Parse(Console.ReadLine()!);

if (opcao == 1)
{
    Console.WriteLine($"Qual o nome do jogo?");
    String Nome = Console.ReadLine()!;
    Console.WriteLine($"Qual o genêro do jogo?");
    String Genero = Console.ReadLine()!;
    Console.WriteLine($"Qual o lançamento do jogo?");
    int Lancamento = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Qual o valor do jogo?");
    float Preco = float.Parse(Console.ReadLine()!);

} else if (opcao == 2)
{
    
}

} while (opcao != 0);

// List<Jogo> jogoslist = new List<Jogo>();
// Jogo jogo1 = new Jogo("Lego Batman", 2008, "Ação e aventura", 169.35f);
// jogo1.ExibirDados();
// Jogo jogo2 = new Jogo("Lego Batman 2", 2012, "Ação e aventura", 36.00f);
// jogo2.ExibirDados();
// Jogo jogo3 = new Jogo("Lego Batman 3", 2014, "Ação e aventura", 100.00f);
// jogo3.ExibirDados();
// Jogo jogo4 = new Jogo("Lego Marvel Vingadores", 2016, "Ação e aventura", 180.00f);
// jogo4.ExibirDados();

// jogoslist.Add(jogo1);
// jogoslist.Add(jogo2);
// jogoslist.Add(jogo3);
// jogoslist.Add(jogo4);

// foreach (var jogo in jogoslist)
// {
//     jogo.ExibirDados();
//     // jogo1.ExibirDados();
//     // jogo2.ExibirDados();
//     // jogo3.ExibirDados();
//     // jogo4.ExibirDados();
// }

// // carro1.Marca = "Ford";
// // carro1.Modelo = "Ka";
// // carro1.Ano = 2017;
// // carro1.Cor = "Vermelho";

// // carro2.Marca = "Ford";
// // carro2.Modelo = "Mustang";
// // carro2.Ano = 1967;
// // carro2.Cor = "Vermelho";

// // carro1.ExibirDados();
// // carro2.ExibirDados();
// // aluno.ExibirDados();

// // Veiculo carro1 = new Veiculo("Ford", "Ka", 2017, "Vermelho");
// // Veiculo carro2 = new Veiculo("Ford", "Mustang", 1967, "Vermelho");
// // Aluno aluno = new Aluno("Fernanda", 16, 1578664);
// // Jogo jogo = new Jogo("Lego Batman", 23/09/2008, "Ação e aventura", 169.35f);
