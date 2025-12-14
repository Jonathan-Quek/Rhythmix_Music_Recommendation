using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataPlease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    

            migrationBuilder.InsertData(
                table: "StaffLogin",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 18, 44, 7, 202, DateTimeKind.Local).AddTicks(5323), "System", "Zong Han", "admin123", new DateTime(2025, 12, 14, 18, 44, 7, 202, DateTimeKind.Local).AddTicks(5343), "System" });

            migrationBuilder.InsertData(
                table: "UserRegister",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 18, 44, 7, 202, DateTimeKind.Local).AddTicks(5782), "System", "Jonathan@Quek.ZhiYong", "password1", new DateTime(2025, 12, 14, 18, 44, 7, 202, DateTimeKind.Local).AddTicks(5786), "System", "Jonathan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffLogin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRegister",
                keyColumn: "Id",
                keyValue: 1);

      
        }
    }
}
