using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class ExpenseTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Transactions",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Incomes",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Expenses",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CategoriesMapUsers",
                newName: "EmailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Transactions",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Incomes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Expenses",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "CategoriesMapUsers",
                newName: "UserId");
        }
    }
}
