using System;
class Employee{
 public string name;
 public int id;
 public double salary;
 
 public void DisplayDetails(){
   Console.WriteLine("Employee Name : " + name);
   Console.WriteLine("Employee ID  : " + id);
   Console.WriteLine("Employee Salary : " + salary);
 }
 class EmployeeDetails{
  static void Main(){
    Employee emp = new Employee();
	Console.Write("Enter Name: ");
    emp.name = Console.ReadLine();

    Console.Write("Enter ID: ");
    emp.id = int.Parse(Console.ReadLine());

    Console.Write("Enter Salary: ");
    emp.salary = double.Parse(Console.ReadLine());
	 emp.DisplayDetails();
  }
 }
}