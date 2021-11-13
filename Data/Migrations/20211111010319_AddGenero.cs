using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelaStoreApp.Data.Migrations
{
    public partial class AddGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "t_product",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "t_product");
        }
    }
}
