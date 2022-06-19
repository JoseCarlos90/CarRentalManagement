using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2698), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2744), "Black", "System" },
                    { 2, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2748), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2751), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3001), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3007), "Tesla", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3105), "A5", "System" },
                    { 2, "System", new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 6, 12, 22, 33, 16, 540, DateTimeKind.Local).AddTicks(3110), "Model 3", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
