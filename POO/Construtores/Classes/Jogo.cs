using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string? Nome { get; set; }
        public int Lancamento { get; set; }
        public string Genero { get; set; }
        public float Preco { get; set; }
    public Jogo (string? n, int l, string g, float p )
    {
        Nome = n;
        Lancamento = l;
        Genero = g;
        Preco = p;
    }
    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Nome: {Nome}
        Lancamento: {Lancamento}
        Genero: {Genero}
        Preco: R${Preco}
        ");
    }
    }
}