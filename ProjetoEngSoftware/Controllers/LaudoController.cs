using System.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaudoController:ControllerBase
    {
        public LaudoController(LaudoService laudoService){
            this.laudoService = laudoService;
        }
        private LaudoService laudoService;

        [HttpPost]
        public ActionResult criarLaudo([FromBody]LaudoDTO laudo){
            bool laudoCriado = laudoService.criarLaudo(laudo);

            if(laudoCriado)
                return Ok();
            
            return BadRequest("Não foi possível criar novo laudo");
        }

        [HttpPut]
        public ActionResult atualizarLaudo([FromBody]LaudoDTO laudo){
            bool laudoAtualizado = laudoService.atualizarLaudo(laudo);

            if(laudoAtualizado)
                return Ok();
            
            return BadRequest();
        }

        [Authorize(Roles = "Professor,Medico")]
        [HttpPut("atualizar-status")]
        public ActionResult atualizarStatusLaudo([FromBody]LaudoDTO laudo){
            bool laudoStatus = laudoService.atualizarStatus(laudo);

            if(laudoStatus)
                return Ok();
            
            return BadRequest();
        }

        [HttpGet("{idPedido}")]
        public ActionResult<LaudoDTO> obterLaudo(int idPedido){
            LaudoDTO laudo = laudoService.obterLaudo(idPedido);

            return Ok(laudo);
        }

        [HttpGet("obter-todos")]
        public ActionResult<IEnumerable> obterTodos(){
            return Ok(laudoService.obterTodos());
        }
    }
}