using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class updatefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d149904-c6b8-467f-86db-9e6175f2b260");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "415c01f9-3b5b-4cf8-a7d8-73e47e39a16b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4f5bcd0-eb69-46cb-99a7-693d3dafc54d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee8af06b-0d68-42d8-8232-1911dc5ba485");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tblCampaign",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "tblCampaign",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b788cb1-c15e-4aca-a6a3-a8591f86bd90", "a0836b54-d015-4659-a628-2c3e284665a5", "Admin", "ADMIN" },
                    { "de11ba4e-c273-4753-8087-b42b1184618d", "1b34a94b-4f4a-4cde-b63a-7d22c638bd87", "Manager", "MANAGER" },
                    { "6d33b502-5d6d-4ccb-b171-c7769ca7c619", "1c7d4d55-833d-4ed0-b495-1a5a18ea9654", "Client", "CLIENT" },
                    { "77d5fb7e-d211-4f9d-91bd-50daa0372b1c", "59f7b697-a3ea-4012-951b-f53c45466b42", "Planner", "PLANNER" }
                });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 900, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 901, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 5, 20, 15, 45, 39, 902, DateTimeKind.Local).AddTicks(7730) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b788cb1-c15e-4aca-a6a3-a8591f86bd90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d33b502-5d6d-4ccb-b171-c7769ca7c619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77d5fb7e-d211-4f9d-91bd-50daa0372b1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de11ba4e-c273-4753-8087-b42b1184618d");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tblCampaign",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Action",
                table: "tblCampaign",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "415c01f9-3b5b-4cf8-a7d8-73e47e39a16b", "268792ac-421d-42eb-a010-b431ffef9a5e", "Admin", "ADMIN" },
                    { "d4f5bcd0-eb69-46cb-99a7-693d3dafc54d", "9dc36c83-aaf0-44aa-9f96-873b8dc79b56", "Manager", "MANAGER" },
                    { "ee8af06b-0d68-42d8-8232-1911dc5ba485", "ea26cc2e-6770-4811-ac7c-1b076c894b2c", "Client", "CLIENT" },
                    { "0d149904-c6b8-467f-86db-9e6175f2b260", "5ec3e6b4-8d2e-4ce8-a10a-5884955b3f0f", "Planner", "PLANNER" }
                });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835), new DateTime(2019, 5, 20, 11, 11, 45, 537, DateTimeKind.Local).AddTicks(3835) });
        }
    }
}
