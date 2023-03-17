using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShowCharaSeasonUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowId",
                value: 9);

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Genre", "Name", "ShowImageURL" },
                values: new object[,]
                {
                    { 10, 0, "Black Cover", "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg" },
                    { 11, 3, "Yu-Gi-Oh!", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421579252/yu-gi-oh-3-in-1-edition-vol-2-9781421579252_hr.jpg" },
                    { 12, 3, "Pokemon", "https://static.wikia.nocookie.net/black60dragon/images/6/64/Pokémon.jpg/revision/latest?cb=20181202172826" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImageURL", "MainRival", "Name", "ShowId", "StrongestAttack" },
                values: new object[,]
                {
                    { 10, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvvZzLVq6oXM5AwfkwRsNTCEOxOK5OZcoZ_g&usqp=CAU", "Yuno", "Asta", 10, "Black Asta" },
                    { 11, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_XEW5y-dD-I6R7KdD_0VGFdzK0JBkq0pzxQ&usqp=CAU", "Seto Kaiba", "Yugi \"The Pharaoh\" Mutou ", 11, "Dark Magician Attack" },
                    { 12, "https://uploads-ssl.webflow.com/63851d467dc151a9f46a992b/638630e0b32ca1abefa9eb80_6256e4322354f3d35b2a268a_ash%2520ketchum%2520pose.jpeg", "Gary Oak", "Ash Ketchum", 12, "Volt Attack (Pikachu)" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EpisodeCount", "NumberOfSeasons", "ShowId" },
                values: new object[,]
                {
                    { 10, 170, 4, 10 },
                    { 11, 224, 5, 11 },
                    { 12, 1232, 25, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowId",
                value: 8);
        }
    }
}
