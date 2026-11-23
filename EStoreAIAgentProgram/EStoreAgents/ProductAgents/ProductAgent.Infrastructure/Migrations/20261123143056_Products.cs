using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAgent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { new Guid("031c0ca7-d216-423d-9ddd-95b9001fd3f1"), "Laptop", 58000m, "Lenovo IdeaPad Slim", 8 },
                    { new Guid("c2ec3151-5f93-44c7-8063-3f8a50020a5f"), "Laptop", 45000m, "Dell Inspiron 15", 20 },
                    { new Guid("f77d8154-db33-41ce-b202-84246472c872"), "Laptop", 72000m, "HP Pavilion 14", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
