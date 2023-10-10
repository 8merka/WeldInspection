using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Weld_Inspection_DAL_Admin.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ResultID = table.Column<int>(type: "integer", nullable: false),
                    DefectType = table.Column<string>(type: "text", nullable: false),
                    LocationOfTheDefectInTheWeld = table.Column<string>(type: "text", nullable: false),
                    SizeAndCharacteristicsOfTheDefect = table.Column<string>(type: "text", nullable: false),
                    SeverityLevelOfTheDefect = table.Column<string>(type: "text", nullable: false),
                    AdditionalComments = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalInspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ResultId = table.Column<int>(type: "integer", nullable: false),
                    DateOfFinalInspection = table.Column<DateOnly>(type: "date", nullable: false),
                    InspectorCommentsAndObservations = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalInspections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentName = table.Column<string>(type: "text", nullable: false),
                    TechnicalSpecificationsOfTheEquipment = table.Column<string>(type: "text", nullable: false),
                    EquipmentAvailability = table.Column<string>(type: "text", nullable: false),
                    CalibrationAndMaintenanceInformation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CostForExecution = table.Column<int>(type: "integer", nullable: false),
                    AdditionalMethodCharacteristics = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeldId = table.Column<int>(type: "integer", nullable: false),
                    MethodId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    InspectionId = table.Column<int>(type: "integer", nullable: false),
                    DateOfInspection = table.Column<DateOnly>(type: "date", nullable: false),
                    isDefective = table.Column<bool>(type: "boolean", nullable: false),
                    InspectorsNotesAndComments = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<decimal>(type: "numeric", nullable: false),
                    ContactInformation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Welds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WelderId = table.Column<int>(type: "integer", nullable: false),
                    DateOfCreationOrModification = table.Column<DateOnly>(type: "date", nullable: false),
                    WeldingType = table.Column<string>(type: "text", nullable: false),
                    MaterialsUsedForWelding = table.Column<string>(type: "text", nullable: false),
                    WeldGeometry = table.Column<string>(type: "text", nullable: false),
                    AdditionalWeldCharacteristics = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welds", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "FinalInspections");

            migrationBuilder.DropTable(
                name: "InspectionEquipment");

            migrationBuilder.DropTable(
                name: "InspectionMethods");

            migrationBuilder.DropTable(
                name: "InspectionResult");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "Welds");
        }
    }
}
