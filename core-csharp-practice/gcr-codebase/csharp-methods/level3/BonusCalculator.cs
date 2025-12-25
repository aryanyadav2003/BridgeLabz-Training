using System;
class BonusCalculator{
    const int n=10;
    public static double[,] GenerateEmployeeData(){
        Random rand=new Random();
        double[,] data=new double[n, 2];
        for (int i=0;i<n;i++){
            data[i,0]=rand.Next(10000,100000);
            data[i,1]=rand.Next(1,11);  
        }
        return data;
    }
    public static double[,] CalculateBonus(double[,] data){
        double[,] result=new double[n,3];
        for(int i=0;i<n;i++){
            double salary=data[i,0];
            double years=data[i,1];
            double bonus;
            if (years>5) bonus=salary*0.05;
            else bonus=salary*0.02;
            result[i,0]=salary;
            result[i,1]=bonus;
            result[i,2]=salary+bonus;
        }
        return result;
    }

    static void Main()
    {
        double[,] employeeData=GenerateEmployeeData();
        double[,] salaryResult=CalculateBonus(employeeData);
		double totalOld=0,totalNew=0,totalBonus=0;
		for(int i=0;i<n;i++){
		  Console.WriteLine($"{i + 1} {salaryResult[i,0]} {employeeData[i,1]} {salaryResult[i,1]} {salaryResult[i,2]}");
		
		totalOld+=salaryResult[i,0];
        totalBonus+=salaryResult[i,1];
        totalNew+=salaryResult[i,2];
	}
		Console.WriteLine($"TOTAL old:{totalOld} bonus:{totalBonus}new:{totalNew}");
    }
}
