using System;
class Employee{
  public int employeeID;
  protected string department;
  private double salary;
  public Employee(int employeeID,string department,double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
  }
  public void SetSalary(double salary){
    if(salary > 0){
	  this.salary=salary;
	}
	else{
       Console.WriteLine("Invalid salary amount");
        }
  }
  public double GetSalary(){
    return salary;
  }
}
class Manager : Employee{
    public string role;
	public Manager(int employeeID, string department, double salary, string role) : base(employeeID, department, salary){
	    this.role = role ;
	}
	public void DisplayDetails(){
        Console.WriteLine("Employee ID: " + employeeID);  
        Console.WriteLine("Department: " + department);  
        Console.WriteLine("Salary: " + GetSalary());     
        Console.WriteLine("Role: " + role);
    }
}
class EmployeeRecords{
  static void Main(){
      Manager manager = new Manager(1001, "IT", 60000, "Project Manager");
	  manager.DisplayDetails();
	  manager.SetSalary(75000);
	  Console.WriteLine("Updated Salary: " + manager.GetSalary());
  }
}