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
        public  IActionResult Post(UsuarioDto usuarioDto)
        {
            var result= _usuarioService.InsertUsuarioAsync(usuarioDto);
            if (!result)
            {
                return NotFound();
            }
            return Ok("Usuario Creado con exito.!");

        }
    }
}
