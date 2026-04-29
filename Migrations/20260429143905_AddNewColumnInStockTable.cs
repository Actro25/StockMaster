using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaster.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnInStockTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LinkedPhysicStockId",
                table: "Stocks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_LinkedPhysicStockId",
                table: "Stocks",
                column: "LinkedPhysicStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Stocks_LinkedPhysicStockId",
                table: "Stocks",
                column: "LinkedPhysicStockId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Stocks_LinkedPhysicStockId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_LinkedPhysicStockId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "LinkedPhysicStockId",
                table: "Stocks");
        }
    }
}
