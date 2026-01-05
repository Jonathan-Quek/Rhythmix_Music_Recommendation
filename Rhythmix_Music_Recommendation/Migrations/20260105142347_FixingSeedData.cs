using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class FixingSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffLogin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRegister",
                keyColumn: "Id",
                keyValue: 1);

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
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2519fd98-05bd-431a-8808-a306b51319b8", "test@mail.com", "John", "Doe", "TEST@MAIL.COM", "TEST@MAIL.COM", "AQAAAAIAAYagAAAAEDS2gPtRPelJaCQUG3t/n8n4GuTsJNnWnq/n+s/S8pys1kKWbRKoE9K1w1Swksfssw==", "a162f288-8195-4f69-ae7a-1621b0ff5f3d", "test@mail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c435d622-c431-4a08-9bcb-1bf20103018a", "AQAAAAIAAYagAAAAEJd7E7DRuUzUH8iaw4WLUNrJR7PtUF2PwI9kiyH6YMHsBcdholzNQHriiSrtxe9D5w==", "59362e99-934b-4f40-a98f-c3ae9d6c7906" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bf1f2879-847f-4c7b-9724-ea34ac527a0f", "jonathan@mail.com", "Jonathan", "Quek", "JONATHAN@MAIL.COM", "JONQUEK", "AQAAAAIAAYagAAAAENabUzbGD+99R0/3ISRa/aLwGgdvCmZzIUlxPk2pVdHF79FaUtkdlbsRaVuNp4iKZw==", "3fe15e6a-9d8d-4a1f-9c70-c08caabb5113", "JonQuek" });

            migrationBuilder.InsertData(
                table: "StaffLogin",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(4907), "System", "Zong Han", "admin123", new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(4958), "System" });

            migrationBuilder.InsertData(
                table: "UserRegister",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "Password", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[] { 1, new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(6259), "System", "Jonathan@Quek.ZhiYong", "password1", new DateTime(2025, 12, 14, 20, 32, 12, 854, DateTimeKind.Local).AddTicks(6271), "System", "Jonathan" });
        }
    }
}
