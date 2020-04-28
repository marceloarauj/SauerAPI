using System;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class PacienteRepository
    {
        
        public PacienteRepository(Context pacienteContext){
            this.pacienteContext = pacienteContext;
        }
        private Context pacienteContext;

        public bool PacienteExiste(PacienteDTO dados){

            Paciente paciente = pacienteContext.Pacientes.Where
                                        (x => x.Cpf.Equals(dados.Cpf)).FirstOrDefault(); 

            if(paciente == null)
                return false;
            
            return true;
        }
        public Paciente CadastroPaciente(PacienteDTO dados){

            Paciente paciente = new Paciente{
                Cpf = dados.Cpf,
                DataNascimento = dados.Nascimento,
                Nome = dados.Nome,
                Sexo = dados.Sexo,
                IdEtnia = dados.IdEtnia
            };

            pacienteContext.Pacientes.Add(paciente);
            pacienteContext.SaveChanges();
            
            return paciente;
        }
    }
}