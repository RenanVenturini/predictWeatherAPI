using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PredictWeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbDispositivo",
                columns: table => new
                {
                    DispositivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComandosDisponiveis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDispositivo", x => x.DispositivoId);
                });

            migrationBuilder.CreateTable(
                name: "TbUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbMedicaoChuva",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DispositivoId = table.Column<int>(type: "int", nullable: false),
                    data_hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    volumetria_chuva = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbMedicaoChuva", x => x.MedicaoId);
                    table.ForeignKey(
                        name: "FK_TbMedicaoChuva_TbDispositivo_DispositivoId",
                        column: x => x.DispositivoId,
                        principalTable: "TbDispositivo",
                        principalColumn: "DispositivoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbMedicaoChuva_DispositivoId",
                table: "TbMedicaoChuva",
                column: "DispositivoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbMedicaoChuva");

            migrationBuilder.DropTable(
                name: "TbUsuario");

            migrationBuilder.DropTable(
                name: "TbDispositivo");
        }
    }
}
