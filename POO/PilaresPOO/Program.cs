﻿// heraça
// abstração
// encapsulamento
// polimorfismo

using PilaresPOO.Classes.Aprendizagem;

Carro carro = new Carro();
carro.marca = "Honda";
carro.modelo = "Honda cit";
carro.cor = "preto";
carro.potencia = 1.8f;
carro.qtdPassageiros = 3;
carro.qtdPortas = 4;

Moto moto = new Moto();
moto.marca = "Yamaha";
moto.modelo = "Mt";
moto.cor = "roxa";
moto.potencia = 849f;
moto.qtdPassageiros = 2;

Aviao aviao = new Aviao();
aviao.marca = "Airbus";
aviao.modelo = "Airbus X";
aviao.cor = "branca";
aviao.potencia = 165f;
aviao.qtdPassageiros = 65;
aviao.qtdPortas = 2;

// exibir dados

Console.WriteLine(@$"
Veiculo: Carro 
Modelo: {carro.modelo}
Cor: {carro.cor}
Potencia: {carro.potencia}
qtd de passageiros: {carro.qtdPassageiros}
qtd de portas: {carro.qtdPortas}
");
Console.WriteLine($"");

Console.WriteLine(@$"
Veiculo: Moto 
Modelo: {moto.modelo}
Cor: {moto.cor}
Potencia: {moto.potencia}
qtd de passageiros: {moto.qtdPassageiros}
");
Console.WriteLine($"");

Console.WriteLine(@$"
Veiculo: Avião
Modelo: {aviao.modelo}
Cor: {aviao.cor}
Potencia: {aviao.potencia}
qtd de passageiros: {aviao.qtdPassageiros}
qtd de portas: {aviao.qtdPassageiros}
");

// Professor sam = new Professor(11233554);
// sam.Nome = "Samntha";
// sam.Idade = 21;

// Pessoa anna = new Aluno();
// anna.Nome = "Anna";

// Console.WriteLine($"{anna.Nome} Nasceu com {anna.Idade} anos");
// Console.WriteLine();

// Aluno anninhavacilona = new Aluno();
// anninhavacilona.Nome = "Anna";
// anninhavacilona.Idade = 39;
// anninhavacilona.Cpf = 123456789;
// anninhavacilona.Matricula = 000777;
// anninhavacilona.Curso = "Dev";
// anninhavacilona.Media = 5.7f;

// Console.WriteLine($"Curso: {anninhavacilona.Curso}");
// Console.WriteLine($"    Professor: {sam.Nome}");
// Console.WriteLine($"    Identificação do (a) {sam.Nome}: {sam.Nif}");
// Console.WriteLine();

// Console.WriteLine($"    Aluno: {anninhavacilona.Nome}");
// Console.WriteLine($"    Idade do aluno: {anninhavacilona.Idade}");
// Console.WriteLine($"    Cpf do aluno: {anninhavacilona.Cpf}");
// Console.WriteLine($"    Matrícula do aluno: {anninhavacilona.Matricula}");
// Console.WriteLine($"    Média: {anninhavacilona.Media}");
