using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationForAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "4aec9e7d-11bf-49de-b218-a1f255e96683");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "939b0a77-f392-4100-b335-f7f24d65631c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d954a7-0b5b-4085-b6e9-bdea86daeb09", "AQAAAAEAACcQAAAAEPGY9MGMbyR69f63psQcUFRgvUopjhP+kc5dB8JrpA1vAbQuwc0qiQhJJ962HGrgeg==", "8445d574-7d21-4ee9-b23d-926cc16c9f51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c2f7e9-1379-4213-8eac-058fcc358fca", "AQAAAAEAACcQAAAAEN4HDHFU3Qhqk90a9kPdA3Z1x6cFbxn3BTV6Q3DfejAPmF+c64m/weUkl/jnoA504A==", "6154e10f-95b1-4978-b017-63c5d7a14ab0" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(1973), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2245), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2255), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2358), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2366), new DateTime(2022, 10, 10, 21, 31, 24, 505, DateTimeKind.Local).AddTicks(2368) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "f2b449ef-e18a-4b03-aea8-fd6c6d59e167");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "df74d3c1-1060-4d4a-8a85-ef25f9ac72d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cbd370-7683-43f6-9fb4-a470be503f29", "AQAAAAEAACcQAAAAEKFP1uGVt0VwtWJBq04tnnkKiis9njcVzGI+pb8Y9/cUumw5N5SACeBliYTsRZA8TA==", "80849b3f-bedd-400b-a07e-4db052ce79e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfb6859-97f5-4744-bd33-379b1a957c73", "AQAAAAEAACcQAAAAEGhbVNdJb+3SsUOX9htXmJ4kXsZUMbH/UhIs1H/5+iwbNd86etlimRjAcuRIvh0hVw==", "717f621f-999d-40c4-bdf5-bba2137088a9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8186), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8228), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8451), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8461), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8555), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 10, 10, 21, 21, 27, 447, DateTimeKind.Local).AddTicks(8567) });
        }
    }
}
