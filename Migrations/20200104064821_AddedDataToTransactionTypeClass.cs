using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerService.API.Migrations
{
    public partial class AddedDataToTransactionTypeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 1, "Debit" });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 2, "Credit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransactionTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
