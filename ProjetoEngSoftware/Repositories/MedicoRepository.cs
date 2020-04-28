using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class MedicoRepository
    {
        public MedicoRepository(Context contexto){
            this.context = contexto;
        }
        private Context context;

        public IEnumerable obterTodos(){

            IEnumerable medicos =  context.Medicos.ToList();

            return medicos;
        }

        public MedicoDTO obterPorCrm(string numero){

            Medico medico = context.Medicos.Where( x=> x.Crm.Equals(numero)).FirstOrDefault();
            MedicoProfessor professor = context.Professores.Where(x => x.Id == medico.IdMedico).FirstOrDefault();
            MedicoResidente residente = context.Residentes.Where(x => x.Id == medico.IdMedico).FirstOrDefault();
            
            int tipo = 0;

            if(residente != null){
                tipo = 1;
            }else if(professor != null){
                tipo = 2;
            }
            
            return new MedicoDTO{
                Id = medico.IdMedico,
                Crm = medico.Crm,
                Nome = medico.Nome,
                Tipo = tipo
            };
        }

        public bool atualizarDados(MedicoDTO dados){
            Medico medico = context.Medicos.Where(x => x.IdMedico == dados.Id).FirstOrDefault();

            if(medico == null)
                return false;
            
            medico.Nome = dados.Nome;
            context.Medicos.Update(medico);
            context.SaveChanges();
            
            return true;
        }
    }
}