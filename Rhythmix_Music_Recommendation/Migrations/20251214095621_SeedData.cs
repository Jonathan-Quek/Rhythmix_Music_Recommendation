using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "StaffLogin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "StaffLogin",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 17, 56, 16, 655, DateTimeKind.Local).AddTicks(4323), "System", "Zong Han", "admin123", new DateTime(2025, 12, 14, 17, 56, 16, 655, DateTimeKind.Local).AddTicks(4342), "System" });

            migrationBuilder.InsertData(
                table: "UserRegister",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 17, 56, 16, 655, DateTimeKind.Local).AddTicks(5228), "System", "Jonathan@Quek.ZhiYong", "password1", new DateTime(2025, 12, 14, 17, 56, 16, 655, DateTimeKind.Local).AddTicks(5236), "System", "Jonathan" });
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "StaffLogin");
        }
    }
}
