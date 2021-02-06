namespace BackEnd.Infrastructure.Repositories
{
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using BackEnd.Infrastructure.Data;
    using Microsoft.Extensions.Configuration;

    public class DepartamentoRepository : BaseRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(DataContext context, IConfiguration configuration) : base(context,configuration)
        {
        }
    }
}
