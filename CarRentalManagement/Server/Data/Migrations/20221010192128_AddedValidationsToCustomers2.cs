using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "12cd0c60-7631-4d02-ab69-1bef31016bfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "d4295f79-bcfa-4da7-a2f9-254fe36bdea6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4907eff1-98b6-46f2-a9d8-36c59e9cde89", "AQAAAAEAACcQAAAAEOVydkS3re4E5YkR3OO7NWblCFzvsA31eJS1TylusZ7Aotomh/KCkOhSmNpF9waW5A==", "dab02f34-f72c-4712-8675-0ba370e7122d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23be3d6e-848b-4a9f-92ad-ab4f526ade46", "AQAAAAEAACcQAAAAEBkh1jJUAhL3/wSqNlBril1oHiXy+mtk4rSWYIygar5FculI+xZEf2HDAsI/+ePdeQ==", "fd158bbe-6672-47a1-81d3-95116052c1d2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(2742), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3085), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3098), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3216), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 10, 10, 21, 11, 46, 417, DateTimeKind.Local).AddTicks(3229) });
        }
    }
}
