using Microsoft.EntityFrameworkCore.Migrations;

namespace Severino.Data.Migrations
{
    public partial class RequisicaoResposta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Requisicao_RequisicaoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RequisicaoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RequisicaoId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "RequisicaoReposta",
                columns: table => new
                {
                    RequisicaoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisicaoReposta", x => new { x.RequisicaoId, x.UsuarioId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequisicaoReposta");

            migrationBuilder.AddColumn<long>(
                name: "RequisicaoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RequisicaoId",
                table: "AspNetUsers",
                column: "RequisicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Requisicao_RequisicaoId",
                table: "AspNetUsers",
                column: "RequisicaoId",
                principalTable: "Requisicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
