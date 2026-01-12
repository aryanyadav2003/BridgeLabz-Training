// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LoanBuddy =====");
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Credit Score: ");
        int creditScore = int.Parse(Console.ReadLine());
        Console.Write("Enter Monthly Income: ");
        double income = double.Parse(Console.ReadLine());
        Applicant applicant =new Applicant(name, creditScore, income);
        Console.WriteLine("\nChoose Loan Type");
        Console.WriteLine("1. Personal Loan");
        Console.WriteLine("2. Home Loan");
        Console.WriteLine("3. Auto Loan");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter Loan Amount: ");
        double amount = double.Parse(Console.ReadLine());
        Console.Write("Enter Loan Term (months): ");
        int term = int.Parse(Console.ReadLine());
        LoanApplication loan = null;
        switch (choice)
        {
            case 1:
                loan = new PersonalLoan(applicant, amount, term);
                break;
            case 2:
                loan = new HomeLoan(applicant, amount, term);
                break;
            case 3:
                loan = new AutoLoan(applicant, amount, term);
                break;
            default:
                Console.WriteLine("Invalid Choice");
                return;
        }
        if (loan.ApproveLoan())
        {
            Console.WriteLine("Loan Approved");
            Console.WriteLine("EMI: " +
                Math.Round(loan.CalculateEMI(), 2));
        }
        else
        {
            Console.WriteLine("Loan Rejected");
        }
    }
}
