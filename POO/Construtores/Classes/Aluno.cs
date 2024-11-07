
namespace Construtores.Classes

{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Matricula { get; set; }

        public Aluno (string n, int i, int m) {
            Nome = n;  
            Idade = i;
            Matricula = m;
        }
        public void ExibirDados() 
        {
        Console.WriteLine(@$"
        Nome: {Nome}
        Idade: {Idade}
        Matricula: {Matricula}"
        );
        }
    }
}