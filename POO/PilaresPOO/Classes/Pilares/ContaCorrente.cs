
namespace PilaresPOO.Classes.Pilares

{
    public class ContaCorrente : Conta
    {
    private float limite { get; set; }

    public bool Tranferir (float valor, Conta contadestino)
    {
        return false;
    }
    public override bool Depositar(float valor)
    {
        if (valor <= 0)
        {
        Saldo = Saldo + valor;
        return true;
        } else
        {
            return false;
        }
            
        }
    public override float Sacar(float valor)
    {
        if (valor >= Saldo)
        {
            Saldo = Saldo - valor; 
            return valor;
        }
        else
        {
            Console.WriteLine($"Valor menor que o saldo");
            return 0;
        }
    }
    }
}