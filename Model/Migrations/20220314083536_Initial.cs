using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Landen",
                columns: table => new
                {
                    ISOLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NISLandCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AantalInwoners = table.Column<int>(type: "int", nullable: false),
                    Oppervlakte = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landen", x => x.ISOLandCode);
                });

            migrationBuilder.CreateTable(
                name: "Steden",
                columns: table => new
                {
                    StadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsoLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steden", x => x.StadId);
                });

            migrationBuilder.CreateTable(
                name: "Talen",
                columns: table => new
                {
                    ISOTaalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NaamNL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NaamTaal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talen", x => x.ISOTaalCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Landen");

            migrationBuilder.DropTable(
                name: "Steden");

            migrationBuilder.DropTable(
                name: "Talen");
        }
    }
}
