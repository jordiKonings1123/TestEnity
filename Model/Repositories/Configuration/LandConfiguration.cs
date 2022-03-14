using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Configuration
{
    class LandConfiguration : IEntityTypeConfiguration<Land>
    {
        public void Configure(EntityTypeBuilder<Land> builder)
        {
            builder.ToTable("Landen");
            builder.HasKey(b => b.ISOLandCode);

            builder.Property(b => b.ISOLandCode).HasMaxLength(2);

            builder.Property(b => b.NISLandCode)
            .HasMaxLength(3);

            builder.Property(b => b.Naam).IsRequired();

            builder
.HasIndex(b => b.Naam)
.IsUnique();


            builder
            .Property(b => b.Aangepast).HasColumnType("timestamp");
            builder
            .Property(b => b.Aangepast)
            .IsConcurrencyToken()
            .ValueGeneratedOnAddOrUpdate();





        }
    }
}