using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class configSeedingFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Steden_Naam",
                table: "Steden");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Steden",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steden_Naam",
                table: "Steden",
                column: "Naam",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Steden_Naam",
                table: "Steden");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Steden",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)");

            migrationBuilder.CreateIndex(
                name: "IX_Steden_Naam",
                table: "Steden",
                column: "Naam",
                unique: true,
                filter: "[Naam] IS NOT NULL");
        }
    }
}
