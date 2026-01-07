using System;
namespace EmployeeWageComputation;
class EmployeeMenu
{
    EmployeeUtilityImpl util = new EmployeeUtilityImpl();
    public void ShowMenu()
    {
        Console.WriteLine("--- Employee Wage Computation ---");
        Console.WriteLine("1. Add Employee");
        Console.WriteLine("2. Check Attendance");
        Console.WriteLine("3. Calculate Daily Wage");
        Console.WriteLine("4. Display Employee");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                util.AddEmployee();
                break;
            case 2:
                int status = util.CheckAttendance();
                 switch (status)
                {
                    case 0:
                        Console.WriteLine("Employee Absent");
                        break;
                    case 1:
                        Console.WriteLine("Employee Present (Full Time)");
                        break;
                    case 2:
                        Console.WriteLine("Employee Present (Part Time)");
                        break;
                }
                break;
            case 3:
                util.CalculateDailyWage();
                break;
            case 4:
                util.DisplayEmployee();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
