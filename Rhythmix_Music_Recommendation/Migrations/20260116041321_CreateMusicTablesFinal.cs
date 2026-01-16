using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class CreateMusicTablesFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91d43d3-75dd-40a4-9963-f3aba767acbb", "AQAAAAIAAYagAAAAEO2hriVDlpc6oyZeSUP/rGvfeZlaUi6B6E114CcNgXJR241M453OmlHc1/9sMGejQQ==", "605376b0-0988-4dbc-804c-12d966423b0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1628840e-defc-4694-868f-7dd3c01380a9", "AQAAAAIAAYagAAAAEBFzjV7dzPBKAkp/uiWfnQYTObn3tgjeCKdUKx5CsBhtxn7HwwyJvzQ+I1PCjtomKg==", "7eeb781c-b1ef-49af-8333-896610515e66" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe0d064a-8d74-4f26-b332-eab3c507b09a", "AQAAAAIAAYagAAAAENodw64YEGsttP6YwVnWAovHI8KJgKJOvdJu7Bdg+u0IdaFfOo7Q1nOg+kBLBA2r4A==", "6edd2c90-0ba8-4e6c-b3b6-42ab1eb4c77a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a1f4c2-4f5e-4d3b-9c3a-1e2f3a4b5c6d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cc3bb30-8602-462f-9bfb-d7847858689d", "AQAAAAIAAYagAAAAEOCnMx/2DInKiDl1/sOFtUDyFzOcwGs8cD3RgqOLMPqbvrnqJBzyZHjs1YPFVbURJA==", "f832c9c2-4e49-4666-8918-e32b66512bb1" });
        }
    }
}
