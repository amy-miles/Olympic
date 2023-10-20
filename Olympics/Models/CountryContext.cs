using Microsoft.EntityFrameworkCore;
using System;

namespace Olympics.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Sport> Sports { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           

              modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "para", Name = "Paralympics" },
                new Game { GameID = "youth", Name = "Youth Olympic Games" }
            );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", Name = "Curling" },
                new Sport { SportID = "bobsleigh", Name = "Bobsleigh" },
                new Sport { SportID = "diving", Name = "Diving" },
                new Sport { SportID = "cycling", Name = "Road Cycling" },
                new Sport { SportID = "archery", Name = "Archery" },
                new Sport { SportID = "canoe", Name = "Canoe Sprint" },
                new Sport { SportID = "breakdancing", Name = "Breakdancing" },
                new Sport { SportID = "skateboarding", Name = "Skateboarding" }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { SettingID = "outdoor", Name = "Outdoor" },
                new Setting { SettingID = "indoor", Name = "Indoor" }
            );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", Name = "Canada", GameID = "winter", SportID = "curling", SettingID = "in", LogoImage = "canada.jpg" },
                new { CountryID = "sweden", Name = "Sweden", GameID = "winter", SportID = "curling", SettingID = "in", LogoImage = "sweden.jpg" },
                new { CountryID = "great_britain", Name = "Great Britain", GameID = "winter", SportID = "curling", SettingID = "in", LogoImage = "great_britain.jpg" },
                new { CountryID = "jamaica", Name = "Jamaica", GameID = "winter", SportID = "bobsleigh", SettingID = "out", LogoImage = "jamaica.jpg" },
                new { CountryID = "italy", Name = "Italy", GameID = "winter", SportID = "bobsleigh", SettingID = "out", LogoImage = "italy.jpg" },
                new { CountryID = "japan", Name = "Japan", GameID = "winter", SportID = "bobsleigh", SettingID = "out", LogoImage = "japan.jpg" },
                new { CountryID = "germany", Name = "Germany", GameID = "summer", SportID = "diving", SettingID = "in", LogoImage = "germany.jpg" },
                new { CountryID = "china", Name = "China", GameID = "summer", SportID = "diving", SettingID = "in", LogoImage = "china.jpg" },
                new { CountryID = "mexico", Name = "Mexico", GameID = "summer", SportID = "diving", SettingID = "in", LogoImage = "mexico.jpg" },
                new { CountryID = "brazil", Name = "Brazil", GameID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "brazil.jpg" },
                new { CountryID = "netherlands", Name = "Netherlands", GameID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "netherlands.jpg" },
                new { CountryID = "usa", Name = "USA", GameID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "united_states.jpg" },
                new { CountryID = "thailand", Name = "Thailand", GameID = "para", SportID = "archery", SettingID = "in", LogoImage = "thailand.jpg" },
                new { CountryID = "uruguay", Name = "Uruguay", GameID = "para", SportID = "archery", SettingID = "in", LogoImage = "uruguay.jpg" },
                new { CountryID = "ukraine", Name = "Ukraine", GameID = "para", SportID = "archery", SettingID = "in", LogoImage = "ukraine.jpg" },
                new { CountryID = "austria", Name = "Austria", GameID = "para", SportID = "canoe", SettingID = "out", LogoImage = "austria.jpg" },
                new { CountryID = "pakistan", Name = "Pakistan", GameID = "para", SportID = "canoe", SettingID = "out", LogoImage = "pakistan.jpg" },
                new { CountryID = "zimbabwe", Name = "Zimbabwe", GameID = "para", SportID = "canoe", SettingID = "out", LogoImage = "zimbabwe.jpg" },
                new { CountryID = "france", Name = "France", GameID = "youth", SportID = "breakdancing", SettingID = "in", LogoImage = "france.jpg" },
                new { CountryID = "cyprus", Name = "Cyprus", GameID = "youth", SportID = "breakdancing", SettingID = "in", LogoImage = "cyprus.jpg" },
                new { CountryID = "russia", Name = "Russia", GameID = "youth", SportID = "breakdancing", SettingID = "in", LogoImage = "russia.jpg" },
                new { CountryID = "finland", Name = "Finland", GameID = "youth", SportID = "skateboarding", SettingID = "out", LogoImage = "finland.jpg" },
                new { CountryID = "slovakia", Name = "Slovakia", GameID = "youth", SportID = "skateboarding", SettingID = "out", LogoImage = "slovakia.jpg" },
                new { CountryID = "portugal", Name = "Portugal", GameID = "youth", SportID = "skateboarding", SettingID = "out", LogoImage = "portugal.jpg" }

            );
        }
    }
}
