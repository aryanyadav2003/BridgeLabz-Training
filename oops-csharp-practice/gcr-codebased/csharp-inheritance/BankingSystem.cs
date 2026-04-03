using System;
class BankAccount{
   public int AccountNumber;
   public double Balance;
   public virtual void DisplayAccountType(){
     Console.WriteLine("Bank acc");
   }
}
class SavingsAccount:BankAccount{
  public double InterestRate;
  public override void DisplayAccountType(){
    Console.WriteLine("Account Number: " + AccountNumber);
    Console.WriteLine("Balance: " + Balance);
    Console.WriteLine("Interest Rate: " + InterestRate + "%");
  }
}
class CheckingAccount:BankAccount{
  public double WithdrawalLimit;
  public override void DisplayAccountType(){
    Console.WriteLine("Account Number: " + AccountNumber);
    Console.WriteLine("Balance: " + Balance);
    Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
  }
}
class FixedDepositAccount:BankAccount{
    public int Tenure;
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Tenure: " + Tenure + " months");
    }
}
class BankingSystem{
    static void Main(){
        BankAccount a1 = new SavingsAccount{
            AccountNumber = 101,
            Balance = 50000,
            InterestRate = 4.5
        };
        BankAccount a2 = new CheckingAccount{
            AccountNumber = 102,
            Balance = 20000,
            WithdrawalLimit = 10000
        };
        BankAccount a3 = new FixedDepositAccount{
            AccountNumber = 103,
            Balance = 100000,
            Tenure = 24
        };
        a1.DisplayAccountType();
        Console.WriteLine();

        a2.DisplayAccountType();
        Console.WriteLine();

        a3.DisplayAccountType();
    }
}