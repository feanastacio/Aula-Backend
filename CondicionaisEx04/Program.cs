int senha;

Console.WriteLine($"Digite a senha de validade");
senha = int.Parse(Console.ReadLine()!);

if (senha == 1234){
    Console.WriteLine($"Acesso Permitido");
} else {
    Console.WriteLine($"Acesso Negado");
}
