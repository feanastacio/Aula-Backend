
namespace PilaresPOO.Classes.Pilares

{
    public class ContaPoupanca : Conta
    {
    public int limiteSaque { get; set; }
    public float Rendimento { get; set; }

    public override bool Depositar(float valor)
    {
        throw new NotImplementedException();
    }

    public override float Sacar(float valor)
    {
        throw new NotImplementedException();
    }
    }
}