using System;
class BankAccount{
  public static string bankName = "National Bank";
  public static int totalAccounts = 0;
  public readonly int AccountNumber;
  public string AccountHolderName;
  
  public BankAccount(int AccountNumber, string AccountHolderName){
    this.AccountNumber = AccountNumber;               
    this.AccountHolderName = AccountHolderName;     
    totalAccounts++;
  }
  
  public static void GetTotalAccounts(){
    Console.WriteLine("Total Accounts: " + totalAccounts);
  }
   public void DisplayDetails(){
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolderName);
    }
}
class BankAccountSystem{
  static void Main(){
    BankAccount acc1 = new BankAccount(101,"Aryan");
	BankAccount acc2 = new BankAccount(102,"Rohit");
	
	BankAccount.GetTotalAccounts();
	
	if(acc1 is BankAccount){
	  Console.WriteLine("Account 1 details:");
	  acc1.DisplayDetails();
	}
	if(acc2 is BankAccount){
	  Console.WriteLine("Account 2 details:");
	  acc2.DisplayDetails();
	}
  }
}