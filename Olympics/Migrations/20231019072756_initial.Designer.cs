﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olympics.Models;

#nullable disable

namespace Olympics.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20231019072756_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Olympics.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "canada",
                            GameID = "winter",
                            LogoImage = "canada.jpg",
                            Name = "Canada",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "sweden",
                            GameID = "winter",
                            LogoImage = "sweden.jpg",
                            Name = "Sweden",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "great_britain",
                            GameID = "winter",
                            LogoImage = "great_britain.jpg",
                            Name = "Great Britain",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "jamaica",
                            GameID = "winter",
                            LogoImage = "jamaica.jpg",
                            Name = "Jamaica",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "italy",
                            GameID = "winter",
                            LogoImage = "italy.jpg",
                            Name = "Italy",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "japan",
                            GameID = "winter",
                            LogoImage = "japan.jpg",
                            Name = "Japan",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "germany",
                            GameID = "summer",
                            LogoImage = "germany.jpg",
                            Name = "Germany",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "china",
                            GameID = "summer",
                            LogoImage = "china.jpg",
                            Name = "China",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "mexico",
                            GameID = "summer",
                            LogoImage = "mexico.jpg",
                            Name = "Mexico",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "brazil",
                            GameID = "summer",
                            LogoImage = "brazil.jpg",
                            Name = "Brazil",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "netherlands",
                            GameID = "summer",
                            LogoImage = "netherlands.jpg",
                            Name = "Netherlands",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "usa",
                            GameID = "summer",
                            LogoImage = "united_states.jpg",
                            Name = "USA",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "thailand",
                            GameID = "para",
                            LogoImage = "thailand.jpg",
                            Name = "Thailand",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "uruguay",
                            GameID = "para",
                            LogoImage = "uruguay.jpg",
                            Name = "Uruguay",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "ukraine",
                            GameID = "para",
                            LogoImage = "ukraine.jpg",
                            Name = "Ukraine",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "austria",
                            GameID = "para",
                            LogoImage = "austria.jpg",
                            Name = "Austria",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "pakistan",
                            GameID = "para",
                            LogoImage = "pakistan.jpg",
                            Name = "Pakistan",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "zimbabwe",
                            GameID = "para",
                            LogoImage = "zimbabwe.jpg",
                            Name = "Zimbabwe",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "france",
                            GameID = "youth",
                            LogoImage = "france.jpg",
                            Name = "France",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "cyprus",
                            GameID = "youth",
                            LogoImage = "cyprus.jpg",
                            Name = "Cyprus",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "russia",
                            GameID = "youth",
                            LogoImage = "russia.jpg",
                            Name = "Russia",
                            SportID = "breakdancing"
                        },
                        new
                        {
                            CountryID = "finland",
                            GameID = "youth",
                            LogoImage = "finland.jpg",
                            Name = "Finland",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "slovakia",
                            GameID = "youth",
                            LogoImage = "slovakia.jpg",
                            Name = "Slovakia",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "portugal",
                            GameID = "youth",
                            LogoImage = "portugal.jpg",
                            Name = "Portugal",
                            SportID = "skateboarding"
                        });
                });

            modelBuilder.Entity("Olympics.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("Olympics.Models.Setting", b =>
                {
                    b.Property<string>("SettingID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingID");

                    b.ToTable("Setting");

                    b.HasData(
                        new
                        {
                            SettingID = "outdoor",
                            Name = "Outdoor"
                        },
                        new
                        {
                            SettingID = "indoor",
                            Name = "Indoor"
                        });
                });

            modelBuilder.Entity("Olympics.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curling",
                            Name = "Curling"
                        },
                        new
                        {
                            SportID = "bobsleigh",
                            Name = "Bobsleigh"
                        },
                        new
                        {
                            SportID = "diving",
                            Name = "Diving"
                        },
                        new
                        {
                            SportID = "cycling",
                            Name = "Road Cycling"
                        },
                        new
                        {
                            SportID = "archery",
                            Name = "Archery"
                        },
                        new
                        {
                            SportID = "canoe",
                            Name = "Canoe Sprint"
                        },
                        new
                        {
                            SportID = "breakdancing",
                            Name = "Breakdancing"
                        },
                        new
                        {
                            SportID = "skateboarding",
                            Name = "Skateboarding"
                        });
                });

            modelBuilder.Entity("Olympics.Models.Country", b =>
                {
                    b.HasOne("Olympics.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.HasOne("Olympics.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
