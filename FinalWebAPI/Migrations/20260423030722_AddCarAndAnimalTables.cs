using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCarAndAnimalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteFood = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Milage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "FavoriteFood", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Grain", "Female", "Lisa", "Cow" },
                    { 2, 3, "Grass", "Male", "Larry", "Goat" },
                    { 3, 17, "Hay", "Male", "Gold Ship", "Horse" },
                    { 4, 30, "Carrots", "Male", "Bugs", "Bunny" },
                    { 5, 5, "Stuff", "Male", "John Pork", "Pig" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Brand", "Milage", "Model", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, "Ford", 65000, "F-150", "1FTFW1C85MKF12816", 2021 },
                    { 2, "Volkswagen", 325356, "Passat", "WVWJL9AN8AE059036", 2010 },
                    { 3, "Saturn", 426965, "SL", "1G8ZF5284YZ202749", 2000 },
                    { 4, "Chrysler", 183260, "Pacifica", "2A8GF68X88R144021", 2008 },
                    { 5, "Porsche", 54721, "911", "WP0AG2A9XPS252314", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
