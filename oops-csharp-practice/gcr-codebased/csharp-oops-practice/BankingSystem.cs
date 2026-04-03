using System;
using System.Reflection.Metadata.Ecma335;
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}
abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    protected double balance;
    public void SetAccountDetails(int accNo,string name,double bal)
    {
        accountNumber=accNo;
        holderName=name;
        balance=bal;
    }
    public void Deposit(double amount)
    {
        balance+=amount;
        Console.WriteLine("Deposited: " + amount);
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance-=amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
    public abstract double CalculateInterest();
    public void Display()
    {
        Console.WriteLine("Account No : " + accountNumber);
        Console.WriteLine("Name       : " + holderName);
        Console.WriteLine("Balance    : " + balance);
        Console.WriteLine("Interest   : " + CalculateInterest());
        Console.WriteLine("------------------------");
    }
}
class SavingsAccount:BankAccount,ILoanable
{
    public override double CalculateInterest()
    {
        return balance*0.04;
    }
    public void ApplyForLoan(){
        Console.WriteLine("Loan applied (Savings)");
    }
    public double CalculateLoanEligibility()
    {
        return balance*5;
    }
}
class CurrentAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
       return balance*0.02;
    }
    public void ApplyForLoan()
    {
        Console.WriteLine("Current Account: Loan Applied");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 3;
    }
}
class BankingSystem
{
    static void Main()
    {
        SavingsAccount s=new SavingsAccount();
        s.SetAccountDetails(101,"Aryan",10000);
        s.Deposit(2000);
        s.Withdraw(500);
        s.ApplyForLoan();
        Console.WriteLine("Loan Eligibility : " + s.CalculateLoanEligibility());
        Console.WriteLine();

        CurrentAccount c = new CurrentAccount();
        c.SetAccountDetails(102, "Aditya", 80000);
        c.Deposit(10000);
        c.Withdraw(30000);
        c.ApplyForLoan();
        Console.WriteLine("Loan Eligibility: " + c.CalculateLoanEligibility());
        Console.WriteLine("--- Account Details ---");
        BankAccount[] accounts={s,c};
        for(int i = 0; i < accounts.Length; i++)
        {
            accounts[i].Display();
        }
    }
}