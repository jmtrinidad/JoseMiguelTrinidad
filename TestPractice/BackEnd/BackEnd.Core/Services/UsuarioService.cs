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

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
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

        public Task<UsuarioDto> GetUsuariosByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertUsuarioAsync(UsuarioDto usuarioDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateUsuarioAsync(UsuarioDto usuarioDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
