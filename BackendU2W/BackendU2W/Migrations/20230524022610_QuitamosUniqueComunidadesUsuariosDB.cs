using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class QuitamosUniqueComunidadesUsuariosDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "IX_UniqueFKs",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 8, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 29, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ComunidadesUsuarios_id_com",
                table: "Tbl_ComunidadesUsuarios",
                column: "id_com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tbl_ComunidadesUsuarios_id_com",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.AddUniqueConstraint(
                name: "IX_UniqueFKs",
                table: "Tbl_ComunidadesUsuarios",
                columns: new[] { "id_com", "id_usu" });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 5, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 7, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 5, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 5, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 28, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 5, 23, 1, 8, 38, 528, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
