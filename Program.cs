using System;

namespace BankEncap
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("Welcome to your bank account!");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Exit");

                Console.Write("Please choose an option (1/2/3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                            Console.WriteLine($"${depositAmount} has been deposited into your account.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Your current balance is: ${account.GetBalance()}");
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using the bank account. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1/2/3).");
                        break;
                }

                Console.WriteLine(); // Add a blank line for readability.
            }
        }
    }
}
