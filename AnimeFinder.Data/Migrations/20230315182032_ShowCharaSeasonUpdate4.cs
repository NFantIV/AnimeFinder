using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShowCharaSeasonUpdate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Genre", "Name", "ShowImageURL" },
                values: new object[,]
                {
                    { 13, 0, "Jujutsu Kaisen", "https://static.wikia.nocookie.net/jujutsu-kaisen/images/0/0e/Volume_1.png/revision/latest?cb=20180719214641" },
                    { 14, 2, "Zoids Chaotic Century", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg" },
                    { 15, 3, "One Punch Man", "https://upload.wikimedia.org/wikipedia/en/c/c3/OnePunchMan_manga_cover.png" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImageURL", "MainRival", "Name", "ShowId", "StrongestAttack" },
                values: new object[,]
                {
                    { 13, "https://i.pinimg.com/originals/dc/eb/9d/dceb9d37b7f174925b3e0a562191e07b.jpg", "Aoi Todo", "Yuji Itadori", 13, "Manji Kick" },
                    { 14, "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg", "Raven", "Van Flyheight", 14, "Laser Blades" },
                    { 15, "https://static.wikia.nocookie.net/supermarioglitchy4/images/c/c3/Saitama_Profile.png/revision/latest?cb=20220521022745", "Boros", "Saitama", 15, "Serious Table Flip" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EpisodeCount", "NumberOfSeasons", "ShowId" },
                values: new object[,]
                {
                    { 13, 1, 24, 13 },
                    { 14, 67, 2, 14 },
                    { 15, 24, 2, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
