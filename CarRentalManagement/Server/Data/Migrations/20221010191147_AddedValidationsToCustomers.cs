using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastaName",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
