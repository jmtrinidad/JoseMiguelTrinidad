namespace BackEnd.Infrastructure.Data.Configurations
{
    using BackEnd.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("UsuarioId")
                .ValueGeneratedNever();

            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Apellidos)
               .IsRequired()
               .HasColumnName("Apellidos")
               .HasMaxLength(100)
               .IsUnicode(false);

            builder.Property(e => e.Cedula)
               .IsRequired()
               .HasColumnName("Cedula")
               .HasMaxLength(15)
               .IsUnicode(false);

            builder.Property(e => e.GeneroId)
               .HasColumnName("GeneroId");

            builder.Property(e => e.Fecha_Nac)
                .HasColumnName("Fecha_Nac")
                .HasColumnType("datetime");

            builder.Property(e => e.DepartamentoId)
                .HasColumnName("DepartamentoId");

            builder.Property(e => e.Supervisor_Inmediato)
               .IsRequired()
               .HasColumnName("Supervisor_Inmediato")
               .HasMaxLength(100)
               .IsUnicode(false);

            builder.Property(e => e.CargoId)
               .HasColumnName("CargoId");

        }
    }
}
