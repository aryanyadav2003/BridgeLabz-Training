using System;
class BMIProgram{
 static void Main(){
   int n=int.Parse(Console.ReadLine());
   double[] weight=new double[n];
   double[] height=new double[n];
   double[] bmi=new double[n];
   string[] status=new string[n];
   for(int i=0;i<n;i++){
    Console.WriteLine($"Enter weight in kg of person {i+1}");
	weight[i]=Convert.ToDouble(Console.ReadLine());
	Console.WriteLine($"Enter height in cm of person {i+1}");
	height[i]=Convert.ToDouble(Console.ReadLine());
   }
   for(int i=0;i<n;i++){
    bmi[i]=weight[i]/height[i]*height[i];
	if(bmi[i]<=18.4){
	  status[i]="Underweight";
	}
	else if(bmi[i]>=18.5 && bmi[i]<=24.9){
	  status[i]="Normal";
	}
	else if(bmi[i]>=25.0 && bmi[i]<=39.9){
	  status[i]="Overweight";
	}
	else{
	  status[i]="Obese";
	}
   }
   for(int i=0;i<n;i++){
    Console.WriteLine($"{height[i]} {weight[i]} {bmi[i]} {status[i]}");
   }
 }
}