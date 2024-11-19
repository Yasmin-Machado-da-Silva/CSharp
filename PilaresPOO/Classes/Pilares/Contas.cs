using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Contas
    {
        protected float Saldo { get; set; }
        public string? Titular { get; set; }

        public abstract float Sacar (float valor);
        public abstract bool Depositar (float valor);

        public float getSaldo ()
        {
            return Saldo;
        }	

        public void BotaSaldoAi(float grana){
            Saldo = grana;
        }
        // public float DevolveSaldoAi(){
        //     return Saldo;
        // }
    }
}