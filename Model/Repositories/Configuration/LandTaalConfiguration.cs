using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Configuration
{
    class LandTaalConfiguration : IEntityTypeConfiguration<LandTaal>
    {
        public void Configure(EntityTypeBuilder<LandTaal> builder)
        {

            builder.HasKey(c => new { c.ISOLandCode, c.ISOTaalCode });

            builder.Property(b => b.ISOLandCode)
            .HasMaxLength(2);
            builder.Property(b => b.ISOTaalCode)
.HasMaxLength(2);

            builder.HasOne(b => b.Land)
.WithMany(b => b.LandTaal)
.HasForeignKey(b => b.ISOLandCode)
.OnDelete(DeleteBehavior.Cascade)
.HasConstraintName("FK_Reservatie_Land");

            builder.HasOne(b => b.Taal)
.WithMany(b => b.LandTaal)
.HasForeignKey(b => b.ISOTaalCode)
.OnDelete(DeleteBehavior.Cascade)
.HasConstraintName("FK_Reservatie_Taal");
        }
    }
}
