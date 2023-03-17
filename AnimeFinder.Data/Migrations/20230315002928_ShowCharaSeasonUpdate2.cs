using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShowCharaSeasonUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Genre", "Name", "ShowImageURL" },
                values: new object[,]
                {
                    { 7, 0, "One Piece", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974722891/one-piece-vol-97-9781974722891_hr.jpg" },
                    { 8, 0, "Bleach", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421510439/bleach-vol-19-9781421510439_hr.jpg" },
                    { 9, 3, "Hunter x Hunter", "https://upload.wikimedia.org/wikipedia/en/0/0f/Hunter_x_Hunter_cover_-_vol1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImageURL", "MainRival", "Name", "ShowId", "StrongestAttack" },
                values: new object[,]
                {
                    { 7, "https://static.wikia.nocookie.net/onepiece/images/e/e5/Monkey_D._Luffy_Anime_Pre_Timeskip_Infobox.png/revision/latest?cb=20230218134949", "Blackbeard", "Luffy", 7, "Gum-Gum Monkey God Gun" },
                    { 8, "https://static.wikia.nocookie.net/mcleodgaming/images/3/3e/Ichigo.png/revision/latest?cb=20200709232729", "Sōsuke Aizen", "Ichigo", 8, "Getsuga Tenshō" },
                    { 9, "https://www.giantbomb.com/a/uploads/scale_small/2/27436/2722697-gon_freecss_2617.jpg", "Killua Zoldyck", "Gon", 8, "Rock-Paper-Scissors (Rock)" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EpisodeCount", "NumberOfSeasons", "ShowId" },
                values: new object[,]
                {
                    { 7, 1053, 20, 7 },
                    { 8, 366, 8, 8 },
                    { 9, 148, 6, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
