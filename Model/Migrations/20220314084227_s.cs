using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LandISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LandTaal",
                columns: table => new
                {
                    LandenISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    talenISOTaalCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandTaal", x => new { x.LandenISOLandCode, x.talenISOTaalCode });
                    table.ForeignKey(
                        name: "FK_LandTaal_Landen_LandenISOLandCode",
                        column: x => x.LandenISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandTaal_Talen_talenISOTaalCode",
                        column: x => x.talenISOTaalCode,
                        principalTable: "Talen",
                        principalColumn: "ISOTaalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_talenISOTaalCode",
                table: "LandTaal",
                column: "talenISOTaalCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Steden_Landen_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steden_Landen_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropTable(
                name: "LandTaal");

            migrationBuilder.DropIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropColumn(
                name: "LandISOLandCode",
                table: "Steden");
        }
    }
}
