using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Migrations
{
    /// <inheritdoc />
    public partial class table_name_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                schema: "Eshop_Db",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "Eshop_Db",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Eshop_Db",
                newName: "Products",
                newSchema: "Eshop_Db");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "Eshop_Db",
                newName: "Categories",
                newSchema: "Eshop_Db");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                schema: "Eshop_Db",
                table: "Products",
                column: "Sku");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "Eshop_Db",
                table: "Categories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                schema: "Eshop_Db",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "Eshop_Db",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Eshop_Db",
                newName: "Product",
                newSchema: "Eshop_Db");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "Eshop_Db",
                newName: "Category",
                newSchema: "Eshop_Db");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                schema: "Eshop_Db",
                table: "Product",
                column: "Sku");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "Eshop_Db",
                table: "Category",
                column: "Id");
        }
    }
}
