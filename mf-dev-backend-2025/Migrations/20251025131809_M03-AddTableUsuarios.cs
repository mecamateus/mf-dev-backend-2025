using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2025.Migrations
{
    /// <inheritdoc />
    public partial class M03AddTableUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Consumos_ConsumoId",
                table: "Consumos");

            migrationBuilder.DropIndex(
                name: "IX_Consumos_ConsumoId",
                table: "Consumos");

            migrationBuilder.DropColumn(
                name: "ConsumoId",
                table: "Consumos");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "ConsumoId",
                table: "Consumos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumos_ConsumoId",
                table: "Consumos",
                column: "ConsumoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Consumos_ConsumoId",
                table: "Consumos",
                column: "ConsumoId",
                principalTable: "Consumos",
                principalColumn: "Id");
        }
    }
}
