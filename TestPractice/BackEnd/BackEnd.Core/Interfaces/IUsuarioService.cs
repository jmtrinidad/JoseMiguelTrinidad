namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IUsuarioService
    {
        Task<bool> DeleteUsuarioAsync(int id);
        Task<UsuarioDto> GetUsuariosByIdAsync(int id);
        IEnumerable<UsuarioDto> GetUsuarios();
        Task InsertUsuarioAsync(UsuarioDto usuarioDto);
        Task<bool> UpdateUsuarioAsync(UsuarioDto usuarioDto);
    }
}
