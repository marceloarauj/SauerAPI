namespace ProjetoEngSoftware.Models
{
    public class Laudo
    {
        public int IdPedidoExame {get;set;}
        public int IdMedicoLaudo {get; set;}
        public int IdMedicoAprovacao {get;set;}
        public string DescricaoLaudo {get;set;}
        public string MotivoRecusa {get;set;}
        public char Status {get;set;} /* A = Aprovado , E = Esperando aprovação, R = Recusado */
    }
}