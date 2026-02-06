
public class LoanAccount : Account
{
    double total=0;
    public LoanAccount(int accountId,string type,int amount,int balance)
    {
        AccountId=accountId;
        AccountType=type;
        Amount=amount;
        Balance=balance;
    }
    public void Deposit(int amount)
    {
        total+=amount;
        balance+=total;
        Console.WriteLine("Amount deposited");
    }
    public void Withdraw(int amount)
    {
        if (amount < balance)
        {
            Console.WriteLine("Amount cannot be withdrawn");
        }
        else
        {
            total-=amount;
            Console.WriteLine("Amount withdrawn");
        }
    }
    public void CalculateInterest()
    {
        double totalAmount=balance+(0.10)*balance;
        Console.WriteLine("Total amount after interest" + totalAmount);
    }
    public void CheckBalance()
    {
        Console.WriteLine("Current balance : " +balance);
    }
}
