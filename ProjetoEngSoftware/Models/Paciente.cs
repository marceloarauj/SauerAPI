using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEngSoftware.Models
{

    public class Paciente
    {

        public string Cpf {get;set;}
        public string Nome {get;set;}
        public char Sexo {get;set;}
        public Etnia Etnia {get;set;}
        public DateTime DataNascimento{get;set;}
    }
}