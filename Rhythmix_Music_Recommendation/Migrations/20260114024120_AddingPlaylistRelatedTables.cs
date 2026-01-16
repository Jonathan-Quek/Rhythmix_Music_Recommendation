using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class AddingPlaylistRelatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "PlaylistSongs",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistSongs", x => new { x.PlaylistId, x.SongId });
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "PlaylistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b9eb31-bd38-4667-8945-0df6113016b2", "AQAAAAIAAYagAAAAEIFxUUaIUbsraSTRAYko8tqaYO9WFOCVo+17ToS+Z1rz3J0+SSL6u2uM3S+Ym8Tr2Q==", "e03a6c78-7505-40d1-b0d0-cd6ef033acaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33972e24-e07f-472b-b098-4d9e7fab686d", "AQAAAAIAAYagAAAAEMcY4e10lo6g4mI+45zIKqfIM/FmoMdnGDWkjxszs6a3B3V9GDdPiBu7sBzKJBMRQQ==", "4fb11075-736c-4265-9fae-6c8d179d1f1c" });

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_SongId",
                table: "PlaylistSongs",
                column: "SongId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistSongs");

            migrationBuilder.DropTable(
                name: "Playlists");

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
