
namespace PilaresPOO.Classes.Aprendizagem

{
    public abstract class Veiculo
    {
        public string marca;
        public string modelo;
        public string cor;
        public float potencia;
        public int qtdPassageiros;

        public void Ligar()
        {
            Console.WriteLine($" {modelo} esta ligando");
        }
        public void Desligar()
        {
            Console.WriteLine($" {modelo} esta desligado");
        }
        public void Buzinar()
        {
            Console.WriteLine($"{modelo} esta buzinando!");
            Console.WriteLine($"bibi bibi biiiiiii");
        }
    }
}
