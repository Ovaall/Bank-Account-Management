using System;

namespace MyProgram;
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        while (true)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice (0-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: $");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: $");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;

                case 3:
                    account.CheckBalance();
                    break;

                case 0:
                    Console.WriteLine("Exiting program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 3.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
