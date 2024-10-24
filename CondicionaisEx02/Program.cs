
int golstime1;
int golstime2;

Console.WriteLine($"Qual é o primeiro time?");
string time1 = Console.ReadLine();

Console.WriteLine($"Qual é o segundo time?");
string time2 = Console.ReadLine();

Console.WriteLine($"Quantos gols o {time1} fez?");
golstime1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols o {time2} fez?");
golstime2 = int.Parse(Console.ReadLine()!);

if(golstime1 > golstime2) {
    Console.WriteLine($"O {time1} ganhou");
} else if (golstime2 > golstime1) {
    Console.WriteLine($"O {time2} ganhou");
} else {
    Console.WriteLine($"Deu empate");
}

