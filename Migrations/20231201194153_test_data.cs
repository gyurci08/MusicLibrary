using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibrary.Migrations
{
    public partial class test_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "R-GO" },
                    { 3, "Desh" },
                    { 4, "Azariah" }
                });

            migrationBuilder.InsertData(
                table: "Music",
                columns: new[] { "Id", "Title", "Year" },
                values: new object[,]
                {
                    { 2, "Ballag a katona", 1985 },
                    { 3, "Eldorádó", 2023 }
                });

            migrationBuilder.InsertData(
                table: "ArtistMusic",
                columns: new[] { "ArtistsId", "MusicsId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "ArtistMusic",
                columns: new[] { "ArtistsId", "MusicsId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "ArtistMusic",
                columns: new[] { "ArtistsId", "MusicsId" },
                values: new object[] { 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusic",
                keyColumns: new[] { "ArtistsId", "MusicsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ArtistMusic",
                keyColumns: new[] { "ArtistsId", "MusicsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ArtistMusic",
                keyColumns: new[] { "ArtistsId", "MusicsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Music",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Music",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
