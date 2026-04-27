using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMaster.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTablePhysicStockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysicStockData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StockId = table.Column<int>(type: "INTEGER", nullable: false),
                    NameOfGood = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicStockData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicStockData_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhysicStockData_StockId",
                table: "PhysicStockData",
                column: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicStockData");
        }
    }
}
