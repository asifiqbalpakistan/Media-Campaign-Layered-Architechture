using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class adddocumentaccessbit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "tblDocuments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDocumentAccess",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7624), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7671), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7675), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7680), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 632, DateTimeKind.Local).AddTicks(1442), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(1402), new DateTime(2019, 5, 2, 22, 54, 33, 633, DateTimeKind.Local).AddTicks(1410) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "tblDocuments");

            migrationBuilder.DropColumn(
                name: "IsDocumentAccess",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(929), new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(959), new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(963), new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(963), new DateTime(2019, 5, 2, 17, 32, 10, 578, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 576, DateTimeKind.Local).AddTicks(9070), new DateTime(2019, 5, 2, 17, 32, 10, 577, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 2, 17, 32, 10, 577, DateTimeKind.Local).AddTicks(6400), new DateTime(2019, 5, 2, 17, 32, 10, 577, DateTimeKind.Local).AddTicks(6409) });
        }
    }
}
