using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibrary.Migrations
{
    public partial class new_many_2_many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Daryl Hall" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "John Oates" });

            migrationBuilder.InsertData(
                table: "Music",
                columns: new[] { "Id", "Title", "Year" },
                values: new object[] { 4, "Maneater", 1982 });

            migrationBuilder.InsertData(
                table: "ArtistMusic",
                columns: new[] { "ArtistsId", "MusicsId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "ArtistMusic",
                columns: new[] { "ArtistsId", "MusicsId" },
                values: new object[] { 6, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusic",
                keyColumns: new[] { "ArtistsId", "MusicsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ArtistMusic",
                keyColumns: new[] { "ArtistsId", "MusicsId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Music",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
