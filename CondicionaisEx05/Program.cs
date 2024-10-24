float macapreco1 = 0.30f;
float macapreco2 = 0.25f;
int qntd;

Console.WriteLine($"Quantas maçãs você irá comprar?");
qntd = int.Parse(Console.ReadLine()!);

if(qntd < 12) {
    float ValorTotal = qntd * macapreco1;
    Console.WriteLine($"O valor a pagar por {qntd} maçãs é R${ValorTotal}");
} else {
    float TotalValor = qntd * macapreco2;
    Console.WriteLine($"O valor a pagar por {qntd} maçãs é R${TotalValor}");
}

