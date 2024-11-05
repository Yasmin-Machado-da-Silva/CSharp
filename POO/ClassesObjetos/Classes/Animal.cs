using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Animal
    {
        public string Raça;
        public string Cor;
        public string Nome;
        public int Idade;
        public void FazerBarulho(string barulho = "Barulho genetico"){
        Console.WriteLine($"Som do animal: {barulho}");
        }
        public void Envelhecer(){
           Idade = Idade +1;
        }
    }


}