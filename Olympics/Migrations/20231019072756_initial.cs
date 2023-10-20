using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Olympics.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID");
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "para", "Paralympics" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "SettingID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Name" },
                values: new object[,]
                {
                    { "archery", "Archery" },
                    { "bobsleigh", "Bobsleigh" },
                    { "breakdancing", "Breakdancing" },
                    { "canoe", "Canoe Sprint" },
                    { "curling", "Curling" },
                    { "cycling", "Road Cycling" },
                    { "diving", "Diving" },
                    { "skateboarding", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "GameID", "LogoImage", "Name", "SportID" },
                values: new object[,]
                {
                    { "austria", "para", "austria.jpg", "Austria", "canoe" },
                    { "brazil", "summer", "brazil.jpg", "Brazil", "cycling" },
                    { "canada", "winter", "canada.jpg", "Canada", "curling" },
                    { "china", "summer", "china.jpg", "China", "diving" },
                    { "cyprus", "youth", "cyprus.jpg", "Cyprus", "breakdancing" },
                    { "finland", "youth", "finland.jpg", "Finland", "skateboarding" },
                    { "france", "youth", "france.jpg", "France", "breakdancing" },
                    { "germany", "summer", "germany.jpg", "Germany", "diving" },
                    { "great_britain", "winter", "great_britain.jpg", "Great Britain", "curling" },
                    { "italy", "winter", "italy.jpg", "Italy", "bobsleigh" },
                    { "jamaica", "winter", "jamaica.jpg", "Jamaica", "bobsleigh" },
                    { "japan", "winter", "japan.jpg", "Japan", "bobsleigh" },
                    { "mexico", "summer", "mexico.jpg", "Mexico", "diving" },
                    { "netherlands", "summer", "netherlands.jpg", "Netherlands", "cycling" },
                    { "pakistan", "para", "pakistan.jpg", "Pakistan", "canoe" },
                    { "portugal", "youth", "portugal.jpg", "Portugal", "skateboarding" },
                    { "russia", "youth", "russia.jpg", "Russia", "breakdancing" },
                    { "slovakia", "youth", "slovakia.jpg", "Slovakia", "skateboarding" },
                    { "sweden", "winter", "sweden.jpg", "Sweden", "curling" },
                    { "thailand", "para", "thailand.jpg", "Thailand", "archery" },
                    { "ukraine", "para", "ukraine.jpg", "Ukraine", "archery" },
                    { "uruguay", "para", "uruguay.jpg", "Uruguay", "archery" },
                    { "usa", "summer", "united_states.jpg", "USA", "cycling" },
                    { "zimbabwe", "para", "zimbabwe.jpg", "Zimbabwe", "canoe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
