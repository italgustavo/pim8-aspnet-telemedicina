using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM_8_CRUD.Migrations
{
    public partial class telefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoas_PessoaId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                newName: "IX_Endereco_PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PessoasTeste",
                table: "PessoasTeste",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecoTeste",
                table: "EnderecoTeste",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "EnderecoTeste",
                column: "PessoaId",
                principalTable: "PessoasTeste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "EnderecoTeste");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                newName: "IX_Endereco_PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
