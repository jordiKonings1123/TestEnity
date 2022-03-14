﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class gf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "ISOLandCode", "AantalInwoners", "NISLandCode", "Naam", "Oppervlakte" },
                values: new object[,]
                {
                    { "AT", 8754413, "105", "Oostenrijk", 83871f },
                    { "US", 326625791, "402", "Verenigde Staten", 9826675f },
                    { "SE", 9960487, "126", "Zweden", 450295f },
                    { "PT", 10839541, "123", "Portugal", 92212f },
                    { "NO", 5367580, "121", "Noorwegen", 385207f },
                    { "NL", 17424978, "129", "Nederland", 41873f },
                    { "LU", 594130, "113", "Luxemburg", 2586f },
                    { "IT", 62137802, "128", "Italië", 300000f },
                    { "PL", 38476269, "139", "Polen", 311888f },
                    { "FR", 62814233, "111", "Frankrijk", 674843f },
                    { "ES", 48958159, "109", "Spanje", 505992f },
                    { "DK", 5605948, "108", "Denemarken", 43094f },
                    { "DE", 80594017, "103", "Duitsland", 357022f },
                    { "CH", 8236303, "127", "Zwitserland", 41285f },
                    { "BE", 11500000, "150", "België", 30689f },
                    { "GB", 64769452, "112", "Verenigd Konijngkrijk", 242495f }
                });

            migrationBuilder.InsertData(
                table: "Talen",
                columns: new[] { "ISOTaalCode", "NaamNL", "NaamTaal" },
                values: new object[,]
                {
                    { "lt", "Litouws", "lietuvių kalba" },
                    { "lv", "Lets", "latviešu valoda" },
                    { "mt", "Maltees", "malti" },
                    { "nl", "Nederlands", "Nederlands" },
                    { "ro", "Roemeens", "română" },
                    { "pt", "Portugees", "português" },
                    { "sk", "Slovaaks", "slovenčina" },
                    { "it", "Italiaans", "italiano" },
                    { "pl", "Pools", "polski" },
                    { "hu", "Hongaars", "magyar" },
                    { "de", "Duits", "Deutsch" },
                    { "fr", "Frans", "français" },
                    { "fi", "Fins", "suomi" },
                    { "et", "Ests", "eesti keel" },
                    { "es", "Spaans", "español" },
                    { "en", "Engels", "English" },
                    { "el", "Grieks", "ελληνικά" },
                    { "sl", "Sloveens", "slovenščina" },
                    { "da", "Deens", "dansk" },
                    { "cs", "Tsjechisch", "čeština" },
                    { "bg", "Bulgaars", "български" },
                    { "ga", "Iers", "Gaeilge" },
                    { "sv", "Zweeds", "svenska" }
                });

            migrationBuilder.InsertData(
                table: "Steden",
                columns: new[] { "StadId", "IsoLandCode", "Naam" },
                values: new object[,]
                {
                    { 1, "BE", "Brussel" },
                    { 2, "BE", "Antwerpen" },
                    { 3, "BE", "Luik" },
                    { 7, "DE", "Berlijn" },
                    { 8, "DE", "Hamburg" },
                    { 9, "DE", "München" },
                    { 11, "FR", "Parijs" },
                    { 12, "FR", "Marseille" },
                    { 13, "FR", "Lyon" },
                    { 10, "LU", "Luxemburg" },
                    { 4, "NL", "Amsterdam" },
                    { 5, "NL", "Den Haag" },
                    { 6, "NL", "Rotterdam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "bg");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "cs");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "da");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "de");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "el");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "en");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "es");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "et");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "fi");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "fr");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "ga");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "hu");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "it");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "lt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "lv");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "mt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "nl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "pl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "pt");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "ro");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sk");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sl");

            migrationBuilder.DeleteData(
                table: "Talen",
                keyColumn: "ISOTaalCode",
                keyValue: "sv");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NL");
        }
    }
}
