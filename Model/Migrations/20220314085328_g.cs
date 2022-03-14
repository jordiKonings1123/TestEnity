using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Landen_LandenISOLandCode",
                table: "LandTaal");

            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Talen_talenISOTaalCode",
                table: "LandTaal");

            migrationBuilder.DropForeignKey(
                name: "FK_Steden_Landen_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandTaal",
                table: "LandTaal");

            migrationBuilder.DropColumn(
                name: "LandISOLandCode",
                table: "Steden");

            migrationBuilder.RenameTable(
                name: "LandTaal",
                newName: "LandenTalen");

            migrationBuilder.RenameIndex(
                name: "IX_LandTaal_talenISOTaalCode",
                table: "LandenTalen",
                newName: "IX_LandenTalen_talenISOTaalCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandenTalen",
                table: "LandenTalen",
                columns: new[] { "LandenISOLandCode", "talenISOTaalCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Steden_IsoLandCode",
                table: "Steden",
                column: "IsoLandCode");

            migrationBuilder.CreateIndex(
                name: "IX_Landen_ISOLandCode",
                table: "Landen",
                column: "ISOLandCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LandenTalen_Landen_LandenISOLandCode",
                table: "LandenTalen",
                column: "LandenISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandenTalen_Talen_talenISOTaalCode",
                table: "LandenTalen",
                column: "talenISOTaalCode",
                principalTable: "Talen",
                principalColumn: "ISOTaalCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Steden_Landen_IsoLandCode",
                table: "Steden",
                column: "IsoLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandenTalen_Landen_LandenISOLandCode",
                table: "LandenTalen");

            migrationBuilder.DropForeignKey(
                name: "FK_LandenTalen_Talen_talenISOTaalCode",
                table: "LandenTalen");

            migrationBuilder.DropForeignKey(
                name: "FK_Steden_Landen_IsoLandCode",
                table: "Steden");

            migrationBuilder.DropIndex(
                name: "IX_Steden_IsoLandCode",
                table: "Steden");

            migrationBuilder.DropIndex(
                name: "IX_Landen_ISOLandCode",
                table: "Landen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandenTalen",
                table: "LandenTalen");

            migrationBuilder.RenameTable(
                name: "LandenTalen",
                newName: "LandTaal");

            migrationBuilder.RenameIndex(
                name: "IX_LandenTalen_talenISOTaalCode",
                table: "LandTaal",
                newName: "IX_LandTaal_talenISOTaalCode");

            migrationBuilder.AddColumn<string>(
                name: "LandISOLandCode",
                table: "Steden",
                type: "nvarchar(2)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandTaal",
                table: "LandTaal",
                columns: new[] { "LandenISOLandCode", "talenISOTaalCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Steden_LandISOLandCode",
                table: "Steden",
                column: "LandISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Landen_LandenISOLandCode",
                table: "LandTaal",
                column: "LandenISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Talen_talenISOTaalCode",
                table: "LandTaal",
                column: "talenISOTaalCode",
                principalTable: "Talen",
                principalColumn: "ISOTaalCode",
                onDelete: ReferentialAction.Cascade);

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
