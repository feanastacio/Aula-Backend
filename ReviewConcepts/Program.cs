using System.Data;

Console.WriteLine(@"
                    +--------------------------------------------+
                    |               Bem vindo (a),               |
                    |      coloque suas informações abaixo:      |
                    +--------------------------------------------+
");

Console.WriteLine($"Olá digite seu nome:");
string nome = Console.ReadLine()!;

Console.WriteLine($"Olá {nome}, digite seu sobrenome:");
string sobrenome = Console.ReadLine()!;

Console.WriteLine($"Digite sua data de nascimento (Apenas números sem '/'): ");
int dataNascimento = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Olá digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Olá digite seu cpf: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Olá digite seu endereço: ");
string endereço = Console.ReadLine()!;

Console.WriteLine($"Olá digite seu estado civil: ");
string estcivil = Console.ReadLine()!;

Console.WriteLine($"Em que ano você nasceu?");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

Console.Clear();
Console.WriteLine(@$" ---------- CADASTRO CONCLUIDO ----------
 Nome: {nome} {sobrenome}
 Data de nascimento: {dataNascimento} 
 Idade: {idade}
 Contato: {telefone} 
 CPF: {cpf} 
 Endereço: {endereço} 
 Estado Civil: {estcivil}
 ---------- Obrigado pelo cadastro ;) ----------");
