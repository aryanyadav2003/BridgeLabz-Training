using System;
class EmployeeUtilityImpl
{ 
    private Employee emp=new Employee();
    private Random random=new Random();
    public void AddEmployee()
    {
        //logic
        Console.Write("Enter Employee ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Employee Age: ");
        int age = int.Parse(Console.ReadLine());
        emp.AddEmployee(id, name, age);
        Console.WriteLine("Employee Added Successfully");
    }
     public void DisplayEmployee()
    {
        //logic
        emp.DisplayEmployee();
    }
    //Check Attendance:Absent=0,Full Time=1,Part Time=2
    public int CheckAttendance()
    {
        return random.Next(0, 3);
    }
     public void CalculateDailyWage()
    {
        int attendance = CheckAttendance();
        int hours = 0;
        switch (attendance)
        {
            case 1:
                Console.WriteLine("Employee is Present (Full Time)");
                hours = emp.FullDayHour;
                break;
            case 2:
                Console.WriteLine("Employee is Present (Part Time)");
                hours = emp.PartTimeHour;
                break;
            default:
                Console.WriteLine("Employee is Absent");
                hours = 0;
                break;
        }
        int dailyWage = emp.DailyWage(hours);
        Console.WriteLine("Daily Wage: " + dailyWage);
    }
}