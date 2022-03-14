using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
namespace Model.Repositories.Seeding
{
    class LandSeeding : IEntityTypeConfiguration<Land>
    {
        public void Configure(EntityTypeBuilder<Land> builder)
        {
            builder.HasData
            (
            new Land { ISOLandCode = "AT", NISLandCode = "105", Naam = "Oostenrijk", AantalInwoners = 8754413, Oppervlakte = 83871 },
            new Land { ISOLandCode = "BE", NISLandCode = "150", Naam = "België", AantalInwoners = 11500000, Oppervlakte = 30689 },
            new Land { ISOLandCode = "CH", NISLandCode = "127", Naam = "Zwitserland", AantalInwoners = 8236303, Oppervlakte = 41285 },
            new Land { ISOLandCode = "DE", NISLandCode = "103", Naam = "Duitsland", AantalInwoners = 80594017, Oppervlakte = 357022 },
            new Land { ISOLandCode = "DK", NISLandCode = "108", Naam = "Denemarken", AantalInwoners = 5605948, Oppervlakte = 43094 },
            new Land { ISOLandCode = "ES", NISLandCode = "109", Naam = "Spanje", AantalInwoners = 48958159, Oppervlakte = 505992 },
            new Land { ISOLandCode = "FR", NISLandCode = "111", Naam = "Frankrijk", AantalInwoners = 62814233, Oppervlakte = 674843 },
            new Land { ISOLandCode = "GB", NISLandCode = "112", Naam = "Verenigd Konijngkrijk", AantalInwoners = 64769452, Oppervlakte = 242495 },
            new Land { ISOLandCode = "IT", NISLandCode = "128", Naam = "Italië", AantalInwoners = 62137802, Oppervlakte = 300000 },
            new Land { ISOLandCode = "LU", NISLandCode = "113", Naam = "Luxemburg", AantalInwoners = 594130, Oppervlakte = 2586 },
            new Land { ISOLandCode = "NL", NISLandCode = "129", Naam = "Nederland", AantalInwoners = 17424978, Oppervlakte = 41873 },
            new Land { ISOLandCode = "NO", NISLandCode = "121", Naam = "Noorwegen", AantalInwoners = 5367580, Oppervlakte = 385207 },
            new Land { ISOLandCode = "PL", NISLandCode = "139", Naam = "Polen", AantalInwoners = 38476269, Oppervlakte = 311888 },
            new Land { ISOLandCode = "PT", NISLandCode = "123", Naam = "Portugal", AantalInwoners = 10839541, Oppervlakte = 92212 },
            new Land { ISOLandCode = "SE", NISLandCode = "126", Naam = "Zweden", AantalInwoners = 9960487, Oppervlakte = 450295 },
            new Land { ISOLandCode = "US", NISLandCode = "402", Naam = "Verenigde Staten", AantalInwoners = 326625791, Oppervlakte = 9826675 }

            );
        }
    }
}