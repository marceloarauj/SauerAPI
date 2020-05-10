using System.Collections;
using System.Linq;
using ProjetoEngSoftware.Contexts;

namespace ProjetoEngSoftware.Repositories
{
    public class ProfessorRepository
    {
        public ProfessorRepository(Context context){
            this.context = context;
        }
        private Context context;
        public IEnumerable obterTodos(){
            return context.Professores.Join
                            (context.Medicos,
                             professor => professor.Id,
                             medico => medico.IdMedico,
                             (professor,medico)=> new{
                                
                                Id = professor.Id,
                                Titulacao = professor.DescricaoTitulacao,
                                Nome = medico.Nome,
                                Crm = medico.Crm
                             }).ToList();
        }
    }
}