using BackEnd.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BackEnd.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Departamento> Departamentos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //USAMOS REFLECTION PARA AGREGAR TODAS LAS CONFIGURACIONES DESDE EL ENSAMBLADO
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
    }
}
