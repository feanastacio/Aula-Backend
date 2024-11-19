
using PilaresPOO.Classes.Pilares;

ContaCorrente ctFeh = new ContaCorrente();
ctFeh.Titular = "Fernanda Marques Anastácio";
ctFeh.Depositar (100000000000f);

Console.WriteLine($"Titular da Conta: {ctFeh.Titular}");
Console.WriteLine($"Saldo da Conta: R${ctFeh.getSaldo()}");

float valorSacado = ctFeh.Sacar (1200f);

Console.WriteLine($"Valor do Saque: {valorSacado}");
Console.WriteLine($"Novo Saldo: {ctFeh.getSaldo()}");