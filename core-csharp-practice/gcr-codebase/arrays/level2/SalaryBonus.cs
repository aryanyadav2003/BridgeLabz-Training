using System;
class SalaryBonus{
  static void Main(){
   int n=10;
   double[] salary=new double[n];
   double[] years=new double[n];
   double[] bonus=new double[n];
   double[] newSalary=new double[n];
   double tBonus=0.0;
   double tOldSalary=0.0;
   double tNewSalary=0.0;
   
   for(int i=0;i<n;i++){
     Console.WriteLine($"Enter salary for employee {i+1}");
	 double sal=double.Parse(Console.ReadLine());
	 Console.WriteLine($"Enter years of service for employee {i+1}");
	 double yr=double.Parse(Console.ReadLine());
	 
	 if(sal<=0 || yr<0){
	   Console.WriteLine("Invalid input");
	   i--;
	   continue;
	 }
	 salary[i]=sal;
	 years[i]=yr;
   }
   for(int i=0;i<n;i++){
     if(years[i]>5){
	  bonus[i]=salary[i]*0.05;
	 }
	 else{
	  bonus[i]=salary[i]*0.02;
	 }
	 newSalary[i]=salary[i]+bonus[i];
	 tBonus+=bonus[i];
	 tOldSalary+=salary[i];
	 tNewSalary+=newSalary[i];
   }
   for(int i=0;i<n;i++){
     Console.WriteLine($"Employee {i+1} Old Salary: {salary[i]} Bonus: {bonus[i]} New Salary: {newSalary[i]}");
   }
   Console.WriteLine("total Old Salary = " + tOldSalary);
   Console.WriteLine("total  Bonus = " + tBonus);
   Console.WriteLine("total New Salary = " + tNewSalary);
  }
}