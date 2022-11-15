﻿// <auto-generated />
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221114143522_SeedingDb")]
    partial class SeedingDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "India",
                            ShortName = "IN"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "USA",
                            ShortName = "US"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "China",
                            ShortName = "CH"
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "New York",
                            CountryId = 2,
                            Name = "Baccarat Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Washington",
                            CountryId = 2,
                            Name = "MayFlower Resorts",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bluffton",
                            CountryId = 2,
                            Name = "Montage Palmetto",
                            Rating = 3.5
                        },
                        new
                        {
                            Id = 4,
                            Address = "Beijing",
                            CountryId = 3,
                            Name = "Fairmont Beijing",
                            Rating = 3.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "Guilin",
                            CountryId = 3,
                            Name = "Guilin Sapphire",
                            Rating = 1.0
                        },
                        new
                        {
                            Id = 6,
                            Address = "Jiangsu",
                            CountryId = 3,
                            Name = "Grand Park Hotel Wuxi",
                            Rating = 3.7000000000000002
                        },
                        new
                        {
                            Id = 7,
                            Address = "New Delhi",
                            CountryId = 1,
                            Name = "Leela Palace",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 8,
                            Address = "Udaipur",
                            CountryId = 1,
                            Name = "Fateh Collection",
                            Rating = 3.7000000000000002
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}