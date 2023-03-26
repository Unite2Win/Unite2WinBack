using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class AniadirCampoNombreApellidoUsuarioDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Tbl_Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "Tbl_Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                columns: new[] { "name", "surname" },
                values: new object[] { "Usuario1", "Usuario1" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                columns: new[] { "name", "surname" },
                values: new object[] { "Usuario2", "Usuario2" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                columns: new[] { "name", "surname" },
                values: new object[] { "Usuario3", "Usuario3" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                columns: new[] { "name", "surname" },
                values: new object[] { "Usuario4", "Usuario4" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                columns: new[] { "name", "surname" },
                values: new object[] { "Admin", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "surname",
                table: "Tbl_Usuarios");
        }
    }
}
