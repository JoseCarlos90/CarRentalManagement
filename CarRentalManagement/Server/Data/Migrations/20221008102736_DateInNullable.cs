using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class DateInNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "c043ce58-4c54-4fa9-9766-61d9d5e5333c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "6c6d4eed-9c58-4e6e-ae29-87b10b7a3eb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1db67d-0c94-48e4-8092-4c7cac38004b", "AQAAAAEAACcQAAAAEOd2IdEkpwU3ypi5xKmitDYNrAfmiBf0+9LRdgOCMI/RZX9HNzUv25PMX9Et+pQjIw==", "8e86d01c-3295-4a10-bae8-c15090dd5b03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "118fbeb3-3b83-4234-978b-42db5d60cee3", "AQAAAAEAACcQAAAAEILXARnnKsoe0sL6RAhSevIdSoIMTy5TOOtIGbkF+Eq8MAbIFJAayydJqMmv8YzlNg==", "572c7134-edb8-4f8e-9e59-e510cbfd0017" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(7607), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(7664), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8253), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8686), new DateTime(2022, 8, 31, 22, 30, 55, 440, DateTimeKind.Local).AddTicks(8706) });
        }
    }
}
