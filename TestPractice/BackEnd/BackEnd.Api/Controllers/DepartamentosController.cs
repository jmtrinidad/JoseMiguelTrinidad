namespace BackEnd.Api.Controllers
{
    using BackEnd.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
         
        private readonly IDepartamentoService departamentoService;

        public DepartamentosController(IDepartamentoService departamentoService)
        {
            
            this.departamentoService = departamentoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
             
            return Ok(departamentoService.GetDepartamentos());
        }
    }
}
