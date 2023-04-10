using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM_8_CRUD.Migrations
{
    public partial class CriacaoInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "telefone",
                table: "Pessoa",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "telefone",
                table: "Pessoa",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
