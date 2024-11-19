namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Contas
    {
        public float Limite { get; set; }

        public bool Transferir (float valor, Contas contaDestino){
            return false;
        }
        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                return true;
            }else
            {
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                
                return valor;
            }else
            {
                Console.WriteLine($"Valor menor que o saldo");
                
                return 0;
            }
        }
    }
}