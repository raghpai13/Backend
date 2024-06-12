using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class ExpenseTracker_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "CategoriesMapUsers");

            migrationBuilder.RenameColumn(
                name: "CateoryId",
                table: "CategoriesMapUsers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CategoriesMapUsers",
                newName: "CateoryId");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Transactions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Incomes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Expenses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "CategoriesMapUsers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
