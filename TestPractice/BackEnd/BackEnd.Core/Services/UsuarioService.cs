namespace BackEnd.Core.Services
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConvertHelper _convertHelper;

        public UsuarioService(IUsuarioRepository usuarioRepository,IConvertHelper convertHelper)
        {
            this._usuarioRepository = usuarioRepository;
            this._convertHelper = convertHelper;
        }

        public Task<bool> DeleteUsuarioAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UsuarioDto> GetUsuarios()
        {
            var usuarios= _usuarioRepository.GetAll();
            var usuarioDtos = ConvertToUsuarioDtoList(usuarios);
            return usuarioDtos;
        }

        public Task<UsuarioDto> GetUsuariosByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task InsertUsuarioAsync(UsuarioDto usuarioDto)
        {
            var usuario =ConvertToUsuario(usuarioDto);
              _usuarioRepository.InsertWithAdot(usuario);
            
        }

        private Usuario ConvertToUsuario(UsuarioDto usuarioDto)
        {
            return new Usuario 
            {
                Id=usuarioDto.Id,
                Apellidos = usuarioDto.Apellidos,
                Cargo = usuarioDto.Cargo,
                Cedula = usuarioDto.Cedula,
                DepartamentoId = usuarioDto.DepartamentoId,
                Fecha_Nacimiento = usuarioDto.Fecha_Nacimiento,
                Genero = usuarioDto.Genero, 
                Nombres = usuarioDto.Nombres,
                Supervisor_Inmediato = usuarioDto.Supervisor_Inmediato,
            };
        }

        public Task<bool> UpdateUsuarioAsync(UsuarioDto usuarioDto)
        {
            throw new System.NotImplementedException();
        }

        private IEnumerable<UsuarioDto> ConvertToUsuarioDtoList(IEnumerable<Usuario> usuarios)
        {
            if(!usuarios.Any())
            {
                return new List<UsuarioDto>();
            }
            else
            {
                return usuarios.Select(usuario => new UsuarioDto
                { 
                    Apellidos = usuario.Apellidos,
                    Cargo = usuario.Cargo,
                    Cedula = usuario.Cedula,
                    DepartamentoId = usuario.DepartamentoId,
                    Fecha_Nacimiento = usuario.Fecha_Nacimiento,
                    Genero = usuario.Genero,
                    Id = usuario.Id,
                    Nombres = usuario.Nombres,
                    Supervisor_Inmediato = usuario.Supervisor_Inmediato,
                });
            }
            
        }

       
    }
}
