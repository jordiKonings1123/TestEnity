﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(TestEntityContext))]
    [Migration("20220314114035_timestamp")]
    partial class timestamp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Property<string>("ISOLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<byte[]>("Aangepast")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp");

                    b.Property<int>("AantalInwoners")
                        .HasColumnType("int");

                    b.Property<string>("NISLandCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Oppervlakte")
                        .HasColumnType("real");

                    b.HasKey("ISOLandCode");

                    b.HasIndex("ISOLandCode")
                        .IsUnique();

                    b.HasIndex("Naam")
                        .IsUnique();

                    b.ToTable("Landen");

                    b.HasData(
                        new
                        {
                            ISOLandCode = "AT",
                            AantalInwoners = 8754413,
                            NISLandCode = "105",
                            Naam = "Oostenrijk",
                            Oppervlakte = 83871f
                        },
                        new
                        {
                            ISOLandCode = "BE",
                            AantalInwoners = 11500000,
                            NISLandCode = "150",
                            Naam = "België",
                            Oppervlakte = 30689f
                        },
                        new
                        {
                            ISOLandCode = "CH",
                            AantalInwoners = 8236303,
                            NISLandCode = "127",
                            Naam = "Zwitserland",
                            Oppervlakte = 41285f
                        },
                        new
                        {
                            ISOLandCode = "DE",
                            AantalInwoners = 80594017,
                            NISLandCode = "103",
                            Naam = "Duitsland",
                            Oppervlakte = 357022f
                        },
                        new
                        {
                            ISOLandCode = "DK",
                            AantalInwoners = 5605948,
                            NISLandCode = "108",
                            Naam = "Denemarken",
                            Oppervlakte = 43094f
                        },
                        new
                        {
                            ISOLandCode = "ES",
                            AantalInwoners = 48958159,
                            NISLandCode = "109",
                            Naam = "Spanje",
                            Oppervlakte = 505992f
                        },
                        new
                        {
                            ISOLandCode = "FR",
                            AantalInwoners = 62814233,
                            NISLandCode = "111",
                            Naam = "Frankrijk",
                            Oppervlakte = 674843f
                        },
                        new
                        {
                            ISOLandCode = "GB",
                            AantalInwoners = 64769452,
                            NISLandCode = "112",
                            Naam = "Verenigd Konijngkrijk",
                            Oppervlakte = 242495f
                        },
                        new
                        {
                            ISOLandCode = "IT",
                            AantalInwoners = 62137802,
                            NISLandCode = "128",
                            Naam = "Italië",
                            Oppervlakte = 300000f
                        },
                        new
                        {
                            ISOLandCode = "LU",
                            AantalInwoners = 594130,
                            NISLandCode = "113",
                            Naam = "Luxemburg",
                            Oppervlakte = 2586f
                        },
                        new
                        {
                            ISOLandCode = "NL",
                            AantalInwoners = 17424978,
                            NISLandCode = "129",
                            Naam = "Nederland",
                            Oppervlakte = 41873f
                        },
                        new
                        {
                            ISOLandCode = "NO",
                            AantalInwoners = 5367580,
                            NISLandCode = "121",
                            Naam = "Noorwegen",
                            Oppervlakte = 385207f
                        },
                        new
                        {
                            ISOLandCode = "PL",
                            AantalInwoners = 38476269,
                            NISLandCode = "139",
                            Naam = "Polen",
                            Oppervlakte = 311888f
                        },
                        new
                        {
                            ISOLandCode = "PT",
                            AantalInwoners = 10839541,
                            NISLandCode = "123",
                            Naam = "Portugal",
                            Oppervlakte = 92212f
                        },
                        new
                        {
                            ISOLandCode = "SE",
                            AantalInwoners = 9960487,
                            NISLandCode = "126",
                            Naam = "Zweden",
                            Oppervlakte = 450295f
                        },
                        new
                        {
                            ISOLandCode = "US",
                            AantalInwoners = 326625791,
                            NISLandCode = "402",
                            Naam = "Verenigde Staten",
                            Oppervlakte = 9826675f
                        });
                });

            modelBuilder.Entity("Model.Entities.LandTaal", b =>
                {
                    b.Property<string>("ISOLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ISOTaalCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("ISOLandCode", "ISOTaalCode");

                    b.HasIndex("ISOTaalCode");

                    b.ToTable("LandTaal");

                    b.HasData(
                        new
                        {
                            ISOLandCode = "BE",
                            ISOTaalCode = "de"
                        },
                        new
                        {
                            ISOLandCode = "DE",
                            ISOTaalCode = "de"
                        },
                        new
                        {
                            ISOLandCode = "LU",
                            ISOTaalCode = "de"
                        },
                        new
                        {
                            ISOLandCode = "BE",
                            ISOTaalCode = "fr"
                        },
                        new
                        {
                            ISOLandCode = "FR",
                            ISOTaalCode = "fr"
                        },
                        new
                        {
                            ISOLandCode = "LU",
                            ISOTaalCode = "fr"
                        },
                        new
                        {
                            ISOLandCode = "BE",
                            ISOTaalCode = "nl"
                        },
                        new
                        {
                            ISOLandCode = "NL",
                            ISOTaalCode = "nl"
                        });
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.Property<int>("StadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IsoLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("LandISOLandCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Naam")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StadId");

                    b.HasIndex("LandISOLandCode");

                    b.ToTable("Steden");

                    b.HasData(
                        new
                        {
                            StadId = 1,
                            IsoLandCode = "BE",
                            Naam = "Brussel"
                        },
                        new
                        {
                            StadId = 2,
                            IsoLandCode = "BE",
                            Naam = "Antwerpen"
                        },
                        new
                        {
                            StadId = 3,
                            IsoLandCode = "BE",
                            Naam = "Luik"
                        },
                        new
                        {
                            StadId = 4,
                            IsoLandCode = "NL",
                            Naam = "Amsterdam"
                        },
                        new
                        {
                            StadId = 5,
                            IsoLandCode = "NL",
                            Naam = "Den Haag"
                        },
                        new
                        {
                            StadId = 6,
                            IsoLandCode = "NL",
                            Naam = "Rotterdam"
                        },
                        new
                        {
                            StadId = 7,
                            IsoLandCode = "DE",
                            Naam = "Berlijn"
                        },
                        new
                        {
                            StadId = 8,
                            IsoLandCode = "DE",
                            Naam = "Hamburg"
                        },
                        new
                        {
                            StadId = 9,
                            IsoLandCode = "DE",
                            Naam = "München"
                        },
                        new
                        {
                            StadId = 10,
                            IsoLandCode = "LU",
                            Naam = "Luxemburg"
                        },
                        new
                        {
                            StadId = 11,
                            IsoLandCode = "FR",
                            Naam = "Parijs"
                        },
                        new
                        {
                            StadId = 12,
                            IsoLandCode = "FR",
                            Naam = "Marseille"
                        },
                        new
                        {
                            StadId = 13,
                            IsoLandCode = "FR",
                            Naam = "Lyon"
                        });
                });

            modelBuilder.Entity("Model.Entities.Taal", b =>
                {
                    b.Property<string>("ISOTaalCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NaamNL")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NaamTaal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ISOTaalCode");

                    b.ToTable("Talen");

                    b.HasData(
                        new
                        {
                            ISOTaalCode = "bg",
                            NaamNL = "Bulgaars",
                            NaamTaal = "български"
                        },
                        new
                        {
                            ISOTaalCode = "cs",
                            NaamNL = "Tsjechisch",
                            NaamTaal = "čeština"
                        },
                        new
                        {
                            ISOTaalCode = "da",
                            NaamNL = "Deens",
                            NaamTaal = "dansk"
                        },
                        new
                        {
                            ISOTaalCode = "de",
                            NaamNL = "Duits",
                            NaamTaal = "Deutsch"
                        },
                        new
                        {
                            ISOTaalCode = "el",
                            NaamNL = "Grieks",
                            NaamTaal = "ελληνικά"
                        },
                        new
                        {
                            ISOTaalCode = "en",
                            NaamNL = "Engels",
                            NaamTaal = "English"
                        },
                        new
                        {
                            ISOTaalCode = "es",
                            NaamNL = "Spaans",
                            NaamTaal = "español"
                        },
                        new
                        {
                            ISOTaalCode = "et",
                            NaamNL = "Ests",
                            NaamTaal = "eesti keel"
                        },
                        new
                        {
                            ISOTaalCode = "fi",
                            NaamNL = "Fins",
                            NaamTaal = "suomi"
                        },
                        new
                        {
                            ISOTaalCode = "fr",
                            NaamNL = "Frans",
                            NaamTaal = "français"
                        },
                        new
                        {
                            ISOTaalCode = "ga",
                            NaamNL = "Iers",
                            NaamTaal = "Gaeilge"
                        },
                        new
                        {
                            ISOTaalCode = "hu",
                            NaamNL = "Hongaars",
                            NaamTaal = "magyar"
                        },
                        new
                        {
                            ISOTaalCode = "it",
                            NaamNL = "Italiaans",
                            NaamTaal = "italiano"
                        },
                        new
                        {
                            ISOTaalCode = "lt",
                            NaamNL = "Litouws",
                            NaamTaal = "lietuvių kalba"
                        },
                        new
                        {
                            ISOTaalCode = "lv",
                            NaamNL = "Lets",
                            NaamTaal = "latviešu valoda"
                        },
                        new
                        {
                            ISOTaalCode = "mt",
                            NaamNL = "Maltees",
                            NaamTaal = "malti"
                        },
                        new
                        {
                            ISOTaalCode = "nl",
                            NaamNL = "Nederlands",
                            NaamTaal = "Nederlands"
                        },
                        new
                        {
                            ISOTaalCode = "pl",
                            NaamNL = "Pools",
                            NaamTaal = "polski"
                        },
                        new
                        {
                            ISOTaalCode = "pt",
                            NaamNL = "Portugees",
                            NaamTaal = "português"
                        },
                        new
                        {
                            ISOTaalCode = "ro",
                            NaamNL = "Roemeens",
                            NaamTaal = "română"
                        },
                        new
                        {
                            ISOTaalCode = "sk",
                            NaamNL = "Slovaaks",
                            NaamTaal = "slovenčina"
                        },
                        new
                        {
                            ISOTaalCode = "sl",
                            NaamNL = "Sloveens",
                            NaamTaal = "slovenščina"
                        },
                        new
                        {
                            ISOTaalCode = "sv",
                            NaamNL = "Zweeds",
                            NaamTaal = "svenska"
                        });
                });

            modelBuilder.Entity("Model.Entities.LandTaal", b =>
                {
                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("LandTaal")
                        .HasForeignKey("ISOLandCode")
                        .HasConstraintName("FK_Reservatie_Land")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Taal", "Taal")
                        .WithMany("LandTaal")
                        .HasForeignKey("ISOTaalCode")
                        .HasConstraintName("FK_Reservatie_Taal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Land");

                    b.Navigation("Taal");
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("Steden")
                        .HasForeignKey("LandISOLandCode");

                    b.Navigation("Land");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Navigation("LandTaal");

                    b.Navigation("Steden");
                });

            modelBuilder.Entity("Model.Entities.Taal", b =>
                {
                    b.Navigation("LandTaal");
                });
#pragma warning restore 612, 618
        }
    }
}
