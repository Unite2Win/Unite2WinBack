using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class IncontablesCambiosDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picture",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "avatar",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.DropColumn(
                name: "banner",
                table: "Tbl_Comunidades");

            migrationBuilder.DropColumn(
                name: "picture",
                table: "Tbl_Comunidades");

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_create_date",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_delete_date",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_last_modified",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "borradoPorId",
                table: "Tbl_Usuarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "modificadoPorId",
                table: "Tbl_Usuarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "pictureid_doc",
                table: "Tbl_Usuarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "complete_date",
                table: "Tbl_Objetivos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "avatarid_doc",
                table: "Tbl_ComunidadesUsuarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "bannerid_doc",
                table: "Tbl_Comunidades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "pictureid_doc",
                table: "Tbl_Comunidades",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Documentos",
                columns: table => new
                {
                    id_doc = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    extensionArchivo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Documentos", x => x.id_doc);
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                columns: new[] { "bannerid_doc", "create_date", "pictureid_doc" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                columns: new[] { "bannerid_doc", "create_date", "pictureid_doc" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                columns: new[] { "bannerid_doc", "create_date", "pictureid_doc" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                columns: new[] { "bannerid_doc", "create_date", "pictureid_doc" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                columns: new[] { "avatarid_doc", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                columns: new[] { "avatarid_doc", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                columns: new[] { "avatarid_doc", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                columns: new[] { "avatarid_doc", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Tbl_Documentos",
                columns: new[] { "id_doc", "create_date", "data", "delete_date", "descripcion", "extensionArchivo", "last_modified" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), new byte[] { 0 }, null, "Descripcion del documento1", null, null },
                    { 2L, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), new byte[] { 0 }, null, null, null, null },
                    { 3L, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), new byte[] { 0 }, null, "Descripcion del documento3", null, null },
                    { 4L, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), new byte[] { 0 }, null, "Descripcion del documento4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                columns: new[] { "complete_date", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                columns: new[] { "complete_date", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                columns: new[] { "complete_date", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                columns: new[] { "complete_date", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "create_date", "pictureid_doc" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                columns: new[] { "create_date", "pictureid_doc" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                columns: new[] { "create_date", "pictureid_doc" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                columns: new[] { "create_date", "pictureid_doc" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Usuarios_pictureid_doc",
                table: "Tbl_Usuarios",
                column: "pictureid_doc");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ComunidadesUsuarios_avatarid_doc",
                table: "Tbl_ComunidadesUsuarios",
                column: "avatarid_doc");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Comunidades_bannerid_doc",
                table: "Tbl_Comunidades",
                column: "bannerid_doc");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Comunidades_pictureid_doc",
                table: "Tbl_Comunidades",
                column: "pictureid_doc");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comunidades_Tbl_Documentos_bannerid_doc",
                table: "Tbl_Comunidades",
                column: "bannerid_doc",
                principalTable: "Tbl_Documentos",
                principalColumn: "id_doc");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comunidades_Tbl_Documentos_pictureid_doc",
                table: "Tbl_Comunidades",
                column: "pictureid_doc",
                principalTable: "Tbl_Documentos",
                principalColumn: "id_doc");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_ComunidadesUsuarios_Tbl_Documentos_avatarid_doc",
                table: "Tbl_ComunidadesUsuarios",
                column: "avatarid_doc",
                principalTable: "Tbl_Documentos",
                principalColumn: "id_doc");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Usuarios_Tbl_Documentos_pictureid_doc",
                table: "Tbl_Usuarios",
                column: "pictureid_doc",
                principalTable: "Tbl_Documentos",
                principalColumn: "id_doc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comunidades_Tbl_Documentos_bannerid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comunidades_Tbl_Documentos_pictureid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_ComunidadesUsuarios_Tbl_Documentos_avatarid_doc",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Usuarios_Tbl_Documentos_pictureid_doc",
                table: "Tbl_Usuarios");

            migrationBuilder.DropTable(
                name: "Tbl_Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Usuarios_pictureid_doc",
                table: "Tbl_Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_ComunidadesUsuarios_avatarid_doc",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Comunidades_bannerid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Comunidades_pictureid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.DropColumn(
                name: "Perfiles_create_date",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "Perfiles_delete_date",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "Perfiles_last_modified",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "borradoPorId",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "modificadoPorId",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "pictureid_doc",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "complete_date",
                table: "Tbl_Objetivos");

            migrationBuilder.DropColumn(
                name: "avatarid_doc",
                table: "Tbl_ComunidadesUsuarios");

            migrationBuilder.DropColumn(
                name: "bannerid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.DropColumn(
                name: "pictureid_doc",
                table: "Tbl_Comunidades");

            migrationBuilder.AddColumn<string>(
                name: "picture",
                table: "Tbl_Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "Tbl_ComunidadesUsuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "banner",
                table: "Tbl_Comunidades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "picture",
                table: "Tbl_Comunidades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                columns: new[] { "banner", "create_date", "picture" },
                values: new object[] { "banner1", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "imagen1" });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                columns: new[] { "banner", "create_date", "picture" },
                values: new object[] { "banner2", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "imagen2" });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                columns: new[] { "banner", "create_date", "picture" },
                values: new object[] { "banner3", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "imagen3" });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                columns: new[] { "banner", "create_date", "picture" },
                values: new object[] { "banner4", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "imagen4" });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                columns: new[] { "avatar", "create_date" },
                values: new object[] { "avatar1", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                columns: new[] { "avatar", "create_date" },
                values: new object[] { "avatar2", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                columns: new[] { "avatar", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                columns: new[] { "avatar", "create_date" },
                values: new object[] { null, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                columns: new[] { "create_date", "picture" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "a" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                columns: new[] { "create_date", "picture" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "a" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                columns: new[] { "create_date", "picture" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "a" });

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                columns: new[] { "create_date", "picture" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "a" });
        }
    }
}
