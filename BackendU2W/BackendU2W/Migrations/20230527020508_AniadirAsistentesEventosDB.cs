using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class AniadirAsistentesEventosDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "asistentes",
                table: "Tbl_Eventos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "asistentes", "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { 0L, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 5, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "asistentes", "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { 0L, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 11, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 5, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "asistentes", "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { 0L, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 5, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "asistentes", "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { 0L, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 1, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(422), new DateTime(2023, 5, 27, 4, 5, 8, 665, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "asistentes",
                table: "Tbl_Eventos");

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
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 8, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "create_date", "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 29, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1609) });

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
        }
    }
}
