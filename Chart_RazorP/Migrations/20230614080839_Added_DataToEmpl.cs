using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chart_RazorP.Migrations
{
    /// <inheritdoc />
    public partial class Added_DataToEmpl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("185fbb20-0891-43ea-b4fc-f72eb27264a0"), "Chandigarh", "Sushant", 45000 },
                    { new Guid("79929112-3952-4aa9-b8f6-688888189295"), "Mohali", "Nikhil", 50000 },
                    { new Guid("aadc6818-76e6-491f-9a1e-172cd9524077"), "Chandigarh", "Uvti", 27000 },
                    { new Guid("f9ed439a-1960-4412-9d89-5a4246175ac5"), "Chandigarh", "Rohit", 37000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("185fbb20-0891-43ea-b4fc-f72eb27264a0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("79929112-3952-4aa9-b8f6-688888189295"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("aadc6818-76e6-491f-9a1e-172cd9524077"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f9ed439a-1960-4412-9d89-5a4246175ac5"));
        }
    }
}
