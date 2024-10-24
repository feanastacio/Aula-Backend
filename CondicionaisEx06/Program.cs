Console.Clear();

float media = 7;
float frequencia = 78;

if(frequencia >= 75  && media >= 7) {
    Console.WriteLine($"Aluno Aprovado");
}else if (media > 3 && media < 7 && frequencia < 75) {
    Console.WriteLine($"Aluno ficou de Recuperação");
}else {
    Console.WriteLine($"Aluno Reprovado");
}