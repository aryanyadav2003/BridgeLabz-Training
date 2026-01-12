class PersonalLoan : LoanApplication
{
    public PersonalLoan(Applicant applicant,double amount,int term):base(applicant,amount,term,14.5){}
    public override bool ApproveLoan()
    {
        bool approved=applicant.GetCreditScore()>=650 && applicant.GetIncome()>=30000;
        SetApproved(approved);
        return approved;
    }
}