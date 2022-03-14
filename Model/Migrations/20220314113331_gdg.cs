using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class gdg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Landen_LandISOLandCode",
                table: "LandTaal");

            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Talen_TaalISOTaalCode",
                table: "LandTaal");

            migrationBuilder.DropIndex(
                name: "IX_LandTaal_LandISOLandCode",
                table: "LandTaal");

            migrationBuilder.DropIndex(
                name: "IX_LandTaal_TaalISOTaalCode",
                table: "LandTaal");

            migrationBuilder.DropColumn(
                name: "LandISOLandCode",
                table: "LandTaal");

            migrationBuilder.DropColumn(
                name: "TaalISOTaalCode",
                table: "LandTaal");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_ISOTaalCode",
                table: "LandTaal",
                column: "ISOTaalCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservatie_Land",
                table: "LandTaal",
                column: "ISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservatie_Taal",
                table: "LandTaal",
                column: "ISOTaalCode",
                principalTable: "Talen",
                principalColumn: "ISOTaalCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservatie_Land",
                table: "LandTaal");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservatie_Taal",
                table: "LandTaal");

            migrationBuilder.DropIndex(
                name: "IX_LandTaal_ISOTaalCode",
                table: "LandTaal");

            migrationBuilder.AddColumn<string>(
                name: "LandISOLandCode",
                table: "LandTaal",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaalISOTaalCode",
                table: "LandTaal",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_LandISOLandCode",
                table: "LandTaal",
                column: "LandISOLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TaalISOTaalCode",
                table: "LandTaal",
                column: "TaalISOTaalCode");

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Landen_LandISOLandCode",
                table: "LandTaal",
                column: "LandISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Talen_TaalISOTaalCode",
                table: "LandTaal",
                column: "TaalISOTaalCode",
                principalTable: "Talen",
                principalColumn: "ISOTaalCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
