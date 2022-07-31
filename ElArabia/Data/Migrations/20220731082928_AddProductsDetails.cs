using Microsoft.EntityFrameworkCore.Migrations;

namespace ElArabia.Data.Migrations
{
    public partial class AddProductsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeModelOne");

            migrationBuilder.DropTable(
                name: "HomeModelThree");

            migrationBuilder.DropTable(
                name: "HomeModelTwo");

            migrationBuilder.CreateTable(
                name: "ProductsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(nullable: true),
                    NameEn = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Prepare = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepareIMG",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsDetailId = table.Column<int>(nullable: false),
                    IMG1 = table.Column<string>(nullable: true),
                    IMG2 = table.Column<string>(nullable: true),
                    IMG3 = table.Column<string>(nullable: true),
                    IMG4 = table.Column<string>(nullable: true),
                    IMG5 = table.Column<string>(nullable: true),
                    IMG6 = table.Column<string>(nullable: true),
                    IMG7 = table.Column<string>(nullable: true),
                    IMG8 = table.Column<string>(nullable: true),
                    IMG9 = table.Column<string>(nullable: true),
                    IMG10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepareIMG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepareIMG_ProductsDetails_ProductsDetailId",
                        column: x => x.ProductsDetailId,
                        principalTable: "ProductsDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrepareIMG_ProductsDetailId",
                table: "PrepareIMG",
                column: "ProductsDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetails_ProductId",
                table: "ProductsDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrepareIMG");

            migrationBuilder.DropTable(
                name: "ProductsDetails");

            migrationBuilder.CreateTable(
                name: "HomeModelOne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeModelOne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeModelThree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeModelThree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeModelTwo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeModelTwo", x => x.Id);
                });
        }
    }
}
