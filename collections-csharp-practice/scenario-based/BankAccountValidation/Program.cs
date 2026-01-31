using System;
public class Program
{
    public decimal Balance { get; private set; }

    public Program(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new Exception("Deposit amount cannot be negative");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new Exception("Insufficient funds.");

        Balance -= amount;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter initial balance:");
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        Program account = new Program(balance);

        Console.WriteLine("Enter deposit amount:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(deposit);

        Console.WriteLine("Enter withdraw amount:");
        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(withdraw);

        Console.WriteLine("Final Balance: " + account.Balance);
    }
}

