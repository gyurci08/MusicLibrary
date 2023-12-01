using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibrary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    MusicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.MusicId);
                });

            migrationBuilder.CreateTable(
                name: "ArtistMusics",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    MusicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistMusics", x => new { x.ArtistId, x.MusicId });
                    table.ForeignKey(
                        name: "FK_ArtistMusics_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistMusics_Musics_MusicId",
                        column: x => x.MusicId,
                        principalTable: "Musics",
                        principalColumn: "MusicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[] { 1, "Edda Művek" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "MusicId", "Title", "Year" },
                values: new object[] { 1, "Éjjel érkezem", 1986 });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistMusics_MusicId",
                table: "ArtistMusics",
                column: "MusicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistMusics");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}
