class HomeLoan : LoanApplication
{
    public HomeLoan(Applicant applicant, double amount, int term)
        : base(applicant, amount, term, 8.5) { }

    public override bool ApproveLoan()
    {
        bool approved =applicant.GetCreditScore() >= 700 && applicant.GetIncome() >= 50000;
        SetApproved(approved);
        return approved;
    }
}
