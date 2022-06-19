using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0982cd2e-f56e-43ed-b8f0-96312b1c50fc", "05052edd-4ea7-43b4-83c7-0542032c3a4e", "Administrator", "ADMINISTRATOR" },
                    { "1982cd2e-f56e-43ed-b8f0-96312b1c50fc", "cd4039a0-7a28-4102-93ac-077fe94ac93e", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9035), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9337), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9504), new DateTime(2022, 6, 12, 23, 4, 19, 658, DateTimeKind.Local).AddTicks(9507) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2698), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2748), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3110) });
        }
    }
}
