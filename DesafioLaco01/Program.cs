
int qnthomem = 0;
int qntmulher = 0;
int sim = 0;
int nao = 0;
int msim = 0;
int mnao = 0;
int hsim = 0;
int hnao = 0;

for( int i = 1; i <= 10; i++) {
    Console.WriteLine($"Você gostou do produto? sim/nao");
    string produto = Console.ReadLine();

    if (produto == "sim") {
        sim++;
    } else {
        nao++;
    }

    Console.WriteLine($"Qual seu gênero? f/m");
    string genero = Console.ReadLine();

    if (genero == "f")
    {
        qntmulher++;
    } else {
        qnthomem++;
    }  

    if (genero == "f" && produto == "sim")
    {
        msim++;
    }
    else  if (genero == "f" && produto == "nao")  {
        mnao++;
    } else if (genero == "m" && produto == "nao") {
        hnao++;
    } else {
       hsim++; 
    }
}

int total = (qnthomem + qntmulher);
float percentualhomemnao = (100/ total) * hnao;

Console.WriteLine($"Pessoas que não gostaram do produto: {nao}");
Console.WriteLine($"Pessoas que gostaram do produto: {sim}");
Console.WriteLine($"Mulheres que gostaram do produto: {msim}");
Console.WriteLine($"Porcentagem de homens que não gostaram do produto: {percentualhomemnao}%");
