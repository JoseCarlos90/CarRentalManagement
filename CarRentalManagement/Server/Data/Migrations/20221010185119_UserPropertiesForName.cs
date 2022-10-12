using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UserPropertiesForName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastaName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "c42167b2-3ee0-44da-9410-9eca710b2d09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "0f673f70-9cea-423d-a655-82ad975adc72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70dc1d1a-9dbb-4997-818b-d941db348b99", "AQAAAAEAACcQAAAAEEXzqgg6fxI8m0IoK3dDDxhM8Kai00T1nNz6VH2CyPZSJiYjfxi3Fo1eHfgiObQJoA==", "ef6bbe05-5995-4860-a8bd-0837bc7a2e7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197a813c-1595-4473-b7c6-6c27f3c1c228", "AQAAAAEAACcQAAAAECmQRHpTiQeL2QgszqpJshB/4KSLhSUJbovVu3zids08szu6skEKKGcMQNa9wE+EJg==", "cfa4e74e-6947-4368-ab0c-f8ef8b5ce5ef" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7097), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7154), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7609), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7624), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7758), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7767), new DateTime(2022, 10, 10, 20, 51, 18, 861, DateTimeKind.Local).AddTicks(7770) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastaName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "bab1db82-84f5-4b36-bc05-1b0b8a2a6734");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "f18d34df-4643-4e4d-92b6-4e693e7c3c61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a7b9551-8a50-4dca-8a0d-c3a1bdc369fe", "AQAAAAEAACcQAAAAEFdKmetHWw9tymJwxKL6Q222QbTMdHhMGFarmJm3OyNFFN3Jbn45f4f62Cnk9kVC6g==", "a69d144a-b7be-477b-833a-1d7bc2855dfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "837c568f-41fc-4391-a336-1ec1b368d39b", "AQAAAAEAACcQAAAAEI30mazlu0lv+S4l5FfrunhEmvU/Mb33Q8rlTWNtVn8K5mk7kidpXkdDyWd2vokMIQ==", "2802fa62-e366-4d1b-b36a-435d1dc750dd" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2669), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2846), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2852), new DateTime(2022, 10, 8, 12, 27, 36, 93, DateTimeKind.Local).AddTicks(2854) });
        }
    }
}
