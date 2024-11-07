
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
            Console.WriteLine($"O {Nome} atacou o inimigo!");
        }
        public void Defender ()
        {
            Console.WriteLine ($"O {Nome} defendeu o golpe inimigo!");  
        }
        public void Restaurar ()
        {
            Console.WriteLine ($"O {Nome} restaurou a armadura!");  
        }
    }
}