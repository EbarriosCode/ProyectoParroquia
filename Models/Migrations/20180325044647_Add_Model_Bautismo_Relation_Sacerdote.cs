using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Models.Migrations
{
    public partial class Add_Model_Bautismo_Relation_Sacerdote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bautismo",
                columns: table => new
                {
                    BautismoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartamentoId = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    FechaBautismo = table.Column<DateTime>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Folio = table.Column<string>(nullable: true),
                    Libro = table.Column<string>(nullable: true),
                    Madrina = table.Column<string>(nullable: true),
                    MunicipioId = table.Column<int>(nullable: true),
                    NombreBautizado = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    PadresBautizado = table.Column<string>(nullable: true),
                    Padrino = table.Column<string>(nullable: true),
                    Partida = table.Column<string>(nullable: true),
                    SacerdoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bautismo", x => x.BautismoId);
                    table.ForeignKey(
                        name: "FK_Bautismo_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bautismo_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bautismo_Sacerdote_SacerdoteId",
                        column: x => x.SacerdoteId,
                        principalTable: "Sacerdote",
                        principalColumn: "SacerdoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bautismo_DepartamentoId",
                table: "Bautismo",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bautismo_MunicipioId",
                table: "Bautismo",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Bautismo_SacerdoteId",
                table: "Bautismo",
                column: "SacerdoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bautismo");
        }
    }
}
