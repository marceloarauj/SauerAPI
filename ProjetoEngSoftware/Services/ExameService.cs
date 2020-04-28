using System.Collections;
using System.Collections.Generic;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class ExameService
    {

       public ExameService(ExameRepository exameRepository, PacienteRepository pacienteRepository){
           this.exameRepository = exameRepository;
           this.pacienteRepository = pacienteRepository;
       } 
       private ExameRepository exameRepository;
       private PacienteRepository pacienteRepository;

       public bool criarPedidoExame(PedidoExameDTO exame){

        if(!pacienteRepository.PacienteExiste(exame.Paciente))
            pacienteRepository.CadastroPaciente(exame.Paciente);

        return exameRepository.criarPedidoExame(exame);
       }
       public void cadastrarExames(ICollection<ExameDTO> exames){
           exameRepository.cadastrarExames(exames);
       }

       public IEnumerable obterTodos(){
           return exameRepository.obterTodos();
       }
       public IEnumerable obterTodosPedidos(){
           return exameRepository.obterTodosPedidos();
       }
    }
}