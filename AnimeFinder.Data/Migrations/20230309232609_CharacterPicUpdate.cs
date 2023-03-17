using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class CharacterPicUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CharacterImageURL",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CharacterImageURL",
                value: "https://dragonball.guru/wp-content/uploads/2021/01/goku-dragon-ball-guru.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CharacterImageURL",
                value: "https://static.wikia.nocookie.net/naruto/images/d/d6/Naruto_Part_I.png/revision/latest/scale-to-width-down/1200?cb=20210223094656");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CharacterImageURL",
                value: "https://static.wikia.nocookie.net/p__/images/b/be/Yona.jpg/revision/latest?cb=20210602102733&path-prefix=protagonist");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterImageURL",
                table: "Characters");
        }
    }
}
