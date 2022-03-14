using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Seeding
{
    class StadSeeding : IEntityTypeConfiguration<Stad>
    {
        public void Configure(EntityTypeBuilder<Stad> builder)
        {
            builder.HasData
            (
            new Stad { StadId = 1, Naam = "Brussel", IsoLandCode = "BE" },
            new Stad { StadId = 2, Naam = "Antwerpen", IsoLandCode = "BE" },
            new Stad { StadId = 3, Naam = "Luik", IsoLandCode = "BE" },
            new Stad { StadId = 4, Naam = "Amsterdam", IsoLandCode = "NL" },
            new Stad { StadId = 5, Naam = "Den Haag", IsoLandCode = "NL" },
            new Stad { StadId = 6, Naam = "Rotterdam", IsoLandCode = "NL" },
            new Stad { StadId = 7, Naam = "Berlijn", IsoLandCode = "DE" },
            new Stad { StadId = 8, Naam = "Hamburg", IsoLandCode = "DE" },
            new Stad { StadId = 9, Naam = "München", IsoLandCode = "DE" },
            new Stad { StadId = 10, Naam = "Luxemburg", IsoLandCode = "LU" },
            new Stad { StadId = 11, Naam = "Parijs", IsoLandCode = "FR" },
            new Stad { StadId = 12, Naam = "Marseille", IsoLandCode = "FR" },
            new Stad { StadId = 13, Naam = "Lyon", IsoLandCode = "FR" }


            );
        }
    }
}

