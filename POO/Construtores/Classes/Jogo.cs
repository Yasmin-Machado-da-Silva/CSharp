using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Contrutores 
{
    public class Jogo
    {
        public string Nome { get; set; }
        public int Lancamento { get; set; } 
        public string Genero { get; set; }  
        public float Preco { get; set; }   

        public Jogo (string nome, int lancamento, string genero, float preco){
            Nome = nome;
            Lancamento = lancamento;
            Genero = genero;
            Preco = preco;
        } 
        public void ExibirDados () {
        Console.WriteLine($@"
        Nome do jogo: {Nome} 
        Ano Lançamento:{Lancamento}
        Genêro: {Genero}
        Preço: {Preco}");   
        }   
    }
}