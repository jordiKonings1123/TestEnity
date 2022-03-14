using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class d : Migration
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
                name: "Talen",
                columns: table => new
                {
                    ISOTaalCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NaamNL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NaamTaal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talen", x => x.ISOTaalCode);
                });

            migrationBuilder.CreateTable(
                name: "Steden",
                columns: table => new
                {
                    StadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsoLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    LandISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steden", x => x.StadId);
                    table.ForeignKey(
                        name: "FK_Steden_Landen_LandISOLandCode",
                        column: x => x.LandISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandTaal",
                columns: table => new
                {
                    LandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TaalCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LandISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    TaalISOTaalCode = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandTaal", x => new { x.LandCode, x.TaalCode });
                    table.ForeignKey(
                        name: "FK_LandTaal_Landen_LandISOLandCode",
                        column: x => x.LandISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandTaal_Talen_TaalISOTaalCode",
                        column: x => x.TaalISOTaalCode,
                        principalTable: "Talen",
                        principalColumn: "ISOTaalCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "ISOLandCode", "AantalInwoners", "NISLandCode", "Naam", "Oppervlakte" },
                values: new object[,]
                {
                    { "AT", 8754413, "105", "Oostenrijk", 83871f },
                    { "US", 326625791, "402", "Verenigde Staten", 9826675f },
                    { "SE", 9960487, "126", "Zweden", 450295f },
                    { "PT", 10839541, "123", "Portugal", 92212f },
                    { "PL", 38476269, "139", "Polen", 311888f },
                    { "NO", 5367580, "121", "Noorwegen", 385207f },
                    { "LU", 594130, "113", "Luxemburg", 2586f },
                    { "IT", 62137802, "128", "Italië", 300000f },
                    { "NL", 17424978, "129", "Nederland", 41873f },
                    { "FR", 62814233, "111", "Frankrijk", 674843f },
                    { "ES", 48958159, "109", "Spanje", 505992f },
                    { "DK", 5605948, "108", "Denemarken", 43094f },
                    { "DE", 80594017, "103", "Duitsland", 357022f },
                    { "CH", 8236303, "127", "Zwitserland", 41285f },
                    { "BE", 11500000, "150", "België", 30689f },
                    { "GB", 64769452, "112", "Verenigd Konijngkrijk", 242495f }
                });

            migrationBuilder.InsertData(
                table: "Steden",
                columns: new[] { "StadId", "IsoLandCode", "LandISOLandCode", "Naam" },
                values: new object[,]
                {
                    { 8, "DE", null, "Hamburg" },
                    { 13, "FR", null, "Lyon" },
                    { 12, "FR", null, "Marseille" },
                    { 11, "FR", null, "Parijs" },
                    { 9, "DE", null, "München" },
                    { 7, "DE", null, "Berlijn" },
                    { 10, "LU", null, "Luxemburg" },
                    { 5, "NL", null, "Den Haag" },
                    { 4, "NL", null, "Amsterdam" },
                    { 3, "BE", null, "Luik" },
                    { 2, "BE", null, "Antwerpen" },
                    { 1, "BE", null, "Brussel" },
                    { 6, "NL", null, "Rotterdam" }
                });

            migrationBuilder.InsertData(
                table: "Talen",
                columns: new[] { "ISOTaalCode", "NaamNL", "NaamTaal" },
                values: new object[,]
                {
                    { "sk", "Slovaaks", "slovenčina" },
                    { "ro", "Roemeens", "română" },
                    { "pt", "Portugees", "português" },
                    { "pl", "Pools", "polski" },
                    { "nl", "Nederlands", "Nederlands" },
                    { "mt", "Maltees", "malti" },
                    { "lv", "Lets", "latviešu valoda" },
                    { "lt", "Litouws", "lietuvių kalba" },
                    { "it", "Italiaans", "italiano" },
                    { "hu", "Hongaars", "magyar" },
                    { "fi", "Fins", "suomi" },
                    { "fr", "Frans", "français" },
                    { "et", "Ests", "eesti keel" },
                    { "es", "Spaans", "español" },
                    { "en", "Engels", "English" },
                    { "el", "Grieks", "ελληνικά" },
                    { "de", "Duits", "Deutsch" },
                    { "da", "Deens", "dansk" },
                    { "cs", "Tsjechisch", "čeština" },
                    { "bg", "Bulgaars", "български" },
                    { "sl", "Sloveens", "slovenščina" },
                    { "ga", "Iers", "Gaeilge" },
                    { "sv", "Zweeds", "svenska" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landen_ISOLandCode",
                table: "Landen",
                column: "ISOLandCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_LandISOLandCode",
                table: "LandTaal",
                column: "LandISOLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TaalISOTaalCode",
                table: "LandTaal",
                column: "TaalISOTaalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandTaal");

            migrationBuilder.DropTable(
                name: "Steden");

            migrationBuilder.DropTable(
                name: "Talen");

            migrationBuilder.DropTable(
                name: "Landen");
        }
    }
}
