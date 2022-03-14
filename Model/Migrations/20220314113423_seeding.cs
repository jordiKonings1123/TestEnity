using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandTaal",
                columns: new[] { "ISOLandCode", "ISOTaalCode" },
                values: new object[,]
                {
                    { "BE", "de" },
                    { "DE", "de" },
                    { "LU", "de" },
                    { "BE", "fr" },
                    { "FR", "fr" },
                    { "LU", "fr" },
                    { "BE", "nl" },
                    { "NL", "nl" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "BE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "BE", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "BE", "nl" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "DE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "FR", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "LU", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "LU", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "ISOLandCode", "ISOTaalCode" },
                keyValues: new object[] { "NL", "nl" });
        }
    }
}
