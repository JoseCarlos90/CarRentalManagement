using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedUserAndRolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1982cd2e-f56e-43ed-b8f0-96312b1c50fa", 0, "f590f4e5-6b49-4183-a084-842a9e510e22", "josecarlos@test.com", false, "José Carlos", "González", false, null, "JOSECARLOS@TEST.COM", "JOSECARLOS@TEST.COM", "AQAAAAEAACcQAAAAEBV23O3MTjRL5LvFBKh3sQwee6Y40lXhGh9Mu6m2OJJg22ImVqcbd7Kaw7sXt/ZGvw==", null, false, "b78240ff-e7aa-41f9-a5d8-e7eefb649075", false, null },
                    { "1982cd2e-f56e-43ed-b8f0-96312b1c50fb", 0, "d2ac37e4-0723-42bb-bf9d-67f4ef2d6c0e", "Admin@test.com", false, "Admin", "", false, null, "ADMININISTRATOR@TEST.COM", "ADMININISTRATOR@TEST.COM", "AQAAAAEAACcQAAAAEK+8Hkmt8PbDexV3rDZ9vwVlMj6z0v86JYNvpp3hp6m7YM8r5IO15JokgQDzMDmVyg==", null, false, "cee9ec8d-96ac-4355-bbbc-c35343ef3015", false, null }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1982cd2e-f56e-43ed-b8f0-96312b1c50fc", "1982cd2e-f56e-43ed-b8f0-96312b1c50fa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0982cd2e-f56e-43ed-b8f0-96312b1c50fc", "1982cd2e-f56e-43ed-b8f0-96312b1c50fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1982cd2e-f56e-43ed-b8f0-96312b1c50fc", "1982cd2e-f56e-43ed-b8f0-96312b1c50fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0982cd2e-f56e-43ed-b8f0-96312b1c50fc", "1982cd2e-f56e-43ed-b8f0-96312b1c50fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "05052edd-4ea7-43b4-83c7-0542032c3a4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                column: "ConcurrencyStamp",
                value: "cd4039a0-7a28-4102-93ac-077fe94ac93e");

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
    }
}
