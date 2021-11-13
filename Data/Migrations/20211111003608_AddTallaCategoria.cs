using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelaStoreApp.Data.Migrations
{
    public partial class AddTallaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "t_product",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Talla",
                table: "t_product",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "t_product");

            migrationBuilder.DropColumn(
                name: "Talla",
                table: "t_product");
        }
    }
}
