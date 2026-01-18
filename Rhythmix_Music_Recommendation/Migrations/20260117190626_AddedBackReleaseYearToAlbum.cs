using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class AddedBackReleaseYearToAlbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "74d7dc50-d3ef-4b64-a4f2-6eb35efd5cb0", "AQAAAAIAAYagAAAAEEM7rZxmGW1cm18Ndc3kHGj2ZIaj1BPc9rZYTyr+J9GWWzEsfVMlWj3iznMoyZ9Ruw==", "a1b99c2f-0b89-4345-90b3-33bd5f054071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34442f92-4658-4868-9b83-4d9cc7fbcccb", "AQAAAAIAAYagAAAAEMOdccYp/ZnI9NkUNjj4BiXynKFbppo/lXVGq3bcjq9b4QlEMA9T0f+H7B9RxnBe1Q==", "6bc627db-659b-4d2a-9eb7-4d9b1041e0cc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Albums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e037f81d-5c92-4472-b8ef-3da5dc45e5e6", "AQAAAAIAAYagAAAAECl9frwrICxfli5UnvIkJvi0F/uHHhbNqRf3ifbPSt3cx2SCHFgOWpYgOnYvvmSu7A==", "01b3411f-af92-488d-9b1b-a0c82bd4e8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5944b13e-1249-4477-a723-d58527b9f375", "AQAAAAIAAYagAAAAEI5o4RON7n20xKZT7kN2W8NuO97gasJNZJKGicsMsa4fOdOpRQJ63DuhhvH84wp7FA==", "98ddb231-d382-4e3b-86c1-d03c6523f4ed" });
        }
    }
}
