class AutoLoan : LoanApplication
{
    public AutoLoan(Applicant applicant, double amount, int term)
        : base(applicant, amount, term, 10.5) { }

    public override bool ApproveLoan()
    {
        bool approved =applicant.GetCreditScore() >= 600 && applicant.GetIncome() >= 25000;
        SetApproved(approved);
        return approved;
    }
}
