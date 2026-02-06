public class Account
{
    private int AccountId{get;set;}
    private int Name{get;set;}
    public string AccountType;
    private double Balance{get; set;}
    public int Amount;
    public void CheckBalance();
    public void CalculateInterest();
    public void Deposit();
    public void Withdraw();

}