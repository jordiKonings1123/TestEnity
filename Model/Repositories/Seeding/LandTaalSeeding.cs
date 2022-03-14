using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Seeding
{
    class LandTaalSeeding : IEntityTypeConfiguration<LandTaal>
    {
        public void Configure(EntityTypeBuilder<LandTaal> builder)
        {
            builder.HasData
            (
                new LandTaal { ISOLandCode = "BE", ISOTaalCode = "de" },
                new LandTaal { ISOLandCode = "DE", ISOTaalCode = "de" },
                new LandTaal { ISOLandCode = "LU", ISOTaalCode = "de" },
                new LandTaal { ISOLandCode = "BE", ISOTaalCode = "fr" },
                new LandTaal { ISOLandCode = "FR", ISOTaalCode = "fr" },
                new LandTaal { ISOLandCode = "LU", ISOTaalCode = "fr" },
                new LandTaal { ISOLandCode = "BE", ISOTaalCode = "nl" },
                new LandTaal { ISOLandCode = "NL", ISOTaalCode = "nl" }


            );
        }
    }
}
