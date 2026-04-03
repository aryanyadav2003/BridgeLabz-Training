using System;
class EmployeeBonus{
 static void Main(){
 Console.WriteLine("Enter the Salary:");
 double salary=Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Enter years of experience:");
 double exp=Convert.ToDouble(Console.ReadLine());
 if(exp>=5){
 double bonus=salary*0.05;
 Console.WriteLine("Bonus amount is:" + bonus);
 }
 else{
 Console.WriteLine("no bonus");
 }
 }
}