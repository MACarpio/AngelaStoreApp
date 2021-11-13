using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelaStoreApp.Data.Migrations
{
    public partial class Tallaproforma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Talla",
                table: "t_product");

            migrationBuilder.AddColumn<string>(
                name: "Talla",
                table: "t_proforma",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Talla",
                table: "t_proforma");

            migrationBuilder.AddColumn<string>(
                name: "Talla",
                table: "t_product",
                type: "text",
                nullable: true);
        }
    }
}
