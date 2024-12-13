using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(1792), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(1805), "Black", "System" },
                    { 2, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(1808), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2046), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2048), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2141), "i4", "System" },
                    { 2, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2143), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2143), "X5", "System" },
                    { 3, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2145), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 12, 13, 15, 12, 35, 610, DateTimeKind.Local).AddTicks(2147), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
