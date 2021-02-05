namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IUsuarioService
    {
        Task<bool> DeleteUsuarioAsync(int id);
        Task<Usuario> GetUsuariosByIdAsync(int id);
        IEnumerable<Usuario> GetUsuarios();
        Task InsertUsuarioAsync(Usuario usuario);
        Task<bool> UpdateUsuarioAsync(Usuario usuario);
    }
}
