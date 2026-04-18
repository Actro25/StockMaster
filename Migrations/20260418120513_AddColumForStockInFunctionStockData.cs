using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaster.Migrations
{
    /// <inheritdoc />
    public partial class AddColumForStockInFunctionStockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "FunctionStockData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FunctionStockData_StockId",
                table: "FunctionStockData",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionStockData_Stocks_StockId",
                table: "FunctionStockData",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionStockData_Stocks_StockId",
                table: "FunctionStockData");

            migrationBuilder.DropIndex(
                name: "IX_FunctionStockData_StockId",
                table: "FunctionStockData");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "FunctionStockData");
        }
    }
}
