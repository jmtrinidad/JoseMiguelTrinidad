namespace BackEnd.Api.Controllers
{
    using BackEnd.Api.Response;
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
            ApiResponse<UsuarioDto> response;
            if (!result)
            {
                response = new ApiResponse<UsuarioDto>
                {
                    IsSuccess = false,

                };
                return Ok(response);
            }
            response = new ApiResponse<UsuarioDto>
            {
                IsSuccess = true,
                Result=usuarioDto,
            };
            return Ok(response);

        }
    }
}
