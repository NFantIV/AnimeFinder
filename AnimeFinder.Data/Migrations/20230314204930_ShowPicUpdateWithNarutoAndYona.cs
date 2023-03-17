using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShowPicUpdateWithNarutoAndYona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowImageURL",
                value: "https://static.wikia.nocookie.net/p__/images/8/8e/Dbz_group.jpg/revision/latest?cb=20141002145405&path-prefix=protagonist");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowImageURL",
                value: "https://static.wikia.nocookie.net/naruto/images/8/81/Vol72.png/revision/latest?cb=20210331141503");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowImageURL",
                value: "http://prodimage.images-bn.com/pimages/9781421587813_p0_v1_s1200x630.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowImageURL",
                value: null);
        }
    }
}
