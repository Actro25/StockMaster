using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaster.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameColumnInFunctionStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDepart",
                table: "FunctionStockData",
                newName: "isOverdue");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isOverdue",
                table: "FunctionStockData",
                newName: "isDepart");
        }
    }
}
