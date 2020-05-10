using System.Collections;
using System.Linq;
using ProjetoEngSoftware.Contexts;

namespace ProjetoEngSoftware.Repositories
{
    public class MedicoResidenteRepository
    {
        public MedicoResidenteRepository(Context context){
            this.context = context;
        }
        private Context context;

        public IEnumerable obterTodos(){
            return context.Residentes.Join
                            (context.Medicos,
                             residente => residente.Id,
                             medico => medico.IdMedico,
                             (residente,medico)=> new{
                                
                                Id = residente.Id,
                                DataResidencia = residente.DataResidencia,
                                Nome = medico.Nome,
                                Crm = medico.Crm
                             }).ToList();            
        }
    }
}