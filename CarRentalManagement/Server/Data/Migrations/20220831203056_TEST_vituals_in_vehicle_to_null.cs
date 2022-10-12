using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class TEST_vituals_in_vehicle_to_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "a3d52c81-7a9a-4b25-a257-3c709a204990");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "445d5910-d0d9-4271-9251-dc06560899b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a94fc8c-5c3c-4af1-b71b-571161e7d3e0", "AQAAAAEAACcQAAAAEA5ER0kdDTGHrK+uwW1i6Dx2OOHvuYCTOHGnSuOvYQbfQ8KEw8sOXuLme7VzCxf9xw==", "4264df60-11c3-4f80-853e-ff850d87543f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4dc41a9-ec8a-434e-a217-f23aa8ff7b1f", "AQAAAAEAACcQAAAAEAjKccDqA2vEfxwa0CKy+yn++jWSModnGVhnGRicCc2wyO0EK9ueItDSEoMYuj0myQ==", "eb78654c-23be-42e9-b9b3-616fa1975ffd" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7562), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7879), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7889), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7990), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(7998), new DateTime(2022, 8, 31, 20, 59, 56, 64, DateTimeKind.Local).AddTicks(8000) });
        }
    }
}
