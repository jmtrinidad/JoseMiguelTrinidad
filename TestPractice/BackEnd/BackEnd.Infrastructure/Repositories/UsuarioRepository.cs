namespace BackEnd.Infrastructure.Repositories
{
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using BackEnd.Infrastructure.Data;
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context)
        {
        }
    }
}
