using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bianca_Muresan_ClaudiaBakeryShop.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityID",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdressName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Quantity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantity", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_AdressID",
                table: "Product",
                column: "AdressID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CityID",
                table: "Product",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_QuantityID",
                table: "Product",
                column: "QuantityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Adress_AdressID",
                table: "Product",
                column: "AdressID",
                principalTable: "Adress",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_City_CityID",
                table: "Product",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Quantity_QuantityID",
                table: "Product",
                column: "QuantityID",
                principalTable: "Quantity",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Adress_AdressID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_City_CityID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Quantity_QuantityID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Quantity");

            migrationBuilder.DropIndex(
                name: "IX_Product_AdressID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CityID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_QuantityID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "QuantityID",
                table: "Product");
        }
    }
}
