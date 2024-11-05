
using ClasseObjeto.Classes;
// using System.Net.Http.Headers;

Console.Clear();
Console.WriteLine($"** Bem Vindo(a) ao programa ZooSharp **");
Console.WriteLine($"");

Animal cachorro =  new Animal();

cachorro.nome = "Tom";
cachorro.raca = "Vira-Lata";
cachorro.cor = "Preto e Branco";
cachorro.idade = 1;

Console.WriteLine($"Nome do meu cachorro: {cachorro.nome}.");
Console.WriteLine($"Raça do {cachorro.nome}: {cachorro.raca}.");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}.");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade} ano(s).");

Animal cavalo = new Animal();

cavalo.nome = "Maximus";
cavalo.raca = "Frísio";
cavalo.cor = "Preto";
cavalo.idade = 2;

Console.WriteLine($"");

Console.WriteLine($"Nome do meu cavalo: {cavalo.nome}.");
Console.WriteLine($"Raça do {cavalo.nome}: {cavalo.raca}.");
Console.WriteLine($"Cor do {cavalo.nome}: {cavalo.cor}.");
Console.WriteLine($"Idade do {cavalo.nome}: {cavalo.idade} ano(s).");

Console.WriteLine($"");

cachorro.Envelhecer();
Console.WriteLine($"A idade do(a) {cachorro.nome} envelhecida é {cachorro.idade} ");
cavalo.Envelhecer();
Console.WriteLine($"A idade do(a) {cavalo.nome} envelhecida é {cavalo.idade} ");
Console.WriteLine($"");

cachorro.FazerBarulho("AuAu");
cavalo.FazerBarulho("Pocotó Pocotó");

