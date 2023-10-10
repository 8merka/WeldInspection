using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weld_Inspection_DAL_Admin.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactInformation",
                table: "Inspectors");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Inspectors",
                newName: "Phone");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirdth",
                table: "Inspectors",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Inspectors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Inspectors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Inspectors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearsOfWorking",
                table: "Inspectors",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirdth",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "YearsOfWorking",
                table: "Inspectors");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Inspectors",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "ContactInformation",
                table: "Inspectors",
                type: "text",
                nullable: true);
        }
    }
}
