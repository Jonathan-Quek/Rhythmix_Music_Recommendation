using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rhythmix_Music_Recommendation.Migrations
{
    /// <inheritdoc />
    public partial class Userregister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserRegister",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserLogin",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserRegister",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserRegister",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserLogin",
                type: "nvarchar(max)",
                nullable: true);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserRegister");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserRegister");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UserRegister",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UserLogin",
                newName: "Name");
        }
    }
}
