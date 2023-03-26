using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class AniadirCampoEmailYUsuAdminDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Tbl_Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                columns: new[] { "create_date", "email" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "usuario1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                columns: new[] { "create_date", "email" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "usuario2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                columns: new[] { "create_date", "email" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "usuario3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                columns: new[] { "create_date", "email" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "usuario4@gmail.com" });

            migrationBuilder.InsertData(
                table: "Tbl_Usuarios",
                columns: new[] { "id_usu", "active", "create_date", "delete_date", "email", "last_login", "last_modified", "level", "nick", "password", "pictureid_doc" },
                values: new object[] { 5, true, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), null, "admin@gmail.com", null, null, 999, "admin", "admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "email",
                table: "Tbl_Usuarios");

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
