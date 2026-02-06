using System.ComponentModel;
using System.Security.Principal;

public class SavingAccount:Account
{
    double total=0;
    public SavingAccount(int accountId,string type,int amount,int balance)
    {
        AccountId=accountId;
        AccountType=type;
        Amount=amount;
    }
    public void Deposit(int amount)
    {
        total+=amount;
        amount+=total;
        Console.WriteLine("Amount deposit");
    }
    public void Withdraw(int amount)
    {
        if (amount > total)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            total-=amount;
            Console.WriteLine("Amount withdrawn and current balance is " + total);
        }
    }
    public void CalculateInterest()
    {
        double totalAmount=amount+(0.06)*amount;
        Console.WriteLine("Total amount after interest" + totalAmount);
    }
    public void CheckBalance()
    {
        Console.WriteLine("Current balance : " + balance);
    }
}