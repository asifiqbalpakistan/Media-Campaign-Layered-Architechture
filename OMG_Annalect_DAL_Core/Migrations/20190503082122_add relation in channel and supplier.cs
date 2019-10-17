using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMG_Annalect_DAL_Core.Migrations
{
    public partial class addrelationinchannelandsupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChannelId",
                table: "tblSupplier",
                nullable: false,
                defaultValue: 0L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelId",
                table: "tblSupplier");

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
    }
}
