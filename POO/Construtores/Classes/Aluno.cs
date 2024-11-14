using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Contrutores
{
    public class Aluno
    {
        public string Nome { get; set; }    
        public int Idade { get; set; }  
        public int Matricula { get; set; }   

        public Aluno (string nome, int idade, int matricula){
            Nome = nome;
            Idade = idade;
            Matricula = matricula;  
            
        }

        public void ExibirDados (){
        Console.WriteLine($@"
         Nome: {Nome}
        Idade: {Idade}
        Matricula:{Matricula}"); 
        }
    }
}