using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Severino.Data.Migrations
{
    public partial class Requisicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.AddColumn<double>(
                name: "AvaliacaoContratante",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AvaliacaoPrestador",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PrestadorDeServico",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RequisicaoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Requisicao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Detalhes = table.Column<string>(nullable: true),
                    ValorRemuneracao = table.Column<double>(nullable: false),
                    DataInicial = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    AutorId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requisicao_AspNetUsers_AutorId",
                        column: x => x.AutorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RequisicaoId",
                table: "AspNetUsers",
                column: "RequisicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Requisicao_AutorId",
                table: "Requisicao",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Requisicao_RequisicaoId",
                table: "AspNetUsers",
                column: "RequisicaoId",
                principalTable: "Requisicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Requisicao_RequisicaoId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Requisicao");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RequisicaoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AvaliacaoContratante",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AvaliacaoPrestador",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrestadorDeServico",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RequisicaoId",
                table: "AspNetUsers");
        }
    }
}
