using System.Collections;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class LaudoService
    {
        public LaudoService(LaudoRepository laudoRepository){
            this.laudoRepository = laudoRepository;
        }
        private LaudoRepository laudoRepository;
        public bool criarLaudo(LaudoDTO laudo){
            return laudoRepository.criarLaudo(laudo);
        }
        public bool atualizarLaudo(LaudoDTO laudo){
            return laudoRepository.atualizarLaudo(laudo);
        }
        public bool atualizarStatus(LaudoDTO laudo){
            return laudoRepository.atualizarLaudo(laudo);
        }
        public LaudoDTO obterLaudo(int idPedido){
            return laudoRepository.obterLaudo(idPedido);
        }
        public IEnumerable obterTodos(){
            return laudoRepository.obterTodos();
        }
    }
}