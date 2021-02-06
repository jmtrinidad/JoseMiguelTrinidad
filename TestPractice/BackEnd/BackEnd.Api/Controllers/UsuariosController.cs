namespace BackEnd.Api.Controllers
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioService.GetUsuarios());
        }

        [HttpPost]
        public async Task<IActionResult> Post(UsuarioDto usuarioDto)
        {
            await _usuarioService.InsertUsuarioAsync(usuarioDto);
            return Ok();
        }
    }
}
