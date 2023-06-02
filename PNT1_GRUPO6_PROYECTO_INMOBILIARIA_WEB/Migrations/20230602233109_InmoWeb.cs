using Microsoft.EntityFrameworkCore.Migrations;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB.Migrations
{
    public partial class InmoWeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PropiedadAlquiler",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true),
                    Precio = table.Column<double>(nullable: false),
                    FotoPropiedadUrl = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Usuario = table.Column<int>(nullable: true),
                    CantMeses = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropiedadAlquiler", x => x.IdPropiedad);
                    table.ForeignKey(
                        name: "FK_PropiedadAlquiler_Usuarios_Usuario",
                        column: x => x.Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropiedadVenta",
                columns: table => new
                {
                    IdPropiedad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true),
                    Precio = table.Column<double>(nullable: false),
                    FotoPropiedadUrl = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Usuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropiedadVenta", x => x.IdPropiedad);
                    table.ForeignKey(
                        name: "FK_PropiedadVenta_Usuarios_Usuario",
                        column: x => x.Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadAlquiler_Usuario",
                table: "PropiedadAlquiler",
                column: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadVenta_Usuario",
                table: "PropiedadVenta",
                column: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropiedadAlquiler");

            migrationBuilder.DropTable(
                name: "PropiedadVenta");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
