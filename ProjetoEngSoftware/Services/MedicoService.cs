using System.Collections;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class MedicoService
    {
        
        public MedicoService(MedicoRepository medicoRepository){
            this.medicoRepository = medicoRepository;
        }
        private MedicoRepository medicoRepository;

        public IEnumerable obterTodos(){
            
            return medicoRepository.obterTodos();
        }

        public MedicoDTO obterPorCrm(string numero){
            return medicoRepository.obterPorCrm(numero);
        }

        public bool atualizarDados(MedicoDTO dados){
            return medicoRepository.atualizarDados(dados);
        } 
    }
}