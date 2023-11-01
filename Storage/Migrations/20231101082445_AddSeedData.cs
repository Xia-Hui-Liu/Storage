using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Storage.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, 0, 30, "Latest iPhone model", "iPhone 13", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, "A1" },
                    { 2, 0, 20, "Flagship Android phone", "Samsung Galaxy S21", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, "A2" },
                    { 3, 0, 10, "Next-gen gaming console", "Sony PlayStation 5", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 499, "B1" },
                    { 4, 1, 25, "Classic sneakers", "Nike Air Max 90", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "B2" },
                    { 5, 2, 100, "Fresh, organic apples", "Organic Apples", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "C3" },
                    { 6, 0, 15, "Mid-range laptop", "HP Pavilion Laptop", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, "C4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
