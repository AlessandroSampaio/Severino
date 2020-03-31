using Microsoft.EntityFrameworkCore.Migrations;

namespace Severino.Data.Migrations
{
    public partial class RequisicaoResposta_bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RequisicaoId1",
                table: "RequisicaoReposta",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId1",
                table: "RequisicaoReposta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequisicaoReposta_RequisicaoId1",
                table: "RequisicaoReposta",
                column: "RequisicaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_RequisicaoReposta_UsuarioId1",
                table: "RequisicaoReposta",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RequisicaoReposta_Requisicao_RequisicaoId1",
                table: "RequisicaoReposta",
                column: "RequisicaoId1",
                principalTable: "Requisicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequisicaoReposta_AspNetUsers_UsuarioId1",
                table: "RequisicaoReposta",
                column: "UsuarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequisicaoReposta_Requisicao_RequisicaoId1",
                table: "RequisicaoReposta");

            migrationBuilder.DropForeignKey(
                name: "FK_RequisicaoReposta_AspNetUsers_UsuarioId1",
                table: "RequisicaoReposta");

            migrationBuilder.DropIndex(
                name: "IX_RequisicaoReposta_RequisicaoId1",
                table: "RequisicaoReposta");

            migrationBuilder.DropIndex(
                name: "IX_RequisicaoReposta_UsuarioId1",
                table: "RequisicaoReposta");

            migrationBuilder.DropColumn(
                name: "RequisicaoId1",
                table: "RequisicaoReposta");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "RequisicaoReposta");
        }
    }
}
