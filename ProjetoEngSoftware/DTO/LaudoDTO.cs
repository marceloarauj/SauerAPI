namespace ProjetoEngSoftware.DTO
{
    public class LaudoDTO
    {
      public int IdPedido {get;set;}
      public int IdMedicoLaudo {get;set;}  
      public int IdMedicoAprovacao {get;set;}
      public string Descricao {get;set;}
      public string MotivoRecusa {get;set;}
      public char Status {get; set;}
    }
}