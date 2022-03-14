using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Configuration
{
    class TaalConfiguration : IEntityTypeConfiguration<Taal>
    {
        public void Configure(EntityTypeBuilder<Taal> builder)
        {
            builder.ToTable("Talen");
            builder.HasKey(b => b.ISOTaalCode);
            builder.Property(b => b.ISOTaalCode).HasMaxLength(2);

            builder.Property(b => b.NaamNL).HasMaxLength(50);

            builder.Property(b => b.NaamTaal)
            .HasMaxLength(50);

            builder.HasMany(b => b.LandTaal)
.WithOne(b => b.Taal)
.HasForeignKey(x => x.TaalCode);
        }
    }
}
