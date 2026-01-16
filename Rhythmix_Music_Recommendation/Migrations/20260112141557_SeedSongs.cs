using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class SeedSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicBrainzId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: true),
                    Album = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10f01fef-a01d-4ff1-910b-0eed2b70ffb0", "AQAAAAIAAYagAAAAEEBG/93qe9+aqjCbI5NWKlt/YV6Bw5H+kvM9xxFSIVxL0OURbg0AsuC5jFtcP7mcGw==", "d8b2b7d5-525e-49a7-8bfa-07615af6fe87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16fe078f-1707-4f4c-b800-42ceee94dac0", "AQAAAAIAAYagAAAAEFWlT+7CY+/bSaO+yDl70eW1GXaXepv+yns+h2nUNy4+TamYSyYP2paVKWg0qlt5gQ==", "c2aff5d3-7408-4183-88a3-f6e649bfc2cd" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_MusicBrainzId",
                table: "Songs",
                column: "MusicBrainzId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb493af7-d77a-4754-a821-702317de701d", "AQAAAAIAAYagAAAAEAPeawuNksOn6dyPWreDHck3IpyQr93axTHSSuMh95mtULeztvjPlwxJhrXwjV3k1g==", "00bad995-16ae-41e7-aa3e-19c31a7e179d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2519fd98-05bd-431a-8808-a306b51319b8", "AQAAAAIAAYagAAAAEDS2gPtRPelJaCQUG3t/n8n4GuTsJNnWnq/n+s/S8pys1kKWbRKoE9K1w1Swksfssw==", "a162f288-8195-4f69-ae7a-1621b0ff5f3d" });
        }
    }
}
