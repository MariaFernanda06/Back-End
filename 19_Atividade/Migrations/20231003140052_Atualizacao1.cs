using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_Atividade.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Preco",
                table: "Produtos",
                type: "INTEGER",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldMaxLength: 200);
        }
    }
}
