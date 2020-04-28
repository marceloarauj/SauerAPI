using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class EtniaRepository
    {
        public EtniaRepository(Context context){
            this.context = context;
        }
        private Context context;
        
        public bool cadastrarEtnias(ICollection<EtniaDTO> dados){
            
            List<Etnia> list = new List<Etnia>();

            foreach (EtniaDTO etnia in dados)
            {
                list.Add(new Etnia{
                    Id = etnia.Id,
                    Descricao = etnia.Descricao
                });
            }            
            try{
                context.Etnias.AddRange(list);

            }catch(Exception e){
                return false;
            }
            context.SaveChanges();
            return true;
        } 

        public IEnumerable obterEtnias(){
            return context.Etnias.ToList();
        }
    }
}