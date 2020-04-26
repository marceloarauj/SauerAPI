using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExameController:ControllerBase
    {
        public ExameController(ExameService exameService){
            this.exameService = exameService;
        }
        private ExameService exameService;

        [Authorize(Roles = "Medico,Professor,Residente")]   
        [HttpPost("criar")]
        public ActionResult<string> criarPedidoExame([FromBody]PedidoExameDTO exame){
            
            exameService.criarPedidoExame(exame);
            return Ok();
        }

        [HttpPost("carregar")]
        public void cadastrarExames([FromBody] ICollection<ExameDTO> exames){
            exameService.cadastrarExames(exames);
        }

        [HttpGet("obter")]
        public IEnumerable obterTodos(){
            return exameService.obterTodos();
        }
    }
}