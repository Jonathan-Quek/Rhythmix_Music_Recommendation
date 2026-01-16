using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class MakingPlaylistsPrivate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Playlists",
                type: "nvarchar(450)",
                nullable: false
                );

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_UserId",
                table: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Playlists");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb1404b8-6556-4193-b794-11fbef6ac0fc", "AQAAAAIAAYagAAAAELubytJTecKUTeKcO6nDEGEz+r+gd2bRW+vgPwkc4JT81G9WeEWXx1UbTNA8r1tTGg==", "56097d04-f093-497a-9845-3c2263b66f18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a05c5d6-c37f-4f07-b279-f510c28990ea", "AQAAAAIAAYagAAAAEDnJUwcTaL7Am1OxKnkJfEcUtaLiUsyhE0SPPlmr3uLGOzUOqK317O0OxaycxOwFsw==", "8b79c89e-60ed-4bad-b483-88cd20979802" });
        }
    }
}
