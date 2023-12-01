using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibrary.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtistMusics",
                columns: new[] { "ArtistId", "MusicId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusics",
                keyColumns: new[] { "ArtistId", "MusicId" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
