using System.Collections;
using System.Collections.Generic;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class ExameService
    {

       public ExameService(ExameRepository exameRepository){
           this.exameRepository = exameRepository;
       } 
       private ExameRepository exameRepository;

       public void criarPedidoExame(PedidoExameDTO exame){
           
       }
       public void cadastrarExames(ICollection<ExameDTO> exames){
           exameRepository.cadastrarExames(exames);
       }

       public IEnumerable obterTodos(){
           return exameRepository.obterTodos();
       }
    }
}