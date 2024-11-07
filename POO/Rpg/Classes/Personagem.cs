using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.Classes
{
    public class Personagem
    {
        public string Nome;
        public int Idade;
        public string Aramdura;
        public string Ia;

        public void Atacar () 
        {
            Console.WriteLine($"O {Nome} atacou!");
        }
        public void Defender ()
        {
            Console.WriteLine ($"O {Nome} defendeu");  
        }
        public void Restaurar ()
        {
            Console.WriteLine ($"O {Nome} restaurou a armadura");  
        }
    }
}