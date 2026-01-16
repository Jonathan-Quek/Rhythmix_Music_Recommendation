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
                    ReleaseYear = table.Column<int>(type: "int", nullable: true)
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
                values: new object[] { "9fcc7cad-a39c-4022-be5f-c4c000ce0c7c", "AQAAAAIAAYagAAAAENOrBK37JlnrIqdiP5/VW8dAlji2ncTZS5IyPyYDDsccbYDigHCTUZMRWYgeCLn1Ww==", "a07114f5-5d9f-474d-b249-e31c38015ead" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeb49655-c284-4a04-9960-9387819658fa", "AQAAAAIAAYagAAAAEErwmMApyHpCBjW3wXMlUkrOAAEGNRNpVMbr+Twg9VB6+cHW5VE98idoi8uUZMPhJg==", "8d47348a-fad5-48ef-8fe4-d784b9e32e21" });

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
