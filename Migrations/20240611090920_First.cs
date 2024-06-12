using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmailID",
                table: "Transactions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserEmailID",
                table: "Incomes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Expenses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserEmailID",
                table: "Expenses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CategoriesMapUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserEmailID",
                table: "CategoriesMapUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserEmailID",
                table: "Transactions",
                column: "UserEmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserEmailID",
                table: "Incomes",
                column: "UserEmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CategoryId",
                table: "Expenses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserEmailID",
                table: "Expenses",
                column: "UserEmailID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesMapUsers_CategoryId",
                table: "CategoriesMapUsers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesMapUsers_UserEmailID",
                table: "CategoriesMapUsers",
                column: "UserEmailID");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesMapUsers_Categories_CategoryId",
                table: "CategoriesMapUsers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesMapUsers_Users_UserEmailID",
                table: "CategoriesMapUsers",
                column: "UserEmailID",
                principalTable: "Users",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Categories_CategoryId",
                table: "Expenses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Users_UserEmailID",
                table: "Expenses",
                column: "UserEmailID",
                principalTable: "Users",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Users_UserEmailID",
                table: "Incomes",
                column: "UserEmailID",
                principalTable: "Users",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserEmailID",
                table: "Transactions",
                column: "UserEmailID",
                principalTable: "Users",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesMapUsers_Categories_CategoryId",
                table: "CategoriesMapUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesMapUsers_Users_UserEmailID",
                table: "CategoriesMapUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Categories_CategoryId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Users_UserEmailID",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Users_UserEmailID",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserEmailID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_UserEmailID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_UserEmailID",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_CategoryId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserEmailID",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_CategoriesMapUsers_CategoryId",
                table: "CategoriesMapUsers");

            migrationBuilder.DropIndex(
                name: "IX_CategoriesMapUsers_UserEmailID",
                table: "CategoriesMapUsers");

            migrationBuilder.DropColumn(
                name: "UserEmailID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UserEmailID",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "UserEmailID",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CategoriesMapUsers");

            migrationBuilder.DropColumn(
                name: "UserEmailID",
                table: "CategoriesMapUsers");
        }
    }
}
