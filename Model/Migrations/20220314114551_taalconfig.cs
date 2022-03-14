using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class taalconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NaamNL",
                table: "Talen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsoLandCode",
                table: "Steden",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talen_NaamNL",
                table: "Talen",
                column: "NaamNL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talen_NaamTaal",
                table: "Talen",
                column: "NaamTaal",
                unique: true,
                filter: "[NaamTaal] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Talen_NaamNL",
                table: "Talen");

            migrationBuilder.DropIndex(
                name: "IX_Talen_NaamTaal",
                table: "Talen");

            migrationBuilder.AlterColumn<string>(
                name: "NaamNL",
                table: "Talen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "IsoLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
