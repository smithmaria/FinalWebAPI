using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candles",
                columns: new[] { "CandleId", "Brand", "Description", "FragranceNotes", "Name" },
                values: new object[,]
                {
                    { 1, "Yankee Candle", "Sweet and spicy fragrance reminiscent of a day of baking.", "vanilla bean, chocolate, cocoa, malted sugar", "Vanilla Cupcake" },
                    { 2, "Yankee Candle", "Experience a cozy, secluded coastal escape.", "cottonwood, driftwood, orange blossoms, acacia", "Seaside Woods" },
                    { 3, "Bath and Body Works", "You'll enjoy every bit of this savory, fresh-from-the-oven fragrance—no starter needed.", "baked sourdough, whipped butter, olive oil drizzle", "Homemade Sourdough" },
                    { 4, "Bath and Body Works", "Woodsy, mysterious home fragrance turned rich, refined fragrance icon.", "rich mahogany, black teakwood, dark oak, lavender", "Mahogany Teakwood" },
                    { 5, "Yankee Candle", "As you step into your favorite bakery, scents of fresh Gariguette strawberries topped with vanilla essence and Chantilly cream flood the room.", "strawberry, lemon zest, cake batter, vanilla, white musk, baked notes", "Strawberry Swirl" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamMemberId", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Application Development", "Maria Smith", "Pre-Junior" },
                    { 2, new DateTime(2004, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemical Engineering", "Reese Howard", "Pre-Junior" },
                    { 3, new DateTime(2002, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nursing", "Lauren Riihimaki", "Senior" },
                    { 4, new DateTime(2006, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Music Education", "Peter McWallen", "Sophomore" },
                    { 5, new DateTime(2007, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "English Literature", "Ryan Faulkner", "Freshman" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candles",
                keyColumn: "CandleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candles",
                keyColumn: "CandleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candles",
                keyColumn: "CandleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candles",
                keyColumn: "CandleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candles",
                keyColumn: "CandleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 5);
        }
    }
}
