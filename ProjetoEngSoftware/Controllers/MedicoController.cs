using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController:ControllerBase
    {
        public MedicoController(MedicoService medicoService){
            this.medicoService = medicoService;
        }
        private MedicoService medicoService;
        
        [HttpPut]
        public ActionResult atualizarDados([FromBody]MedicoDTO dados){
            bool atualizar = medicoService.atualizarDados(dados);

            if(!atualizar)
                return BadRequest("Não foi possível atualizar");
            
            return Ok("Dados Atualizados com sucesso");
        }

        [HttpGet("todos")]
        public IEnumerable obterTodos(){
            
            return medicoService.obterTodos();
        }
        [HttpGet("crm/{numero}")]
        public MedicoDTO obterPorCrm(string numero){
            return medicoService.obterPorCrm(numero);
        }

    }
}