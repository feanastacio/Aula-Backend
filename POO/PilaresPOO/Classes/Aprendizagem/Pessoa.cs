
namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        // Atributos - características
        // visibilidade tipoDado NomeDaprop
        public string Nome;
        public int Idade;
        public int Cpf;
        public float Peso {get; set;}
        public float Altura {get; set;}

        // Metodos - ações
        // Visibilidade tipoDeDadoRetornado nome (parametros) {corpo}
        // Envelhecer

        public void Envelhecer ()
        {
            Idade++;
        }
        public void Engordar (float _kg) 
        {
            Peso = Peso + _kg;
        }
        public void Emagrecer (float _kg)
        {
            Peso = Peso - _kg;
        }
    }
}