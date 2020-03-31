using Microsoft.EntityFrameworkCore.Migrations;

namespace Severino.Data.Migrations
{
    public partial class chat_bugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "conversaId",
                table: "Mensagem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_conversaId",
                table: "Mensagem",
                column: "conversaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagem_Conversa_conversaId",
                table: "Mensagem",
                column: "conversaId",
                principalTable: "Conversa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagem_Conversa_conversaId",
                table: "Mensagem");

            migrationBuilder.DropIndex(
                name: "IX_Mensagem_conversaId",
                table: "Mensagem");

            migrationBuilder.DropColumn(
                name: "conversaId",
                table: "Mensagem");
        }
    }
}
