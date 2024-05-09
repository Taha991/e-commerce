using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastrucure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WomenProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WomenProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodStuff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodProductTypeId = table.Column<int>(type: "int", nullable: false),
                    FoodProductBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStuff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodStuff_FoodProductBrands_FoodProductBrandId",
                        column: x => x.FoodProductBrandId,
                        principalTable: "FoodProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodStuff_FoodProductTypes_FoodProductTypeId",
                        column: x => x.FoodProductTypeId,
                        principalTable: "FoodProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthProductTypeId = table.Column<int>(type: "int", nullable: false),
                    HealthProductBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthProducts_HealthProductBrands_HealthProductBrandId",
                        column: x => x.HealthProductBrandId,
                        principalTable: "HealthProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthProducts_HealthProductTypes_HealthProductTypeId",
                        column: x => x.HealthProductTypeId,
                        principalTable: "HealthProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenProductTypeId = table.Column<int>(type: "int", nullable: false),
                    MenProductBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenProducts_MenProductBrands_MenProductBrandId",
                        column: x => x.MenProductBrandId,
                        principalTable: "MenProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenProducts_MenProductTypes_MenProductTypeId",
                        column: x => x.MenProductTypeId,
                        principalTable: "MenProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WomenProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WomenProductTypeId = table.Column<int>(type: "int", nullable: false),
                    WomenProductBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WomenProducts_WomenProductBrands_WomenProductBrandId",
                        column: x => x.WomenProductBrandId,
                        principalTable: "WomenProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WomenProducts_WomenProductTypes_WomenProductTypeId",
                        column: x => x.WomenProductTypeId,
                        principalTable: "WomenProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuff_FoodProductBrandId",
                table: "FoodStuff",
                column: "FoodProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStuff_FoodProductTypeId",
                table: "FoodStuff",
                column: "FoodProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthProducts_HealthProductBrandId",
                table: "HealthProducts",
                column: "HealthProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthProducts_HealthProductTypeId",
                table: "HealthProducts",
                column: "HealthProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenProducts_MenProductBrandId",
                table: "MenProducts",
                column: "MenProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_MenProducts_MenProductTypeId",
                table: "MenProducts",
                column: "MenProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WomenProducts_WomenProductBrandId",
                table: "WomenProducts",
                column: "WomenProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_WomenProducts_WomenProductTypeId",
                table: "WomenProducts",
                column: "WomenProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodStuff");

            migrationBuilder.DropTable(
                name: "HealthProducts");

            migrationBuilder.DropTable(
                name: "MenProducts");

            migrationBuilder.DropTable(
                name: "WomenProducts");

            migrationBuilder.DropTable(
                name: "FoodProductBrands");

            migrationBuilder.DropTable(
                name: "FoodProductTypes");

            migrationBuilder.DropTable(
                name: "HealthProductBrands");

            migrationBuilder.DropTable(
                name: "HealthProductTypes");

            migrationBuilder.DropTable(
                name: "MenProductBrands");

            migrationBuilder.DropTable(
                name: "MenProductTypes");

            migrationBuilder.DropTable(
                name: "WomenProductBrands");

            migrationBuilder.DropTable(
                name: "WomenProductTypes");
        }
    }
}
