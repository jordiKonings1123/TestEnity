using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Configuration
{
    class LandTaalConfiguration : IEntityTypeConfiguration<LandTaal>
    {
        public void Configure(EntityTypeBuilder<LandTaal> builder)
        {

            //            builder.HasKey(c => new { c.LandCode, c.TaalCode });

            //            builder.Property(b => b.LandCode)
            //            .HasMaxLength(2);
            //            builder.Property(b => b.TaalCode)
            //.HasMaxLength(2);

            //            builder.HasOne(b => b.Land)
            //.WithMany(b => b.LandTaal)
            //.HasForeignKey(b => b.LandCode)
            //.OnDelete(DeleteBehavior.Cascade)
            //.HasConstraintName("FK_Reservatie_Land");

            //            builder.HasOne(b => b.Taal)
            //.WithMany(b => b.LandTaal)
            //.HasForeignKey(b => b.TaalCode)
            //.OnDelete(DeleteBehavior.Cascade)
            //.HasConstraintName("FK_Reservatie_Taal");
        }
    }
}
