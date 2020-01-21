using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerService.API.Migrations
{
    public partial class UpdatedCustomerLedgerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerLedgers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerMasterId",
                table: "CustomerLedgers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLedgers_CustomerMasterId",
                table: "CustomerLedgers",
                column: "CustomerMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLedgers_CustomerMasters_CustomerMasterId",
                table: "CustomerLedgers",
                column: "CustomerMasterId",
                principalTable: "CustomerMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLedgers_CustomerMasters_CustomerMasterId",
                table: "CustomerLedgers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerLedgers_CustomerMasterId",
                table: "CustomerLedgers");

            migrationBuilder.DropColumn(
                name: "CustomerMasterId",
                table: "CustomerLedgers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerLedgers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
