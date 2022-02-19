using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_core.Migrations
{
    public partial class dbprestamo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "Prestamos");

            migrationBuilder.AddColumn<int>(
                name: "interes",
                table: "Prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "monto",
                table: "Prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "plazo",
                table: "Prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "prestamo",
                table: "Prestamos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Infopre",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Infopre",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Infopre",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Infopre",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Infopre",
                maxLength: 30,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Infopre",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "interes",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "monto",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "plazo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "prestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Infopre");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Infopre");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Infopre");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Infopre");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Infopre");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Infopre");

            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "Prestamos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
