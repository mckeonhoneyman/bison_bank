using Microsoft.EntityFrameworkCore;
using BisonBank.Models;
namespace BisonBank.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BisonBankContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BisonBankContext>>());

            if (context == null || context.Account == null)
            {
                throw new NullReferenceException("Null BisonBankContext or Account DbSet");
            }

            if (context.Account.Any())
            {
                return;
            }

            context.Account.AddRange(
                new Account
                {
                    balance = 1000,
                    accountNumber = "10001",
                    routingNumber = "10002",
                    dateCreated = new DateTime(2011, 2, 15),
                    interest = 0,
                    accountType = "Checking",
                },
                new Account
                {
                    balance = 10000,
                    accountNumber = "20001",
                    routingNumber = "20002",
                    dateCreated = new DateTime(2012, 10, 27),
                    interest = 0.05m,
                    accountType = "Savings",
                });

            context.Transfer.AddRange(
                new Transfer
                {
                    date = new DateTime(2024, 7, 15, 12, 47, 40), // First random date
                    amount = 1000.00m,
                    description = "Transfer from Checking to Savings - Building emergency fund.",
                    destinationAccount = "Savings",
                    originAccount = "Checking",
                    transactionType = "Transfer",
                    checkingAccountNewBalance = 2000.00m,
                    savingsAccountNewBalance = 9000.00m,
                    checkingAddOrSubtract = "Add",
                    savingsAddOrSubtract = "Subtract",
                },
                new Transfer
                {
                    date = new DateTime(2024, 7, 7, 12, 47, 51), // Second random date
                    amount = 500.00m,
                    description = "Transfer from Checking to Savings - Weekly savings transfer.",
                    destinationAccount = "Savings",
                    originAccount = "Checking",
                    transactionType = "Transfer",
                    checkingAccountNewBalance = 2500.00m,
                    savingsAccountNewBalance = 8500.00m,
                    checkingAddOrSubtract = "Add",
                    savingsAddOrSubtract = "Subtract",
                },
                new Transfer
                {
                    date = new DateTime(2022, 8, 27, 12, 48, 00), // Third random date
                    amount = 1000.00m,
                    description = "Transfer from Savings to Checking - Covering monthly bills.",
                    destinationAccount = "Checking",
                    originAccount = "Savings",
                    transactionType = "Transfer",
                    checkingAccountNewBalance = 1500.00m,
                    savingsAccountNewBalance = 9500.00m,
                    checkingAddOrSubtract = "Subtract",
                    savingsAddOrSubtract = "Add",
                },
                new Transfer
                {
                    date = new DateTime(2023, 12, 13, 12, 48, 15), // Fourth random date
                    amount = 5000.00m,
                    description = "Transfer from Checking to Savings - Large savings deposit.",
                    destinationAccount = "Savings",
                    originAccount = "Checking",
                    transactionType = "Transfer",
                    checkingAccountNewBalance = 6500.00m,
                    savingsAccountNewBalance = 4500.00m,
                    checkingAddOrSubtract = "Add",
                    savingsAddOrSubtract = "Subtract",
                },
                new Transfer
                {
                    date = new DateTime(2023, 12, 8, 12, 48, 30), // Fifth random date
                    amount = 4000.00m,
                    description = "Transfer from Savings to Checking - Payment for new vehicle.",
                    destinationAccount = "Checking",
                    originAccount = "Savings",
                    transactionType = "Transfer",
                    checkingAccountNewBalance = 2500.00m,
                    savingsAccountNewBalance = 8500.00m,
                    checkingAddOrSubtract = "Subtract",
                    savingsAddOrSubtract = "Add",
                });
            context.SaveChanges();
        }
    }
}
