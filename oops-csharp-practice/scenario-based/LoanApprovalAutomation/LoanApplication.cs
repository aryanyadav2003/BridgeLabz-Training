using System;
abstract class LoanApplication : IApprovable
{
    protected Applicant applicant;
    protected double loanAmount;
    protected int term;
    protected double interestRate;
    private bool approved;
    public LoanApplication(Applicant applicant,double loanAmount,int term,double interestRate)
    {
        this.applicant=applicant;
        this.loanAmount = loanAmount;
        this.term = term;
        this.interestRate = interestRate;
    }
    protected void SetApproved(bool status)
    {
        approved=status;
    }
    public bool IsApproved()
    {
        return approved;
    }
     public virtual double CalculateEMI()
    {
        double R = interestRate / (12 * 100);
        return (loanAmount * R * Math.Pow(1 + R, term))/(Math.Pow(1 + R, term) - 1);
    }
    public abstract bool ApproveLoan();
}