using System.Collections;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class LaudoRepository
    {
        public LaudoRepository(Context context){
            this.context = context;
        }
        private Context context;

        public bool criarLaudo(LaudoDTO laudo){
            
            PedidoExame pedidoExiste = context.PedidoExames.Where
                        (x => x.IdPedidoExame == laudo.IdPedido).FirstOrDefault();

            Laudo laudoExiste = context.Laudos.Where
                        (x => x.IdPedidoExame == laudo.IdPedido).FirstOrDefault();

            if(pedidoExiste == null || laudoExiste != null)
                return false;

            Laudo novoLaudo = new Laudo {
                DescricaoLaudo = laudo.Descricao,
                Status = 'E',
                IdPedidoExame = laudo.IdPedido,
                IdMedicoLaudo = laudo.IdMedicoLaudo
            };

            context.Laudos.Add(novoLaudo);
            context.SaveChanges();

            return true;
        }

        public bool atualizarLaudo(LaudoDTO laudo){
            
            Laudo laudoExiste = context.Laudos.Where
                        (x => x.IdPedidoExame == laudo.IdPedido).FirstOrDefault();

            if(laudoExiste == null)
                return false;

            laudoExiste.DescricaoLaudo = laudo.Descricao;
            laudoExiste.Status = 'E';
            
            context.Laudos.Update(laudoExiste);
            context.SaveChanges();

            return true;
        }

        public bool atualizarStatus(LaudoDTO laudo){

            Laudo laudoExiste = context.Laudos.Where
                        (x => x.IdPedidoExame == laudo.IdPedido).FirstOrDefault();

            if(laudoExiste == null)
                return false;
            
            laudoExiste.Status = laudo.Status;
            laudoExiste.DescricaoLaudo = laudo.Descricao;

            context.Laudos.Update(laudoExiste);
            context.SaveChanges();

            return true;
        }
        public LaudoDTO obterLaudo(int idPedido){
            Laudo laudo = context.Laudos.Where(x => x.IdPedidoExame == idPedido).FirstOrDefault();

            return new LaudoDTO{
                Descricao = laudo.DescricaoLaudo,
                Status = laudo.Status,
                MotivoRecusa = laudo.MotivoRecusa,
                IdMedicoLaudo = laudo.IdMedicoLaudo,
                IdMedicoAprovacao = laudo.IdMedicoAprovacao
            };
        }

        public IEnumerable obterTodos(){

            return context.Laudos.ToList();
        }
    }
}