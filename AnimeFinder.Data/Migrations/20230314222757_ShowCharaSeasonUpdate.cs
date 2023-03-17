using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShowCharaSeasonUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Genre", "Name", "ShowImageURL" },
                values: new object[,]
                {
                    { 4, 0, "Demon Slayer", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974704552/demon-slayer-kimetsu-no-yaiba-vol-10-9781974704552_hr.jpg" },
                    { 5, 3, "Attack on Titan", "https://images.squarespace-cdn.com/content/v1/571abd61e3214001fb3b9966/1631036388773-S5RTHBL1JMSWKM5CLDA2/Attack+on+Titan+-+Before+the+Fall+-+Spinoff+Manga" },
                    { 6, 0, "My Hero Academia", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421582696/my-hero-academia-vol-1-9781421582696_hr.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImageURL", "MainRival", "Name", "ShowId", "StrongestAttack" },
                values: new object[,]
                {
                    { 4, "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/e7fef299-7dc1-43eb-85bd-12218f96803f/de2xrw2-3fcf7ee7-e62f-476a-877b-9db574cabda6.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2U3ZmVmMjk5LTdkYzEtNDNlYi04NWJkLTEyMjE4Zjk2ODAzZlwvZGUyeHJ3Mi0zZmNmN2VlNy1lNjJmLTQ3NmEtODc3Yi05ZGI1NzRjYWJkYTYucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.R88NtAsSUcqtFCFVoaB5Qgp7zMl2YqL3qk3tQNgOObE", "Muzan Kibutsuji", "tanjiro", 4, "Dance of the Fire God" },
                    { 5, "https://static.wikia.nocookie.net/shingekinokyojin/images/3/3c/Eren_Jaeger_%28Anime%29_character_image_%28850%29.png/revision/latest?cb=20201228000236", "Jean Kirstein", "Eren Yeager", 5, "Founding titan form" },
                    { 6, "https://www.nahsvikingsaga.org/wp-content/uploads/2020/11/DEKU.png", "Katsuki Bakugo", "Izuku \"Deku\" Midoriya", 6, "Delaware Detroit Smash" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EpisodeCount", "NumberOfSeasons", "ShowId" },
                values: new object[,]
                {
                    { 4, 44, 2, 4 },
                    { 5, 88, 4, 5 },
                    { 6, 138, 6, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
