﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(TestEntityContext))]
    [Migration("20220314085328_g")]
    partial class g
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.Property<string>("LandenISOLandCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("talenISOTaalCode")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LandenISOLandCode", "talenISOTaalCode");

                    b.HasIndex("talenISOTaalCode");

                    b.ToTable("LandenTalen");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Property<string>("ISOLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("AantalInwoners")
                        .HasColumnType("int");

                    b.Property<string>("NISLandCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Oppervlakte")
                        .HasColumnType("real");

                    b.HasKey("ISOLandCode");

                    b.HasIndex("ISOLandCode")
                        .IsUnique();

                    b.ToTable("Landen");
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

                    b.Property<string>("Naam")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StadId");

                    b.HasIndex("IsoLandCode");

                    b.ToTable("Steden");
                });

            modelBuilder.Entity("Model.Entities.Taal", b =>
                {
                    b.Property<string>("ISOTaalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NaamNL")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NaamTaal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ISOTaalCode");

                    b.ToTable("Talen");
                });

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.HasOne("Model.Entities.Land", null)
                        .WithMany()
                        .HasForeignKey("LandenISOLandCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Taal", null)
                        .WithMany()
                        .HasForeignKey("talenISOTaalCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("Steden")
                        .HasForeignKey("IsoLandCode");

                    b.Navigation("Land");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Navigation("Steden");
                });
#pragma warning restore 612, 618
        }
    }
}