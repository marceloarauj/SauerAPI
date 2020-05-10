using System.Collections;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoResidenteController:ControllerBase
    {
        public MedicoResidenteController(MedicoResidenteService service){
            this.service = service;
        }
        private MedicoResidenteService service;
        
        [HttpGet]
        public IEnumerable obterTodos(){
            return service.obterTodos();
        }
    }
}