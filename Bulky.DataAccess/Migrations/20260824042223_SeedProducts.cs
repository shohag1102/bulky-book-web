using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "James Watter", "Non voluptas cupiditate ut ut voluptas, dolor sit amet consectetur", "978-1234567897", 99.0, 90.0, 80.0, 85.0, "Days Gone by (Hardcover)" },
                    { 2, "Helena Yellow", "Dolor sit amet consectetur adipiscing elit sed do eiusmod", "978-2234567897", 40.0, 30.0, 20.0, 25.0, "The Winds Call" },
                    { 3, "Charles Darwin", "Tempor incididunt ut labore et dolore magna aliqua enim ad minim veniam", "978-3234567897", 50.0, 40.0, 30.0, 35.0, "The Origin of Species" },
                    { 4, "Marcus Reyed", "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris", "978-4234567897", 60.0, 50.0, 40.0, 45.0, "The Silent Ocean" },
                    { 5, "Elena Wraith", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem", "978-5234567897", 120.0, 110.0, 90.0, 100.0, "Chronicles of the Forgotten" },
                    { 6, "Stephen Hawking", "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse", "978-6234567897", 75.0, 65.0, 55.0, 60.0, "A Brief History of Time" }
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
