namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Contas
    {

    public int LimiteSaque { get; set; }
    public int Rendimento { get; set; }
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