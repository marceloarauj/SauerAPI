using System.Collections;
using System.Collections.Generic;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class EtniaService
    {
        public EtniaService(EtniaRepository etniaRepository){
            this.etniaRepository = etniaRepository;
        }
        private EtniaRepository etniaRepository;
        public bool cadastrarEtnias(ICollection<EtniaDTO> dados){
            return etniaRepository.cadastrarEtnias(dados);
        }

        public IEnumerable obterEtnias(){
            return etniaRepository.obterEtnias();
        }
    }
}