using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Aluno : Pessoa
    {
        public int Matricula {get; set;}
        public string Curso {get; set;}
        public float Media {get; set;}
    }
}