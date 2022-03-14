using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class stedenconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Aangepast",
                table: "Steden",
                type: "timestamp",
                rowVersion: true,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steden_Naam",
                table: "Steden",
                column: "Naam",
                unique: true,
                filter: "[Naam] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Steden_Naam",
                table: "Steden");

            migrationBuilder.DropColumn(
                name: "Aangepast",
                table: "Steden");
        }
    }
}
