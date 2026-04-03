using System;
interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}
abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;
    protected string department;
    public int EmpoyeeId
    {
        get { return employeeId;}
        set { employeeId=value;}
    }
    public string Name
    {
        get {return name;}
        set { name = value;}
    }
    public Employee(int id,string name,double baseSalary)
    {
        this.employeeId=id;
        this.name=name;
        this.baseSalary=baseSalary;
    }
    public abstract double CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine("ID        : " + employeeId);
        Console.WriteLine("Name      : " + name);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary    : " + CalculateSalary());
        Console.WriteLine("--------------------------");
    }
}
class FullTimeEmployee : Employee, IDepartment
{
    public FullTimeEmployee(int id,string name,double salary): base(id, name, salary){}
    public override double CalculateSalary()
    {
        return baseSalary;
    }
    public void AssignDepartment(string deptName)
    {
        department=deptName;
    }
    public string GetDepartmentDetails()
    {
        return department;
    }
}
class PartTimeEmployee : Employee, IDepartment
{
    int hoursWorked;
    public PartTimeEmployee(int id,string name,double hourlyRate,int hours) : base(id, name, hourlyRate)
    {
        hoursWorked=hours;
    }
    public override double CalculateSalary()
    {
        return baseSalary*hoursWorked;
    }
    public void AssignDepartment(string deptName)
    {
        department=deptName;
    }
    public string GetDepartmentDetails()
    {
        return department;
    }
}
class EmployeeManagement
{
    static void Main()
    {
        Employee[] employees=new Employee[2];
        FullTimeEmployee e1=new FullTimeEmployee(101,"Aryan",20000);
        e1.AssignDepartment("IT");
        PartTimeEmployee e2=new PartTimeEmployee(102,"Aman",500,6);
        e2.AssignDepartment("HR");

        employees[0]=e1;
        employees[1]=e2;
        for(int i = 0; i < employees.Length; i++)
        {
            employees[i].DisplayDetails();
        }
    }
}