using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weld_Inspection_DAL_Admin.Migrations
{
    /// <inheritdoc />
    public partial class AddLoginAndPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Inspectors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Inspectors",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Inspectors");
        }
    }
}
