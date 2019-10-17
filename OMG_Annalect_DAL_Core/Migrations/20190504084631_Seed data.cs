using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "tblSupplier",
                columns: new[] { "Id", "AddedBy", "AddedTime", "ChannelId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), 1L, false, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), "Facebook" },
                    { 2L, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), 1L, false, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), "Twitter" },
                    { 3L, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), 2L, false, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), "Television" },
                    { 4L, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), 3L, false, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), "Billboard" },
                    { 5L, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), 4L, false, null, new DateTime(2019, 5, 4, 12, 46, 31, 196, DateTimeKind.Local).AddTicks(1534), "Gulf News" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "tblSupplier",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5391), new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5426), new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5430), new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "tblChannel",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5434), new DateTime(2019, 5, 3, 12, 21, 21, 631, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 630, DateTimeKind.Local).AddTicks(1022), new DateTime(2019, 5, 3, 12, 21, 21, 630, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "tblCountry",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2019, 5, 3, 12, 21, 21, 630, DateTimeKind.Local).AddTicks(9456), new DateTime(2019, 5, 3, 12, 21, 21, 630, DateTimeKind.Local).AddTicks(9464) });
        }
    }
}
