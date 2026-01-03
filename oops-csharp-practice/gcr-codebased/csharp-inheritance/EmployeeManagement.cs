using System;
class Employee{
  public string Name;
  public int id;
  public double Salary;
  
  public virtual void DisplayDetails(){
    Console.WriteLine("Name" + Name);
	Console.WriteLine("id" + id);
	Console.WriteLine("Salary" + Salary);
  }
}
class Manager:Employee{
   public int TeamSize;
   public override void DisplayDetails(){
        Console.WriteLine("Employee Type: Manager");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Team Size: " + TeamSize);
    }
  
}
class Developer:Employee{
  public string ProgrammingLanguage;
  public override void DisplayDetails(){
        Console.WriteLine("Employee Type: Developer");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
  
}
class Intern:Employee{
  public string InternshipDuration;
  public override void DisplayDetails(){
        Console.WriteLine("Employee Type: Intern");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}
class EmployeeManagement{
   static void Main(){
     Employee e1=new Manager{Name="Aryan",id=101,Salary=1000,TeamSize=10};
	 Employee e2=new Developer{Name="Aryan",id=101,Salary=1000,ProgrammingLanguage="c#"};
	 Employee e3=new Intern{Name="Aryan",id=101,Salary=1000,InternshipDuration="6 months"};
	 
	 e1.DisplayDetails();
     Console.WriteLine();

     e2.DisplayDetails();
     Console.WriteLine();

     e3.DisplayDetails();
   }
}