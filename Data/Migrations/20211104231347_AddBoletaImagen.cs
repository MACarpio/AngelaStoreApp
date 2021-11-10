using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelaStoreApp.Data.Migrations
{
    public partial class AddBoletaImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "image",
                table: "t_product",
                newName: "imagename");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "t_product",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "t_pago",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "t_pago",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "t_pago",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "t_product");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "t_pago");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "t_pago");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "t_pago");

            migrationBuilder.RenameColumn(
                name: "imagename",
                table: "t_product",
                newName: "image");
        }
    }
}
