using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Models.Migrations
{
    public partial class Change_Model_Sacerdote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Sacerdote",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaLlegadaParroquia",
                table: "Sacerdote",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Sacerdote",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRetiradaParroquia",
                table: "Sacerdote",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PuestoSacerdoteId",
                table: "Sacerdote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PuestoSacerdote",
                columns: table => new
                {
                    PuestoSacerdoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombrePuesto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuestoSacerdote", x => x.PuestoSacerdoteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sacerdote_PuestoSacerdoteId",
                table: "Sacerdote",
                column: "PuestoSacerdoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sacerdote_PuestoSacerdote_PuestoSacerdoteId",
                table: "Sacerdote",
                column: "PuestoSacerdoteId",
                principalTable: "PuestoSacerdote",
                principalColumn: "PuestoSacerdoteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sacerdote_PuestoSacerdote_PuestoSacerdoteId",
                table: "Sacerdote");

            migrationBuilder.DropTable(
                name: "PuestoSacerdote");

            migrationBuilder.DropIndex(
                name: "IX_Sacerdote_PuestoSacerdoteId",
                table: "Sacerdote");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Sacerdote");

            migrationBuilder.DropColumn(
                name: "FechaLlegadaParroquia",
                table: "Sacerdote");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Sacerdote");

            migrationBuilder.DropColumn(
                name: "FechaRetiradaParroquia",
                table: "Sacerdote");

            migrationBuilder.DropColumn(
                name: "PuestoSacerdoteId",
                table: "Sacerdote");
        }
    }
}
