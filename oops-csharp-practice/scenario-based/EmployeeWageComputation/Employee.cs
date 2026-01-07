using System;
class Employee : IEmployee
{
    private string EmployeeId{get;set;}
    private string EmployeeName{get;set;}
    private int EmployeeAge{get;set;}
    public int WagePerHour=20;
    public int FullDayHour=8;
    public int PartTimeHour=4;
    public int DailyWage(int hours)
    {
        return hours * WagePerHour;
    }
    public void AddEmployee(string id,string name,int age)
    {
        EmployeeId=id;
        EmployeeName=name;
        EmployeeAge=age;
    }
     public void DisplayEmployee()
    {
        Console.WriteLine(ToString());
    }
    //override toString
    public override string ToString()
    {
        return "Employee Id : " + EmployeeId + "\nEmployee Name : " + EmployeeName + "\nEmployee Age : " + EmployeeAge;
    } 
}