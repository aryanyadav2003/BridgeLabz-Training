
public class CurrentAccount : Account
{
    int minBalance=5000;
    double total=0;
    public CurrentAccount(int accountId,string type,int amount,int balance)
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
        if (balance < minBalance && amount < balance)
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
