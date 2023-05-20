using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class pictureidUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "level",
                table: "Tbl_Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "extensionArchivo",
                table: "Tbl_Documentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Tbl_Documentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                columns: new[] { "create_date", "level" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "level",
                table: "Tbl_Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "extensionArchivo",
                table: "Tbl_Documentos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Tbl_Documentos",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                columns: new[] { "create_date", "level" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
