
namespace BackEnd.Infrastructure.Data.Configurations
{
    using BackEnd.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Generos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("GeneroId")
                .ValueGeneratedNever();

            builder.Property(e => e.Preferencia_Sexual)
                .IsRequired()
                .HasColumnName("Preferencia_Sexual")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}