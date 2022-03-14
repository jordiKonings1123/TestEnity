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

            builder.Property(b => b.Naam).HasMaxLength(50);

            builder.Property(b => b.IsoLandCode)
            .HasMaxLength(2);

            builder
            .HasOne(b => b.Land)
            .WithMany(b => b.Steden)
            .HasForeignKey(b => b.IsoLandCode);
        }
    }
}
