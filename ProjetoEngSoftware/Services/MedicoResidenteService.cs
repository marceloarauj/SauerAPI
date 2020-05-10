using System.Collections;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class MedicoResidenteService
    {
        public MedicoResidenteService(MedicoResidenteRepository medicoResidenteRepository){
            this.medicoResidenteRepository = medicoResidenteRepository;
        }
        private MedicoResidenteRepository medicoResidenteRepository;
        public IEnumerable obterTodos(){
            return medicoResidenteRepository.obterTodos();
        }
    }
}