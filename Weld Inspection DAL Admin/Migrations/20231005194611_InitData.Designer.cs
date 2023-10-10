﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Weld_Inspection_DAL_Admin.Data;

#nullable disable

namespace Weld_Inspection_DAL_Admin.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005194611_InitData")]
    partial class InitData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.Defects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalComments")
                        .HasColumnType("text");

                    b.Property<string>("DefectType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LocationOfTheDefectInTheWeld")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResultID")
                        .HasColumnType("integer");

                    b.Property<string>("SeverityLevelOfTheDefect")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SizeAndCharacteristicsOfTheDefect")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.FinalInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfFinalInspection")
                        .HasColumnType("date");

                    b.Property<string>("InspectorCommentsAndObservations")
                        .HasColumnType("text");

                    b.Property<int>("ResultId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("FinalInspections");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.InspectionEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CalibrationAndMaintenanceInformation")
                        .HasColumnType("text");

                    b.Property<string>("EquipmentAvailability")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EquipmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TechnicalSpecificationsOfTheEquipment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("InspectionEquipment");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.InspectionMethods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalMethodCharacteristics")
                        .HasColumnType("text");

                    b.Property<int>("CostForExecution")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EquipmentID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("InspectionMethods");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.InspectionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfInspection")
                        .HasColumnType("date");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("InspectionId")
                        .HasColumnType("integer");

                    b.Property<string>("InspectorsNotesAndComments")
                        .HasColumnType("text");

                    b.Property<int>("MethodId")
                        .HasColumnType("integer");

                    b.Property<int>("WeldId")
                        .HasColumnType("integer");

                    b.Property<bool>("isDefective")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("InspectionResult");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.Inspectors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirdth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.Property<int>("YearsOfWorking")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Inspectors");
                });

            modelBuilder.Entity("Weld_Inspection_DAL_Admin.Models.Welds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalWeldCharacteristics")
                        .HasColumnType("text");

                    b.Property<DateOnly>("DateOfCreationOrModification")
                        .HasColumnType("date");

                    b.Property<string>("MaterialsUsedForWelding")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WeldGeometry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WelderId")
                        .HasColumnType("integer");

                    b.Property<string>("WeldingType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Welds");
                });
#pragma warning restore 612, 618
        }
    }
}
