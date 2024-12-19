using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BisonBank.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    accountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    routingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    accountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.accountID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    transactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    transactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    originAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destinationAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    savingsAccountNewBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    checkingAccountNewBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    savingsAddOrSubtract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkingAddOrSubtract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    accountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.transactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Account_accountID",
                        column: x => x.accountID,
                        principalTable: "Account",
                        principalColumn: "accountID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_accountID",
                table: "Transaction",
                column: "accountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
