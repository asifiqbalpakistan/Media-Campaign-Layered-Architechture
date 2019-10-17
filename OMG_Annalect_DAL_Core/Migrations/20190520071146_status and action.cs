using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class statusandaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0428d927-d5d9-4cb0-9065-9d154917c56a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46da2850-0882-480c-8629-7a08692bd9c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c931e76-adbf-408f-a087-c765cf792ecc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ffc4c0-166c-4c44-ad4b-b21808c516f1");

            migrationBuilder.AddColumn<int>(
                name: "Action",
                table: "tblCampaign",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "tblCampaign",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Action",
                table: "tblCampaign");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tblCampaign");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d4ffc4c0-166c-4c44-ad4b-b21808c516f1", "3595058c-ed45-48b1-9fb6-fef21a62b732", "Admin", "ADMIN" },
                    { "8c931e76-adbf-408f-a087-c765cf792ecc", "2be03b55-3732-4f9f-ba9d-0894c20c3779", "Manager", "MANAGER" },
                    { "0428d927-d5d9-4cb0-9065-9d154917c56a", "e6fbf10f-45ad-49f4-aa76-72867b15daa7", "Client", "CLIENT" },
                    { "46da2850-0882-480c-8629-7a08692bd9c0", "8313236e-c7cc-40cd-b7e5-a48bb916b98a", "Planner", "PLANNER" }
                });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 327, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 5, 4, 20, 58, 37, 329, DateTimeKind.Local).AddTicks(8558) });
        }
    }
}
