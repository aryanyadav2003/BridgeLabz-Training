class Applicant
{
    public string Name { get; private set; }
    protected int CreditScore { get; private set; }
    protected double Income { get; private set; }
    public Applicant(string name, int creditScore, double income)
    {
        Name = name;
        CreditScore = creditScore;
        Income = income;
    }
    public int GetCreditScore()
    {
        return CreditScore;
    }
    public double GetIncome()
    {
        return Income;
    }
}
