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

            builder.HasMany(b => b.LandTaal)
    .WithOne(b => b.Land)
    .HasForeignKey(x => x.LandCode);



        }
    }
}