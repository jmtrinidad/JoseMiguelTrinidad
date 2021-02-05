namespace BackEnd.Infrastructure.Data.Configurations
{
    using BackEnd.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamentos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("DepartamentoId")
                .ValueGeneratedNever(); 

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsUnicode(false); 
        }
    }
}