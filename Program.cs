using System;

public class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }

    public BankAccount(string accountNumber, double initialBalance, string type = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be greater than zero.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount should be greater than zero.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
    }

    public void Deposit(int amount)
    {
        Deposit((double)amount);
    }

    public void Withdraw(int amount)
    {
        Withdraw((double)amount);
    }
}

class Program
{
    static void Main(string[] args)
    {

        BankAccount checkingAccount = new BankAccount("123456", 1000.0);

        BankAccount savingAccount = new BankAccount("654321", 5000.0, "Savings");

        Console.WriteLine("Enter 1 for checking or 2 for savings. Press any other key to exit");
        double acc = double.Parse(Console.ReadLine());

        while (acc == 1 || acc == 2)
        {
            if (acc == 1)
            {

                Console.WriteLine("Enter 1 to deposit or 2 to withdraw");
                double action = double.Parse(Console.ReadLine());

                if (action == 1)
                {

                    Console.WriteLine("Enter deposit amount for checking account:");
                    double depositAmountChecking = double.Parse(Console.ReadLine());
                    checkingAccount.Deposit(depositAmountChecking);

                }

                else if (action == 2)
                {

                    Console.WriteLine("Enter withdrawal amount for checking account:");
                    double withdrawalAmountChecking = double.Parse(Console.ReadLine());
                    checkingAccount.Withdraw(withdrawalAmountChecking);

                }

            }

            if (acc == 2)
            {

                Console.WriteLine("Enter 1 to deposit or 2 to withdraw");
                double action2 = double.Parse(Console.ReadLine());

                if (action2 == 1)
                {

                    Console.WriteLine("Enter deposit amount for saving account:");
                    double depositAmountSaving = double.Parse(Console.ReadLine());
                    savingAccount.Deposit(depositAmountSaving);
                }

                else if (action2 == 2)
                {
                    Console.WriteLine("Enter withdrawal amount for saving account:");
                    double withdrawalAmountSaving = double.Parse(Console.ReadLine());
                    savingAccount.Withdraw(withdrawalAmountSaving);
                }
            }

            Console.WriteLine("Enter 1 for checking or 2 for savings. Press any other key to exit");
            acc = double.Parse(Console.ReadLine());
        }
    }
}
