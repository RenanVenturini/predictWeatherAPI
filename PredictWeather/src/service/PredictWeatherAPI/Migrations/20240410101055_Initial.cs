using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PredictWeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbDispositivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comando = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDispositivo", x => x.Id);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbDispositivo");

            migrationBuilder.DropTable(
                name: "TbUsuario");
        }
    }
}
