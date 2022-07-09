using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class CreateIdentitySchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "278188fe-052d-4a32-ae8b-f846b92f5c1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "ac2e0349-ac46-4a7d-b2a1-292222cb9e90");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bafd6be6-5a38-493e-82d2-0c9bf0ea202f", "AQAAAAEAACcQAAAAEJzVnwD1/9uTARGaCpMYbg9u0MErvHXNMwFk7KGYalW2PYYSZzyydRiUR4F3Q4b8Tw==", "8ee07b69-7daf-4dc5-9b77-269c91a8a953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffd50b7f-fd2d-4959-82a3-6476545206ae", "AQAAAAEAACcQAAAAEE6W8KwQQnhvG6ASwHBtCEgNKwzz/qzvnovtjNUImilH+1d7rAEJyQfVhN9C05Q04A==", "c47585f9-1f33-45ac-97f0-b5e9f91db151" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(2804), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3137), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3261), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 7, 9, 16, 0, 29, 380, DateTimeKind.Local).AddTicks(3272) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "deab5aef-df8f-4e2a-8363-9664ea74ac6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "21659743-a42f-4b39-8a60-f896d585ddde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f590f4e5-6b49-4183-a084-842a9e510e22", "AQAAAAEAACcQAAAAEBV23O3MTjRL5LvFBKh3sQwee6Y40lXhGh9Mu6m2OJJg22ImVqcbd7Kaw7sXt/ZGvw==", "b78240ff-e7aa-41f9-a5d8-e7eefb649075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ac37e4-0723-42bb-bf9d-67f4ef2d6c0e", "AQAAAAEAACcQAAAAEK+8Hkmt8PbDexV3rDZ9vwVlMj6z0v86JYNvpp3hp6m7YM8r5IO15JokgQDzMDmVyg==", "cee9ec8d-96ac-4355-bbbc-c35343ef3015" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3645), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3693), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3909), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(4017), new DateTime(2022, 6, 19, 14, 50, 42, 727, DateTimeKind.Local).AddTicks(4019) });
        }
    }
}
