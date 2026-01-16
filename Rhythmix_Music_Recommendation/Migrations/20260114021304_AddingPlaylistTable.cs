using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class AddingPlaylistTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicBrainzId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.PlaylistId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "751ce267-a662-4ca4-9e5c-4500acdba618", "AQAAAAIAAYagAAAAEF/nHhNsyviRSTaNERslpko+51kqRcK1tL7hlNCfXgvDLB2VosjAiui7vY4isCYIcA==", "cecc3fb9-5512-4793-9b90-c3b4a5a848e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bad62bde-0b64-4f29-aa0d-48c97c789e7f", "AQAAAAIAAYagAAAAEKd8NvkSPcGPtAKCYpKDoPd6/AcN77NL49Og49ZI/KYJr8i907bu6lb08glQhJypfg==", "a75ae08d-1609-4dd8-96c8-4025e4a2fb80" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlaylistId",
                table: "Songs",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_PlaylistId",
                table: "Songs",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "PlaylistId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_PlaylistId",
                table: "Songs");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Songs_PlaylistId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Songs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3167188-76aa-487e-87e8-9a3483a64125", "AQAAAAIAAYagAAAAEHyB0kVowhTaIo3W9E572bsepOBBRxkANzhv0yplauHqok2IEXtUnl9iCrLbUxeHHA==", "b17b7cb6-de47-4249-ad54-a579a4d7b109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c97fd79-5bd2-4763-a2f8-d31b3f6bdb59", "AQAAAAIAAYagAAAAEMQaXYFs/3n219fj3wFonH2RSANob5GntRiVrQNavf3ImTPXe3VeQSY3vIFDec1zwA==", "f0955376-7b3c-4066-94ce-2b668aadd38a" });
        }
    }
}
