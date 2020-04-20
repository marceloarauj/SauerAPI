using System.Collections.Generic;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class ExameRepository
    {
        public ExameRepository(Context exameContext){
            this.exameContext = exameContext;
        }   
        private Context exameContext;
        public void cadastrarExames(ICollection<ExameDTO> exames){

            foreach (ExameDTO exame in exames)
            {
                Exame exameSave = new Exame();
                exameSave.Id = exame.Id;
                exameSave.NomeExame = exame.Exame;
                exameContext.Add(exameSave);
            }
            exameContext.SaveChanges();
        }
    }
}