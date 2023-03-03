using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaComunidadesBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Comunidades",
                columns: table => new
                {
                    id_com = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    clave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    banner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comunidades", x => x.id_com);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Comunidades",
                columns: new[] { "id_com", "banner", "clave", "create_date", "delete_date", "descripcion", "last_modified", "nombre", "picture" },
                values: new object[,]
                {
                    { 1, "banner1", "12345", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad1", null, "Comunidad1", "imagen1" },
                    { 2, "banner2", "12345", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad2", null, "Comunidad2", "imagen2" },
                    { 3, "banner3", "12345", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, "Comunidad3", "imagen3" },
                    { 4, "banner4", "12345", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad4", null, "Comunidad4", "imagen4" }
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Comunidades");

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
