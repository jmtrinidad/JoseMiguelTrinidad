namespace BackEnd.Core.Services
{
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using System.Collections.Generic;
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

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public Task<Usuario> GetUsuariosByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertUsuarioAsync(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateUsuarioAsync(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
