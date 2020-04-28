using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtniaController:ControllerBase
    {
        public EtniaController(EtniaService etniaService){
            this.etniaService = etniaService;
        }
        private EtniaService etniaService;

        [HttpPost]
        public ActionResult cadastrarEtnias(ICollection<EtniaDTO> dados){
            if(etniaService.cadastrarEtnias(dados)){
                return Ok();
            }
            return BadRequest("Não foi possível cadastrar os dados");
        }

        [HttpGet]
        public ActionResult<IEnumerable> obterEtnias(){
            
            return Ok(etniaService.obterEtnias());
        }
    }
}