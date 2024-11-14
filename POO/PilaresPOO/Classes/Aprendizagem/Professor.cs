
namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa //Herança
    {
        public int Nif { get; set; }
        public float Salario { get; set;}
        public Professor (int _nif) 
        { 
            Nif = _nif; 
        }
    }

}