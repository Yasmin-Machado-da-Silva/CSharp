using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Contrutores
{
    public class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string cor { get; set; }

    public Veiculo (string ma, string md, int an, string cd){
        marca = ma;
        modelo = md;
        ano = an;
        cor = cd;
    }

    public void ExibirDados (){
        Console.WriteLine(@$"
        Marca: {marca}
        Modelo: {modelo}
        Ano: {ano}
        Cor: {cor}
        ");
    }


    }
}