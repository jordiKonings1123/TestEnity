using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class stadconfig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steden_Landen_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropColumn(
                name: "LandISOLandCode",
                table: "Steden");

            migrationBuilder.RenameColumn(
                name: "IsoLandCode",
                table: "Steden",
                newName: "ISOLandCode");

            migrationBuilder.AlterColumn<string>(
                name: "ISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steden_ISOLandCode",
                table: "Steden",
                column: "ISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservatie_Land1",
                table: "Steden",
                column: "ISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservatie_Land1",
                table: "Steden");

            migrationBuilder.DropIndex(
                name: "IX_Steden_ISOLandCode",
                table: "Steden");

            migrationBuilder.RenameColumn(
                name: "ISOLandCode",
                table: "Steden",
                newName: "IsoLandCode");

            migrationBuilder.AlterColumn<string>(
                name: "IsoLandCode",
                table: "Steden",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Steden_Landen_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
