using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaalCode",
                table: "LandTaal",
                newName: "ISOTaalCode");

            migrationBuilder.RenameColumn(
                name: "LandCode",
                table: "LandTaal",
                newName: "ISOLandCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISOTaalCode",
                table: "LandTaal",
                newName: "TaalCode");

            migrationBuilder.RenameColumn(
                name: "ISOLandCode",
                table: "LandTaal",
                newName: "LandCode");
        }
    }
}
