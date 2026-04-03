using System;
class EmployeeUtilityImpl
{ 
    Employee emp=new Employee();
    Random random=new Random();
    public void AddEmployee()
    {
        //logic
        Console.Write("Enter Employee ID: ");
        string id=Console.ReadLine();
        Console.Write("Enter Employee Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter Employee Age: ");
        int age=int.Parse(Console.ReadLine());
        emp.AddEmployee(id, name, age);
        Console.WriteLine("Employee Added Successfully");
    }
     public void DisplayEmployee()
    {
        //logic
        emp.DisplayEmployee();
    }
    //Check Attendance:Absent=0,FullTime=1,PartTime=2
    public int CheckAttendance()
    {
        return random.Next(0,3);
    }
     public void CalculateDailyWage()
    {
        int attendance=CheckAttendance();
        int hours=0;
        switch(attendance)
        {
           case 0:
                Console.WriteLine("Employee is Absent");
                hours=0;
                break;
            case 1:
                Console.WriteLine("Employee is Present (Full Time)");
                hours=emp.FullDayHour;
                break;
            case 2:
                Console.WriteLine("Employee is Present (Part Time)");
                hours=emp.PartTimeHour;
                break;
        }
        int dailyWage = emp.DailyWage(hours);
        Console.WriteLine("Daily Wage: " + dailyWage);
    }
    public void CalculateWagesTillCondition()
        {
            int totalHours=0;
            int totalDays=0;
            int totalWage=0;
            int maxHours=100;
            int maxDays=20;
            while (totalHours<maxHours && totalDays<maxDays)
            {
                int attendance=CheckAttendance();
                int hours=0;
                switch(attendance)
                {
                    case 0:
                        hours=0;
                        Console.WriteLine("Day " +(totalDays + 1) + ": Absent");
                        break;
                    case 1:
                        hours=emp.FullDayHour;
                        Console.WriteLine("Day " +(totalDays + 1) + ": Full Time (" + hours + " hrs)");
                        break;
                    case 2:
                        hours=emp.PartTimeHour;
                        Console.WriteLine("Day " +(totalDays + 1) + ": Part Time (" + hours + " hrs)");
                        break;
                }
                totalHours+=hours;
                totalDays++;
                totalWage+=emp.DailyWage(hours);
            }
            Console.WriteLine($"Total Days Worked: {totalDays}");
            Console.WriteLine($"Total Hours Worked: {totalHours}");
            Console.WriteLine($"Total Wage: {totalWage}");
        }

}