namespace BackEnd.Api.Controllers
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
         
        private readonly IDepartamentoService _departamentoService;

        public DepartamentosController(IDepartamentoService departamentoService)
        {
            
            this._departamentoService = departamentoService;
        }

        public override bool Equals(object obj)
        {
            return obj is DepartamentosController controller &&
                   EqualityComparer<IDepartamentoService>.Default.Equals(_departamentoService, controller._departamentoService);
        }

        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(_departamentoService.GetDepartamentos());
        }

        [HttpPost]
        public async Task<IActionResult> Post(DepartamentoDto departamento)
        {
           await _departamentoService.InsertPostAsync(departamento);
            return Ok(departamento);
        }
    }
}
