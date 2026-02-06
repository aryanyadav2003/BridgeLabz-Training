// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//banking system with multiple account types,saving ,current and loan account
//abstract class account -private balance,interest calculation
//overdraft allowed only for current account
//polymorphic method to calculateinterest
//deposit withdraw in savingaccount  --menu driven
using System.Security.Principal;

class Program
{
    static void Main()
    {
        Account s=new SavingAccount(101,"savings",1000,10000);
        Account c=new CurrentAccount(102,"current",1000,8000);
        Account l=new LoanAccount(103,"loan",500,5000);
        Console.WriteLine("----Bank Account Manager-----");
        Console.WriteLine("1.Deposit Amout");
        Console.WriteLine("2.Withdraw Amount");
        Console.WriteLine("3.Calculate Interset");
        Console.WriteLine("4.Check Balance");
        Console.WriteLine("Enter choice");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
              Console.WriteLine("Enter amount to deposit");
              int amount=int.Parse(Console.ReadLine());
              s.Deposit();
              break;
            case 2:
              Console.WriteLine("Enter amount to be withdraw");
              int amount=int.Parse(Console.ReadLine());
              s.Withdraw();
              break;
            case 3:
              
              s.CalculateInterest();
              break;

            default:
              Console.WriteLine("Enter valid choice");
              break;
        }
    }
}