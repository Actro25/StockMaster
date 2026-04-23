using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaster.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTwoColumsInFunctionStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isArrived",
                table: "FunctionStockData",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDepart",
                table: "FunctionStockData",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isArrived",
                table: "FunctionStockData");

            migrationBuilder.DropColumn(
                name: "isDepart",
                table: "FunctionStockData");
        }
    }
}
