using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class Seeddatadocumenttypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16938cfd-6b12-4738-b565-1a421f413987");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94867b1f-a0f2-4d6b-bbd7-6bea767bede3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b87aed-cef3-4d2b-9bf1-5f7eb2834c7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b24d2b-ca8f-47b1-a925-52bf00685bbc");

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

            migrationBuilder.InsertData(
                table: "tblDocumentType",
                columns: new[] { "Id", "AddedBy", "AddedTime", "DocumentTypeName", "IsDeleted", "IsRequired", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { 1L, "Admin", new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558), "Ads Broucher", false, false, null, new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) },
                    { 2L, "Admin", new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558), "Wish List", false, false, null, new DateTime(2019, 5, 4, 20, 58, 37, 328, DateTimeKind.Local).AddTicks(8558) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tblDocumentType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "94867b1f-a0f2-4d6b-bbd7-6bea767bede3", "eeb27b8d-3f50-4a4c-9c15-d241c9c24034", "Admin", "ADMIN" },
                    { "d7b87aed-cef3-4d2b-9bf1-5f7eb2834c7f", "f8c32fe6-d4c6-4b15-891a-f7538d73cf03", "Manager", "MANAGER" },
                    { "f1b24d2b-ca8f-47b1-a925-52bf00685bbc", "e84fcc55-2265-45dd-82b8-2e797b82fe70", "Client", "CLIENT" },
                    { "16938cfd-6b12-4738-b565-1a421f413987", "d3402968-3088-43ba-927b-39ae563e7a93", "Planner", "PLANNER" }
                });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 195, DateTimeKind.Local).AddTicks(1536), new DateTime(2019, 5, 4, 12, 46, 31, 195, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 195, DateTimeKind.Local).AddTicks(1536), new DateTime(2019, 5, 4, 12, 46, 31, 195, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534) });
        }
    }
}
