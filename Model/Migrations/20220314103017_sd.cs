using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class sd : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "ISOTaalCode",
                table: "Talen",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TaalCode",
                table: "LandTaal",
                column: "TaalCode");

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Landen_LandCode",
                table: "LandTaal",
                column: "LandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Talen_TaalCode",
                table: "LandTaal",
                column: "TaalCode",
                principalTable: "Talen",
                principalColumn: "ISOTaalCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Landen_LandCode",
                table: "LandTaal");

            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Talen_TaalCode",
                table: "LandTaal");

            migrationBuilder.DropIndex(
                name: "IX_LandTaal_TaalCode",
                table: "LandTaal");

            migrationBuilder.AlterColumn<string>(
                name: "ISOTaalCode",
                table: "Talen",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddColumn<string>(
                name: "LandISOLandCode",
                table: "LandTaal",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaalISOTaalCode",
                table: "LandTaal",
                type: "nvarchar(450)",
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
