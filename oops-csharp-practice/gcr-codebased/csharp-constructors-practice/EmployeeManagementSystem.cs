using System;
class Employee{
   public static string CompanyName = "abc solutions pvt. ltd";
   public static int totalEmployees = 0;
   public readonly int Id;
   
   public string Name;
   public string Designation;
   
   public Employee(int Id, string Name, string Designation){
      this.Id = Id;                 
      this.Name = Name;           
      this.Designation = Designation;
	  totalEmployees++;
   }
   public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
   public void DisplayEmployeeDetails(){
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Designation: " + Designation);
    }
}
class EmployeeManagementSystem{
    static void Main(){
        Employee emp1 = new Employee(1, "Aryan", "Software Engineer");
        Employee emp2 = new Employee(2, "Rohit", "Data Analyst");

        Employee.DisplayTotalEmployees();

        if (emp1 is Employee){
            Console.WriteLine("\nEmployee 1 Details:");
            emp1.DisplayEmployeeDetails();
        }
        if (emp2 is Employee){
            Console.WriteLine("\nEmployee 2 Details:");
            emp2.DisplayEmployeeDetails();
        }
		}}