using System;
class BankAccount{
    public long accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(long accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public double GetBalance()
    {
        return balance;
    }
    public void Deposit(double amount){
        if (amount > 0){
            balance += amount;
        }
        else{
            Console.WriteLine("Invalid deposit amount");
        }
    }
    public void Withdraw(double amount){
        if (amount > 0 && amount <= balance){
            balance -= amount;
        }
        else{
            Console.WriteLine("Invalid withdrawal amount");
        }
    }
}
class SavingsAccount : BankAccount{
    public double interestRate;

    public SavingsAccount(long accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance){
        this.interestRate = interestRate;
    }

    public void DisplayDetails(){
        Console.WriteLine("Account Number: " + accountNumber);   
        Console.WriteLine("Account Holder: " + accountHolder);   
        Console.WriteLine("Balance: " + GetBalance());         
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}
class BankAccountManagement{
    static void Main(){
        SavingsAccount sa = new SavingsAccount(1234567890, "Aryan Yadav", 5000, 4.5);
        sa.DisplayDetails();
        sa.Deposit(1500);
        sa.Withdraw(2000);

        Console.WriteLine("Updated Balance: " + sa.GetBalance());
    }
}
