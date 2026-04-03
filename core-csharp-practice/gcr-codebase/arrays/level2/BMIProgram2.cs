using System;
class BMIProgram2{
 static void Main(){
   int n=int.Parse(Console.ReadLine());
   double[,] data=new double[n,3];
   string[] status=new string[n];
   for(int i=0;i<n;i++){
    Console.WriteLine($"Enter weight in kg of person {i+1}");
	double weight=Convert.ToDouble(Console.ReadLine());
	Console.WriteLine($"Enter height in cm of person {i+1}");
	double height=Convert.ToDouble(Console.ReadLine());
	data[i,0]=weight;
	data[i,1]=height;
   }
   for(int i=0;i<n;i++){
    double bmi=data[i,0]/(data[i,1])*(data[i,1]);
	data[i,2]=bmi;
	if(bmi<=18.4){
	  status[i]="Underweight";
	}
	else if(bmi>=18.5 && bmi<=24.9){
	  status[i]="Normal";
	}
	else if(bmi>=25.0 && bmi<=39.9){
	  status[i]="Overweight";
	}
	else{
	  status[i]="Obese";
	}
   }
   for(int i=0;i<n;i++){
    Console.WriteLine($"{data[i,1]} {data[i,0]} {data[i,2]} {status[i]}");
   }
 }
}