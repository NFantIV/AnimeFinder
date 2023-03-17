using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Genre", "Name" },
                values: new object[,]
                {
                    { 1, 0, "DragonBall Z" },
                    { 2, 0, "Naruto" },
                    { 3, 1, "Yona of The Dawn" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "MainRival", "Name", "ShowId", "StrongestAttack" },
                values: new object[,]
                {
                    { 1, "Vegeta", "Goku", 1, "Kamehameha" },
                    { 2, "Sasuke", "Naruto", 2, "Rasengan" },
                    { 3, "Zoey", "Yona", 3, "Archery" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EpisodeCount", "NumberOfSeasons", "ShowId" },
                values: new object[,]
                {
                    { 1, 276, 9, 1 },
                    { 2, 726, 26, 2 },
                    { 3, 24, 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
