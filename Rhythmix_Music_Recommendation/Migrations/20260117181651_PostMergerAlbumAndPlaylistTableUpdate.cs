using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class PostMergerAlbumAndPlaylistTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_UserId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistSongs_Playlists_PlaylistId",
                table: "PlaylistSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Albums");

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId1",
                table: "Songs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlaylistId1",
                table: "PlaylistSongs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Playlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Playlists");

            migrationBuilder.AddColumn<Guid>(
                name: "PlaylistId",
                table: "Playlists",
                type: "uniqueidentifier",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Playlists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Album");

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Albums",
                type: "uniqueidentifier",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a7fc3e-584d-4ec4-9552-e105ed994880", "AQAAAAIAAYagAAAAEAa2LO75x9yDXZa8VRXTRFp2f3R9fAnjlrV7eBFi7v1PNIq+jHZSFTuX571JyAn/kQ==", "50ab91ce-1633-440c-98ca-33c98f2b5b92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cdf18f1-3a65-4b10-8821-f41853ffe29c", "AQAAAAIAAYagAAAAEEvwLlEBgZSjpxcRkwdoNejdavyzb9UCem3sXjori9QnIgheEytY3N8G+HL3u3/vbw==", "e2ec5b7d-42ad-4cd1-b08a-5aa5700d3787" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId1",
                table: "Songs",
                column: "AlbumId1");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_PlaylistId1",
                table: "PlaylistSongs",
                column: "PlaylistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistSongs_Playlists_PlaylistId1",
                table: "PlaylistSongs",
                column: "PlaylistId1",
                principalTable: "Playlists",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId1",
                table: "Songs",
                column: "AlbumId1",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistSongs_Playlists_PlaylistId1",
                table: "PlaylistSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId1",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId1",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_PlaylistSongs_PlaylistId1",
                table: "PlaylistSongs");

            migrationBuilder.DropColumn(
                name: "AlbumId1",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "PlaylistId1",
                table: "PlaylistSongs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Playlists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "Playlists",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "Albums",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fad298b8-8d36-43b3-a506-fe68c98129e3", "AQAAAAIAAYagAAAAEFhvWmxARbp4OWjhDbjLTcjvXmYGsEY8y/LW1yQ3hsrIVCpUoa0zwc6uI0GbekkZ8A==", "539f2acd-a9f6-43a6-9190-23f1a3717410" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c44f420-8546-4e53-b6f5-4e12d1acf1bc", "AQAAAAIAAYagAAAAEPfYYQqG65I+zWK4NCT4LJ+QscheUyJPDtyTus4I1FcesLiZskpbnkpijUBZQJanVw==", "a8eb186a-75c9-411e-a41b-ae0c016e0e69" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_AspNetUsers_UserId",
                table: "Playlists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistSongs_Playlists_PlaylistId",
                table: "PlaylistSongs",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "PlaylistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
