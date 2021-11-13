using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelaStoreApp.Data.Migrations
{
    public partial class detalletalla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Talla",
                table: "t_order_detail",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Talla",
                table: "t_order_detail");
        }
    }
}
