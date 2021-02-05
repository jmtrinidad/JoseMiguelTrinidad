﻿namespace BackEnd.Infrastructure.Repositories
{
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using BackEnd.Infrastructure.Data;
    public class DepartamentoRepository : BaseRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(DataContext context) : base(context)
        {
        }
    }
}
