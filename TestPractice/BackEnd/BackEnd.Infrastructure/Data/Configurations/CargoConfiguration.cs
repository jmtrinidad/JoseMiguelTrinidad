namespace BackEnd.Infrastructure.Data.Configurations
{
    using BackEnd.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CargoId")
                .ValueGeneratedNever();

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
