using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicConnect.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDoctorClinicAssociation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorClinicAssociations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClinicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorClinicAssociations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorClinicAssociations_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorClinicAssociations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinicAssociations_ClinicId",
                table: "DoctorClinicAssociations",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinicAssociations_DoctorId",
                table: "DoctorClinicAssociations",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorClinicAssociations");
        }
    }
}
