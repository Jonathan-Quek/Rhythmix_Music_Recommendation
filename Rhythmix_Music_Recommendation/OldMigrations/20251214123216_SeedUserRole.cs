using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c435d622-c431-4a08-9bcb-1bf20103018a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJd7E7DRuUzUH8iaw4WLUNrJR7PtUF2PwI9kiyH6YMHsBcdholzNQHriiSrtxe9D5w==", null, false, "59362e99-934b-4f40-a98f-c3ae9d6c7906", false, "admin@localhost.com" },
                    { "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d", 0, "bf1f2879-847f-4c7b-9724-ea34ac527a0f", "jonathan@mail.com", true, "Jonathan", "Quek", false, null, "JONATHAN@MAIL.COM", "JONQUEK", "AQAAAAIAAYagAAAAENabUzbGD+99R0/3ISRa/aLwGgdvCmZzIUlxPk2pVdHF79FaUtkdlbsRaVuNp4iKZw==", null, false, "3fe15e6a-9d8d-4a1f-9c70-c08caabb5113", false, "JonQuek" }
                });

            migrationBuilder.UpdateData(
                table: "StaffLogin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(4907), new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "UserRegister",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "StaffLogin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 19, 29, 1, 112, DateTimeKind.Local).AddTicks(9541), new DateTime(2025, 12, 14, 19, 29, 1, 112, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "UserRegister",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 19, 29, 1, 112, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 12, 14, 19, 29, 1, 112, DateTimeKind.Local).AddTicks(9951) });
        }
    }
}
