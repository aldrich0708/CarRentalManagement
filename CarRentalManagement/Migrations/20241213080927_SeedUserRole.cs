using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "53817e48-1485-44fe-904f-f3210f5c1bb9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAgVXz9NNCJwADHDLHhF53m2CtfCvSCOmhYJ6iwOWnZF6syrOEtIhknRphmrDmv/4Q==", null, false, "826d36d0-604e-454f-abc9-e375c9f31a10", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3844), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3956), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3963), new DateTime(2024, 12, 13, 16, 9, 26, 410, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2934), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2940), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3124), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3127), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 12, 13, 15, 56, 10, 796, DateTimeKind.Local).AddTicks(3132) });
        }
    }
}
