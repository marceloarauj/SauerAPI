using System.Collections;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class ProfessorService
    {
        public ProfessorService(ProfessorRepository professorRepository){
            this.professorRepository = professorRepository;
        }
        private ProfessorRepository professorRepository;
        
        public IEnumerable obterTodos(){
            return professorRepository.obterTodos();
        }
    }
}