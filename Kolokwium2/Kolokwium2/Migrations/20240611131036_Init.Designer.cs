﻿// <auto-generated />
using System;
using Kolokwium2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240611131036_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kolokwium2.Models.Backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("Backpacks");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            ItemId = 2,
                            Amount = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            ItemId = 1,
                            Amount = 2
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentWeight")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWeight = 80,
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            MaxWeight = 120
                        },
                        new
                        {
                            Id = 2,
                            CurrentWeight = 60,
                            FirstName = "Anna",
                            LastName = "Nowak",
                            MaxWeight = 90
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.CharacterTitles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquiredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("CharacterTitles");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            TitleId = 2,
                            AcquiredAt = new DateTime(1250, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CharacterId = 2,
                            TitleId = 1,
                            AcquiredAt = new DateTime(1292, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BackpacksCharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("BackpacksItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackpacksCharacterId", "BackpacksItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "miecz",
                            Weight = 8
                        },
                        new
                        {
                            Id = 2,
                            Name = "Luk",
                            Weight = 3
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Titles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lucznik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rycerz"
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Backpacks", b =>
                {
                    b.HasOne("Kolokwium2.Models.Character", "Character")
                        .WithMany("Backpacks")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Items", "Items")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kolokwium2.Models.CharacterTitles", b =>
                {
                    b.HasOne("Kolokwium2.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Items", "Items")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kolokwium2.Models.Items", b =>
                {
                    b.HasOne("Kolokwium2.Models.Backpacks", null)
                        .WithMany("ItemsCollection")
                        .HasForeignKey("BackpacksCharacterId", "BackpacksItemId");
                });

            modelBuilder.Entity("Kolokwium2.Models.Backpacks", b =>
                {
                    b.Navigation("ItemsCollection");
                });

            modelBuilder.Entity("Kolokwium2.Models.Character", b =>
                {
                    b.Navigation("Backpacks");
                });
#pragma warning restore 612, 618
        }
    }
}
