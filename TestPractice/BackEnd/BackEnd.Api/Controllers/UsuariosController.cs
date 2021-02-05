namespace BackEnd.Api.Controllers
{
    using BackEnd.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
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
    }
}
