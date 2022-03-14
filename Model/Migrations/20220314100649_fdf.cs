using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class fdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandenTalen");

            migrationBuilder.CreateTable(
                name: "LandTaal",
                columns: table => new
                {
                    LandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TaalCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    LandISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    TaalISOTaalCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                table: "LandTaal",
                columns: new[] { "LandCode", "TaalCode", "LandISOLandCode", "TaalISOTaalCode" },
                values: new object[,]
                {
                    { "BE", "de", null, null },
                    { "DE", "de", null, null },
                    { "LU", "de", null, null },
                    { "BE", "fr", null, null },
                    { "FR", "fr", null, null },
                    { "LU", "fr", null, null },
                    { "BE", "nl", null, null },
                    { "NL", "nl", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_LandISOLandCode",
                table: "LandTaal",
                column: "LandISOLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TaalISOTaalCode",
                table: "LandTaal",
                column: "TaalISOTaalCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandTaal");

            migrationBuilder.CreateTable(
                name: "LandenTalen",
                columns: table => new
                {
                    LandenISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    talenISOTaalCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandenTalen", x => new { x.LandenISOLandCode, x.talenISOTaalCode });
                    table.ForeignKey(
                        name: "FK_LandenTalen_Landen_LandenISOLandCode",
                        column: x => x.LandenISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandenTalen_Talen_talenISOTaalCode",
                        column: x => x.talenISOTaalCode,
                        principalTable: "Talen",
                        principalColumn: "ISOTaalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandenTalen_talenISOTaalCode",
                table: "LandenTalen",
                column: "talenISOTaalCode");
        }
    }
}
