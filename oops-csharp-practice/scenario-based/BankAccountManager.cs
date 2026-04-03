using System;
//Bank
  class Bank{
    public string BankName;
	public string IFSC;
	public double MinimumBalance;
	public int MaximumTransactionsPerDay;
	
	public Bank(string name,string ifsc,double minBalance,int maxTran){
	  BankName = name;
	  IFSC = ifsc;
	  MinimumBalance = minBalance;
	  MaximumTransactionsPerDay = maxTran;
	}
  }
//User
 class User{
    public string Name;
	public string AccountType;
	public string AccountNumber;
	public double DepositAmount;
	public double Balance;
	public int TransactionCount;
	
	Bank bank;
	
	public User(string name,string accNo,string accType,Bank bank){
	  Name=name;
	  AccountNumber=accNo;
	  AccountType=accType;
	  this.bank=bank;
	  
	  Balance=bank.MinimumBalance;
	  TransactionCount=0;
	  DepositAmount=0;
	  
	}
	public void Deposit(double amount){
	  if(TransactionCount >= bank.MaximumTransactionsPerDay){
	     Console.WriteLine("Daily transaction limit reached.");
		 return;
	  }
	  if(amount <= 0){
	     Console.WriteLine("Invaild deposit amount.");
		 return;
	  }
	  DepositAmount = amount;
	  Balance+= amount;
	  TransactionCount++;
	  
	  Console.WriteLine("Deposit successful: " + DepositAmount);
	}
	
	public void Withdraw(double amount){
	  double minBalance = bank.MinimumBalance;
	  
	  if (amount <= 0){
          Console.WriteLine("Invalid withdrawal amount.");
          return;
        }
	  
	  if(AccountType.ToLower() == "current" ){
	    minBalance = 0;
	  }
	  if(TransactionCount >= bank.MaximumTransactionsPerDay){
	    Console.WriteLine("Daily transaction limit reached.");
		return;
	  }
	  if(Balance - amount < minBalance){
	   Console.WriteLine("Withdrawal denied! Minimum balance must be maintained.");
	  }
	  else{
	   Balance-=amount;
	   TransactionCount++;
	   Console.WriteLine("Withdrawal successful.");
	  }
	}
	 public void CheckBalance(){
	   Console.WriteLine("Current Balance: " + Balance);
	 }
	  public void ShowDetails(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Type: " + AccountType);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Last Deposit Amount: " + DepositAmount);
        Console.WriteLine("Transactions Today: " + TransactionCount);
        Console.WriteLine("Bank IFSC: " + bank.IFSC);
    }
  }
//Bank Manager Role
 class BankManager{
    User[] users;
	int count;
	
	public BankManager(){
	  users = new User[10];
	  count = 0;
	}
	public void CreateAccount(string name,string accNo,string accType,Bank bank){
	   users[count] = new User(name,accNo,accType,bank);
	   count++;
	   Console.WriteLine("Account created with minimum balance: " + bank.MinimumBalance);
	}
	public void DeleteAccount(string accNo){
	  for(int i=0;i<count;i++){
	     if(users[i].AccountNumber == accNo){
		    users[i]=users[count-1];
			users[count-1]=null;
			count--;
			Console.WriteLine("Account deleted");
			return;
		 }
	  }
	  Console.WriteLine("Account not found.");
	}
	public User GetUser(string accNo){
	  for(int i=0;i<count;i++){
	    if(users[i].AccountNumber == accNo){
		   return users[i];
		}
	  }
	  return null;
	}
 }
class BankAccountManager{
	  static void Main(){	  
	      Bank bank = new Bank("Bank Of Baroda", "BRDG0001", 1000, 3);
		  BankManager manager = new BankManager();
		 
        while(true){
			Console.WriteLine("--- Select Role ---");
			Console.WriteLine("1. Bank Manager");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
			int role = int.Parse(Console.ReadLine());
			
			switch(role){
				case 1: //manager
				   Console.WriteLine("1. Create Account");
                   Console.WriteLine("2. Delete Account");
				   
				   int mChoice = int.Parse(Console.ReadLine());
				   
				   switch(mChoice){
					   case 1:
					     Console.Write("Enter Name :");
						 string name=Console.ReadLine();
						 
						 Console.Write("Enter Account Number: ");
                         string accNo = Console.ReadLine();

                         Console.Write("Enter Account Type (Savings/Current): ");
                         string accType = Console.ReadLine();
						 manager.CreateAccount(name, accNo, accType, bank);
                         break;
					    
						case 2:
						   Console.Write("Enter Account Number to delete: ");
                            string delAcc = Console.ReadLine();
                            manager.DeleteAccount(delAcc);
                            break;
							
						default:
						    Console.WriteLine("Invalid option.");
                            break;
				   }
				   break;
				case 2: //user  
				   Console.Write("Enter Account Number:");
				   string userAcc = Console.ReadLine();
				   
				   User user = manager.GetUser(userAcc);
				   if (user == null)
                    {
                        Console.WriteLine("Account not found.");
                        break;
                    }
					Console.WriteLine("\n1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Show Details");
					
					int uChoice = int.Parse(Console.ReadLine());
					
					switch(uChoice){
					   case 1:
					       Console.Write("Enter deposit amount: ");
                           double dep = double.Parse(Console.ReadLine());
                            user.Deposit(dep);
                         break;
					   case 2:
                            Console.Write("Enter withdrawal amount: ");
                            double wd = double.Parse(Console.ReadLine());
                            user.Withdraw(wd);
                            break;

                        case 3:
                            user.CheckBalance();
                            break;

                        case 4:
                            user.ShowDetails();
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
					}
					break;
					
				case 3:
                    Console.WriteLine("Thank you!");
                    return;

                default:
                    Console.WriteLine("Invalid role selection.");
                    break;
			}
		}
		 
	
	   }
	}
  