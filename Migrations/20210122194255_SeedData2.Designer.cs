﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParkApi.Models;

namespace NationalParkApi.Migrations
{
    [DbContext(typeof(NationalParkApiContext))]
    [Migration("20210122194255_SeedData2")]
    partial class SeedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParkApi.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");

                    b.HasData(
                        new
                        {
                            NationalParkId = 1,
                            Name = "YellowStone",
                            Region = "Mid-West"
                        },
                        new
                        {
                            NationalParkId = 2,
                            Name = "Zion",
                            Region = "South-West"
                        },
                        new
                        {
                            NationalParkId = 3,
                            Name = "Blue Ridge",
                            Region = "East Coast"
                        },
                        new
                        {
                            NationalParkId = 4,
                            Name = "Patrick's Park",
                            Region = "Moon"
                        });
                });

            modelBuilder.Entity("NationalParkApi.Models.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Free");

                    b.Property<string>("Name");

                    b.HasKey("StateParkId");

                    b.ToTable("StateParks");

                    b.HasData(
                        new
                        {
                            StateParkId = 1,
                            Free = true,
                            Name = "Hammock"
                        },
                        new
                        {
                            StateParkId = 2,
                            Free = false,
                            Name = "Fort Pierce"
                        },
                        new
                        {
                            StateParkId = 3,
                            Free = false,
                            Name = "Bear Creek"
                        },
                        new
                        {
                            StateParkId = 4,
                            Free = false,
                            Name = "Patrick's Other Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
