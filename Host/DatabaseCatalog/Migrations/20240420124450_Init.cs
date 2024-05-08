using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseCatalog.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ManufacturerUA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManufacturerENG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DescriptionUA = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionENG = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Caliber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MagazineCapacity = table.Column<int>(type: "int", nullable: false),
                    GeneralLength = table.Column<int>(type: "int", nullable: false),
                    BarrelLength = table.Column<int>(type: "int", nullable: false),
                    SightingDevicesUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SightingDevicesENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    GunStockAndButtUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GunStockAndButtENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    InitialVelocity = table.Column<int>(type: "int", nullable: false),
                    BarrelTwist = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    TypeUA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeENG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ProductId",
                table: "Weapons",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
