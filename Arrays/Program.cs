
string carro1;
string carro2;
string carro3;
string [] carros = new string [3];

for (int i = 0; i < 3; i++)
{
Console.WriteLine($"Digite o nome do carro para ser cadastrado");
carros [i] = Console.ReadLine();
}

// Console.WriteLine($"Digite o nome do carro para ser cadastrado");
// carros [1] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro para ser cadastrado");
// carros [2] = Console.ReadLine();

Console.WriteLine($"O carro cadastrado é {carros[0]}, {carros[1]}, {carros[2]}");
