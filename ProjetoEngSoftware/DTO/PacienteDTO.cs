using System;

namespace ProjetoEngSoftware.DTO
{
    public class PacienteDTO
    {
        public string Cpf {get;set;}
        public string Nome{get;set;}
        public DateTime Nascimento{get;set;}
        public char Sexo {get;set;}
        public int IdEtnia{get;set;}
    }
}