using System.Collections;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController:ControllerBase
    {
        public ProfessorController(ProfessorService professorService){
            this.professorService = professorService;
        }
        private ProfessorService professorService;
        
        [HttpGet]
        public IEnumerable obterTodos(){
            return professorService.obterTodos();
        }
    }
}