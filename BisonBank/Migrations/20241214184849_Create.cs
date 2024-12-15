using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BisonBank.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "checkingAddOrSubtract",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "savingsAddOrSubtract",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkingAddOrSubtract",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "savingsAddOrSubtract",
                table: "Transaction");
        }
    }
}
