using System;

namespace ProjetoEngSoftware.DTO
{
    public class PedidoExameDTO
    {
        public int IdExame {get;set;}
        public string IdMedico {get;set;}
        public string HipoteseDiagnostica {get;set;}
        public string Recomendacoes {get;set;}
        public DateTime DataExame {get;set;}
        public PacienteDTO Paciente {get;set;}
    }
}