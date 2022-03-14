using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Configuration
{
    class StadConfiguration : IEntityTypeConfiguration<Stad>
    {
        public void Configure(EntityTypeBuilder<Stad> builder)
        {
            builder.ToTable("Steden");
            builder.HasKey(b => b.StadId);

            builder.Property(b => b.StadId).ValueGeneratedOnAdd();

            builder.Property(b => b.Naam).HasMaxLength(50).IsRequired();

            builder.HasOne(b => b.Land)
.WithMany(b => b.Steden)
.HasForeignKey(b => b.ISOLandCode)
.OnDelete(DeleteBehavior.Cascade)
.HasConstraintName("FK_Reservatie_Land1");

            builder.Property(b => b.ISOLandCode).IsRequired();

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
